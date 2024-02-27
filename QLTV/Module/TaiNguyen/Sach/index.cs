using QLTV.Data.Entity;
using QLTV.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.Module.TaiNguyen.Sach
{
    public partial class index : UserControl
    {
        private DBContext dbContext;
        private static index _instance;
        private string pathApp;
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
            this.setComboboxCreatedDate();
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
            var query = from book in dbContext.Books
                        join category in dbContext.Categories on book.CategoryId equals category.Id
                        join author in dbContext.Authors on book.AuthorId equals author.Id
                        where book.Deleted == 0
                        select new { book, category, author };


            if (constraint != null)
            {
                if (constraint.TryGetValue("name", out string name))
                    query = query.Where(data => data.book.Name.ToLower().Contains(name.ToLower()));

                if (constraint.TryGetValue("authorName", out string authorName))
                    query = query.Where(data => data.author.Name.ToLower().Contains(authorName.ToLower()));

                if (constraint.TryGetValue("categoryName", out string categoryName))
                    query = query.Where(data => data.category.Name.ToLower().Contains(categoryName.ToLower()));

                if (constraint.TryGetValue("createdDate", out string createdDate))
                {
                    if (createdDate.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        query = query.OrderByDescending(data => data.book.CreateDay);

                    if (createdDate.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        query = query.OrderBy(data => data.book.CreateDay);
                }
            }


            List<SachShow> listData = query.Select(data => new SachShow
            {
                Id = data.book.Id,
                PathImage = System.IO.Path.Combine(this.pathApp ?? this.getDrictoryApp(), "Resources", "image", data.book.Image),
                Name = data.book.Name,
                Amount = data.book.Amount,
                Category = data.category.Name ?? "Trống",
                Author = data.author.Name ?? "Trống",
                Price = data.book.Price.ToString(),
                CreatedDate = data.book.CreateDay.ToString("dd-MM-yyyy")
            }).ToList();

            this.dataGridViewData.Rows.Clear();

            foreach (SachShow ss in listData)
            {
                // Đảm bảo rằng đường dẫn hình ảnh tồn tại trước khi thêm vào DataGridView
                if (File.Exists(ss.PathImage))
                {
                    this.dataGridViewData.Rows.Add(ss.Id.ToString(), Image.FromFile(ss.PathImage), ss.Name, ss.Category, ss.Author, ss.Price, ss.Amount, ss.CreatedDate);
                }
                else
                {

                    this.dataGridViewData.Rows.Add(ss.Id.ToString(),
                        Image.FromFile(System.IO.Path.Combine(this.pathApp ?? this.getDrictoryApp(), "Resources", "image", "book.png"))
                        , ss.Name, ss.Category, ss.Author, ss.Price, ss.Amount, ss.CreatedDate);
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
        private void setComboboxCreatedDate()
        {
            // set  combobox ngay tao
            this.comboBoxNgayTao.Items.Clear();
            this.comboBoxNgayTao.Items.Add("Mặc định ");
            this.comboBoxNgayTao.Items.Add("Giảm dần");
            this.comboBoxNgayTao.Items.Add("Tăng dần");
            this.comboBoxNgayTao.SelectedIndex = 0;

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> constraint = new Dictionary<string, string>();
            if (this.comboBoxNgayTao.SelectedIndex != 0)
            {
                if (this.comboBoxNgayTao.SelectedIndex == 1) constraint.Add("createdDate", "desc");
                if (this.comboBoxNgayTao.SelectedIndex == 2) constraint.Add("createdDate", "asc");
            }
            if (this.comboBoxTacGia.SelectedIndex != 0) constraint.Add("authorName", this.comboBoxTacGia.SelectedItem.ToString());
            if (this.comboBoxTheLoai.SelectedIndex != 0) constraint.Add("categoryName", this.comboBoxTheLoai.SelectedItem.ToString());
            if (!string.IsNullOrEmpty(this.textBoxTimkiem.Text)) constraint.Add("name", this.textBoxTimkiem.Text);
            this.loadData(constraint);

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            add formAdd = new add();
            formAdd._eventAdd += this.reLoadData;
            formAdd.Show();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewData.SelectedRows.Count > 0)
            {
                int id = int.Parse(this.dataGridViewData.SelectedRows[0].Cells[0].Value.ToString());
                detail formDetail = new detail(id);
                formDetail.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn ít nhật một đối tượng để thực hiện hành động .");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewData.SelectedRows.Count > 0)
            {
                int id = int.Parse(this.dataGridViewData.SelectedRows[0].Cells[0].Value.ToString());
                edit form = new edit(id);
                form._eventAdd += this.reLoadData;
                form.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn ít nhật một đối tượng để thực hiện hành động .");
            }
        }

        private async void buttonXoa_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewData.SelectedRows.Count > 0)
            {
                string name = this.dataGridViewData.SelectedRows[0].Cells[2].Value.ToString();
                DialogResult rs= MessageBox.Show($"Không thể xoá \n Chỉ có thể ẩn . Bạn vẫn muốn tiếp tục ẩn sách có tên: \n {name}","Xác nhận xoá ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    int id = int.Parse(this.dataGridViewData.SelectedRows[0].Cells[0].Value.ToString());
                    Book model = dbContext.Books.FirstOrDefault(model => model.Id == id);
                    model.Deleted = 1;
                    await dbContext.SaveChangesAsync();
                    this.loadData(null);
                }
              
            }
            else
            {
                MessageBox.Show("Bạn cần chọn ít nhật một đối tượng để thực hiện hành động .");
            }
        }
    }
}
