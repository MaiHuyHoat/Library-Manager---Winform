using QLTV.Data.Entity;
using QLTV.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.Module.MuonTra.MuonSach
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
            var query = from BorrowRequest in dbContext.BorrowRequests
                        join Reader in dbContext.Readers on BorrowRequest.ReaderId equals Reader.Id
                        join Book in dbContext.Books on BorrowRequest.BookId equals Book.Id
                        where BorrowRequest.Deleted == 0
                        select new { Book, BorrowRequest, Reader };

           
            if (constraint != null)
            {
                if (constraint.TryGetValue("cmt", out string cmt))
                    query = query.Where(data => data.Reader.IdentityCard.ToLower().Contains(cmt.ToLower()));



                if (constraint.TryGetValue("updatedAt", out string updatedAt))
                {
                    if (updatedAt.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        query = query.OrderByDescending(data => data.BorrowRequest.UpdatedAt);

                    if (updatedAt.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        query = query.OrderBy(data => data.BorrowRequest.UpdatedAt);
                }
            }


            List<MuonSachShow> listData = query.Select(data => new MuonSachShow
            {
                Id = data.BorrowRequest.Id,
                Image = System.IO.Path.Combine(this.pathApp ?? this.getDrictoryApp(), "Resources", "image", data.Book.Image),
                NameBook = data.Book.Name,
                NameReader = data.Reader.Name,
                IdentityCardReader = data.Reader.IdentityCard ?? "Trống",
                BorrowDate = data.BorrowRequest.UpdatedAt,
                DueDate = data.BorrowRequest.DueDate
            }).ToList();

            this.dataGridViewData.Rows.Clear();
           

            foreach (MuonSachShow ss in listData)
            {
                // Đảm bảo rằng đường dẫn hình ảnh tồn tại trước khi thêm vào DataGridView
                if (File.Exists(ss.Image))
                {
                    this.dataGridViewData.Rows.Add(ss.Id.ToString(), Image.FromFile(ss.Image), ss.NameBook, ss.NameReader, ss.IdentityCardReader, ss.BorrowDate.ToString("dd-MM-yyyy"), ss.DueDate.ToString("dd-MM-yyyy"));
                }
                else
                {

                    this.dataGridViewData.Rows.Add(ss.Id.ToString(),
                        Image.FromFile(System.IO.Path.Combine(this.pathApp ?? this.getDrictoryApp(), "Resources", "image", "book.png")),
                         ss.NameBook, ss.NameReader, ss.IdentityCardReader, ss.BorrowDate.ToString("dd-MM-yyyy"), ss.DueDate.ToString("dd-MM-yyyy"));
                }
            }
        }
        private void setComboboxCreatedDate()
        {
            // set  combobox ngay tao
            this.comboBoxNgayTao.Items.Clear();
            this.comboBoxNgayTao.Items.Add("Mặc định ");
            this.comboBoxNgayTao.Items.Add("Tăng dần");
            this.comboBoxNgayTao.Items.Add("Giảm dần");
            this.comboBoxNgayTao.SelectedIndex = 0;

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> constraint = new Dictionary<string, string>();
            if (this.comboBoxNgayTao.SelectedIndex != 0)
            {
                if (this.comboBoxNgayTao.SelectedIndex == 1) constraint.Add("updatedAt", "desc");
                if (this.comboBoxNgayTao.SelectedIndex == 2) constraint.Add("updatedAt", "asc");
            }
           
            if (!string.IsNullOrEmpty(this.textBoxTimkiem.Text)) constraint.Add("cmt", this.textBoxTimkiem.Text);
            this.loadData(constraint);
        }
    }
}
