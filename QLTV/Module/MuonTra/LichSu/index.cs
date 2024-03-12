using QLTV.Data.Entity;
using QLTV.Data.Model;
using QLTV.Module.MuonTra.MuonSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.Module.MuonTra.LichSu
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
        }
        public string getDrictoryApp()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string[] words = projectDirectory.Split(new char[] { '\\' });
            Array.Resize(ref words, words.Length - 4);
            return string.Join("\\", words);
        }
        private void loadData(Dictionary<string, string> constraint)
        {
            var query = from BorrowTracking in dbContext.BorrowTrackings
                        join BorrowRequest in dbContext.BorrowRequests on BorrowTracking.RequestId equals BorrowRequest.Id
                        join Reader in dbContext.Readers on BorrowRequest.ReaderId equals Reader.Id
                        join Book in dbContext.Books on BorrowRequest.BookId equals Book.Id
                        where BorrowRequest.Deleted == 0
                        where BorrowTracking.Deleted == 0
                        orderby BorrowRequest.UpdatedAt descending
                        select new { Book, BorrowRequest, Reader, BorrowTracking };


            if (constraint != null)
            {
                if (constraint.TryGetValue("cmt", out string cmt))
                    query = query.Where(data => data.Reader.IdentityCard.ToLower().Contains(cmt.ToLower()));
            }


            List<LSMuonShow> listData = query.Select(data => new LSMuonShow
            {
                Id = data.BorrowTracking.Id,
                Image = System.IO.Path.Combine(this.pathApp ?? this.getDrictoryApp(), "Resources", "image", data.Book.Image),
                NameBook = data.Book.Name,
                NameReader = data.Reader.Name,
                IdentityCardReader = data.Reader.IdentityCard ?? "Trống",
                ReturnDate = data.BorrowTracking.ReturnDate,
                UpdatedAt = data.BorrowTracking.UpdatedAt,
                Price = data.Book.Price.ToString(),
                ReturnStatus = (int)data.BorrowTracking.ReturnStatus,
                FineAmount = data.BorrowTracking.FineAmound.ToString(),
                Deleted = data.BorrowTracking.Deleted
            }).ToList();

            this.dataGridViewData.Rows.Clear();
            foreach (LSMuonShow ss in listData)
            {
                // Xác định trạng thái mượn sách
                string statusText;
                switch (ss.ReturnStatus -1)
                {
                    case 0:
                        statusText = "Bình thường";
                        break;
                    case 1:
                        statusText = "Xấu";
                        break;
                    case 2:
                        statusText = "Quá hạn";
                        break;
                    case 3:
                        statusText = "Phải bồi thường hoàn toàn";
                        break;
                    default:
                        statusText = "Trạng thái không xác định";
                        break;
                }

                // Đảm bảo rằng đường dẫn hình ảnh tồn tại trước khi thêm vào DataGridView
                if (File.Exists(ss.Image))
                {
                    this.dataGridViewData.Rows.Add(ss.Id.ToString(), "Người mượn: " + ss.NameReader + "\nCMT: " + ss.IdentityCardReader, Image.FromFile(ss.Image), "Tên:" + ss.NameBook + "\nGiá: " + ss.Price, statusText, "Ngày trả: " + ss.ReturnDate.ToString("dd-MM-yyyy") + "\nNgày phải trả: " + ss.UpdatedAt.ToString("dd-MM-yyyy"), ss.FineAmount + " Đồng");
                }
                else
                {
                    this.dataGridViewData.Rows.Add(ss.Id.ToString(), "Người mượn: " + ss.NameReader + "\nCMT: " + ss.IdentityCardReader,
                        Image.FromFile(System.IO.Path.Combine(this.pathApp ?? this.getDrictoryApp(), "Resources", "image", "book.png")),
                        "Tên:" + ss.NameBook + "\nGiá: " + ss.Price, statusText, "Ngày trả: " + ss.ReturnDate.ToString("dd-MM-yyyy") + "\nNgày phải trả: " + ss.UpdatedAt.ToString("dd-MM-yyyy"), ss.FineAmount + " Đồng");
                }
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> constraint = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(this.textBoxTimkiem.Text)) constraint.Add("cmt", this.textBoxTimkiem.Text);
            this.loadData(constraint);
        }
        private void reLoadData(object sender, EventArgs e)
        {
            this.loadData(null);
        }

        private void buttonChitiet_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewData.SelectedRows.Count > 0)
            {
                int id = int.Parse(this.dataGridViewData.SelectedRows[0].Cells[0].Value.ToString());
                detail form = new detail(id);
                form._eventAdd += this.reLoadData;
                form.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn ít nhật một đối tượng để thực hiện hành động .");
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
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
                DialogResult rs = MessageBox.Show($"Không thể xoá \n Chỉ có thể ẩn . Bạn vẫn muốn tiếp tục ẩn ", "Xác nhận xoá ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    int id = int.Parse(this.dataGridViewData.SelectedRows[0].Cells[0].Value.ToString());
                    BorrowTracking model = dbContext.BorrowTrackings.FirstOrDefault(model => model.Id == id);
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
