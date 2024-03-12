using Microsoft.EntityFrameworkCore;
using QLTV.Data.Entity;
using QLTV.Data.Model;
using QLTV.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace QLTV.Module.BaoCao.SachItSuDung
{
    public partial class index : UserControl
    {
        private DBContext dbContext;
        private static index _instance;
        private string pathApp;
        private List<SachItSuDungShow> listData;
        public static index Instance
        {
            get
            {
                if (_instance == null) _instance = new index();
                return _instance;
            }
        }
        public index()
        {
            InitializeComponent();
            dbContext = new DBContext();
            pathApp = this.getDrictoryApp();
            this.loadData(null);
            this.setComboboxTacgia();
            this.setComboxTheLoai();
            
            this.comboBoxSetLoaiSachItSuDung.SelectedIndex = 0;
        }
        public string getDrictoryApp()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string[] words = projectDirectory.Split(new char[] { '\\' });
            Array.Resize(ref words, words.Length - 4);
            return string.Join("\\", words);
        }

        private void reLoadData(object sender, EventArgs e)
        {
            this.loadData(null);
        }
        private void loadData(Dictionary<string, string> constraint)
        {
           

            var query = $@"SELECT 
                    b.id,
                    b.image,
                    b.name AS book_name,
                    c.name AS category_name,
                    a.name AS author_name,
                    (SELECT COUNT(*) FROM dbo.borrow_request br WHERE br.book_id = b.id AND br.updated_at <= GETDATE() AND br.updated_at >= DATEADD(MONTH, -6, GETDATE())) AS SoLuotPhucVu
                FROM 
                    dbo.book b
                LEFT JOIN 
                    dbo.author a ON b.author_id = a.id
                LEFT JOIN 
                    dbo.category c ON b.category_id = c.id
                LEFT JOIN 
                    dbo.borrow_request br ON b.id = br.book_id
                WHERE 
                    1 = 1";

            if (constraint != null && constraint.Count()>0)
            {
                if (constraint.TryGetValue("name", out string name))
                    query += $" AND LOWER(b.name) LIKE '%{name.ToLower()}%'";

                if (constraint.TryGetValue("authorName", out string authorName))
                    query += $" AND LOWER(a.name) LIKE '%{authorName.ToLower()}%'";

                if (constraint.TryGetValue("categoryName", out string categoryName))
                    query += $" AND LOWER(c.name) LIKE '%{categoryName.ToLower()}%'";

              
                // Thêm phần GROUP BY và HAVING vào cuối câu truy vấn SQL
                if (constraint.TryGetValue("BorrowRequestCount", out string BorrowRequestCount))
                {
                    query += @$" GROUP BY  
                b.id,
                b.image,
                b.name ,
                c.name,
                a.name 
               HAVING 
          (SELECT COUNT(*) FROM dbo.borrow_request br WHERE br.book_id = b.id  AND br.updated_at <= GETDATE() AND br.updated_at >= DATEADD(MONTH, -6, GETDATE())) <= {int.Parse(BorrowRequestCount)}";
                }
                else
                {
                    query += @" GROUP BY  
                b.id,
                b.image,
                b.name ,
                c.name,
                a.name 
                HAVING 
               (SELECT COUNT(*) FROM dbo.borrow_request br WHERE br.book_id = b.id  AND br.updated_at <= GETDATE() AND br.updated_at >= DATEADD(MONTH, -6, GETDATE()))<=5";
                }

            }
            else
            {
                query += @" GROUP BY  
                b.id,
                b.image,
                b.name ,
                c.name,
                a.name 
                HAVING 
               (SELECT COUNT(*) FROM dbo.borrow_request br WHERE br.book_id = b.id  AND br.updated_at <= GETDATE() AND br.updated_at >= DATEADD(MONTH, -6, GETDATE()))<=5";
            }

            listData = new List<SachItSuDungShow>();
            using (var command = dbContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = query;
                dbContext.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       int id= reader.GetInt32("id");
                        string name = reader.GetString("book_name");
                        string image= System.IO.Path.Combine(this.pathApp ?? this.getDrictoryApp(), "Resources", "image", reader.GetString("image"));
                        string author_name = reader.GetString("author_name");
                        int BorrowRequestCount = reader.GetInt32("SoLuotPhucVu");
                        string category_name= reader.GetString("category_name");
                        listData.Add(new SachItSuDungShow(id, image, name, BorrowRequestCount, category_name, author_name));


                    }
                }
            }

         

            this.dataGridViewData.Rows.Clear();

            foreach (SachItSuDungShow ss in listData)
            {
                // Đảm bảo rằng đường dẫn hình ảnh tồn tại trước khi thêm vào DataGridView
                if (File.Exists(ss.PathImage))
                {
                    this.dataGridViewData.Rows.Add(ss.Id.ToString(), Image.FromFile(ss.PathImage), ss.Name, ss.Category, ss.Author, ss.BorrowRequestCount);
                }
                else
                {

                    this.dataGridViewData.Rows.Add(ss.Id.ToString(),
                        Image.FromFile(System.IO.Path.Combine(this.pathApp ?? this.getDrictoryApp(), "Resources", "image", "book.png"))
                        , ss.Name, ss.Category, ss.Author, ss.BorrowRequestCount);
                }
            }
        }


        private void setComboboxTacgia()
        {
            this.comboBoxTacGia.Items.Clear();
            this.comboBoxTacGia.Items.Add("Tất cả");
            List<Author> authorList = dbContext.Authors.ToList();

            foreach (Author author in authorList)
            {
                this.comboBoxTacGia.Items.Add(author.Name);
            }
            this.comboBoxTacGia.SelectedIndex = 0;
        }
        private void setComboxTheLoai()
        {
            this.comboBoxTheLoai.Items.Clear();
            this.comboBoxTheLoai.Items.Add("Tất cả");
            List<Category> categoryList = dbContext.Categories.ToList();

            foreach (Category category in categoryList)
            {
                this.comboBoxTheLoai.Items.Add(category.Name);
            }
            this.comboBoxTheLoai.SelectedIndex = 0;
        }
       

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> constraint = new Dictionary<string, string>();
        
            if (this.comboBoxTacGia.SelectedIndex != 0) constraint.Add("authorName", this.comboBoxTacGia.SelectedItem.ToString());
            if (this.comboBoxTheLoai.SelectedIndex != 0) constraint.Add("categoryName", this.comboBoxTheLoai.SelectedItem.ToString());
            if (!string.IsNullOrEmpty(this.textBoxTimkiem.Text)) constraint.Add("name", this.textBoxTimkiem.Text);
            this.loadData(constraint);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            List<SachItSuDungExportExcel> exportExcels=  new List<SachItSuDungExportExcel> ();
            exportExcels.Add(new SachItSuDungExportExcel("Id", "Tên", "Thể loại", "Tác giả", "Số lượng phục vụ"));
            foreach(SachItSuDungShow ss in this.listData) {

                exportExcels.Add(new SachItSuDungExportExcel(ss.Id.ToString(), ss.Name.ToString(),ss.Category,ss.Author,ss.BorrowRequestCount.ToString()));

            }
            ExcelExport<SachItSuDungExportExcel> excel = new ExcelExport<SachItSuDungExportExcel>(exportExcels, "Danh sách sách ít được sử dụng trong thư viện ");
        }

        private void buttonCaiDat_Click(object sender, EventArgs e)
        {
            if(
                string.IsNullOrEmpty(this.textBoxSetLoaiSachItDuocSuDung.Text)&&
                this.comboBoxSetLoaiSachItSuDung.SelectedIndex == 0
                )
            {
                MessageBox.Show("Giá trị cài đặt không được trông !");
                return;
            }
            else
            {
                Dictionary<string, string> constraint = new Dictionary<string, string>();
                int selectedIndex= this.comboBoxSetLoaiSachItSuDung.SelectedIndex;
                if (selectedIndex != 0)
                {
                    switch (selectedIndex)
                    {
                        case 1: constraint.Add("BorrowRequestCount", "10"); break;
                        case 2: constraint.Add("BorrowRequestCount", "15"); break;
                        default: constraint.Add("BorrowRequestCount", "20"); break;
                    }
                }
                if (!string.IsNullOrEmpty(this.textBoxSetLoaiSachItDuocSuDung.Text))
                {
                    try
                    {
                        selectedIndex = int.Parse(this.textBoxSetLoaiSachItDuocSuDung.Text);
                        constraint.Add("BorrowRequestCount", $"{selectedIndex}");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng chỉ là chữ số !");
                    }

                }
                this.loadData(constraint);
            }
        }
    }
}
