using Microsoft.EntityFrameworkCore;
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

namespace QLTV.Module.MuonTra.LichSu
{
    public partial class edit : Form
    {
        private DBContext dbContext;
        private string pathApp;
        private int idBorrowTracking;
        private int idBook;
        private Book book;
        private int idReader;
        private Reader reader;
        private decimal money = 0;
        public EventHandler _eventAdd;
        public edit(int idBorrowTracking)
        {
            InitializeComponent();
            dbContext = new DBContext();
            this.pathApp = this.getDrictoryApp();
            this.idBorrowTracking = idBorrowTracking;
            this.loadDataBorrowTracking(this.idBorrowTracking);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string getDrictoryApp()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string[] words = projectDirectory.Split(new char[] { '\\' });
            Array.Resize(ref words, words.Length - 4);
            return string.Join("\\", words);
        }
        private void loadDataBorrowTracking(int id)
        {
            var query = from BorrowTracking in dbContext.BorrowTrackings
                        join BorrowRequest in dbContext.BorrowRequests on BorrowTracking.RequestId equals BorrowRequest.Id
                        join Reader in dbContext.Readers on BorrowRequest.ReaderId equals Reader.Id
                        join Book in dbContext.Books on BorrowRequest.BookId equals Book.Id
                        where BorrowTracking.Id == id
                        select new { BorrowTracking, Reader, BorrowRequest, Book };
            var model = query.FirstOrDefault();
            if (model != null)
            {
                this.setExistedDataSach(model.Book.Id);
                Reader reader = dbContext.Readers.FirstOrDefault(r => r.Id == model.Reader.Id);
                this.setExistedDataReader(reader.IdentityCard);
                this.dateTimePickerDueDate.Value = model.BorrowRequest.DueDate;
                this.dateTimePickerReturnDate.Value = model.BorrowTracking.ReturnDate;
                this.comboBoxTinhTrang.SelectedIndex = model.BorrowTracking.ReturnStatus.Value-1;

                this.dateTimePickerDueDate.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lỗi ! Không tim thấy thông tin mượn trả sách");
                this.Close();
            }
        }
        private void setExistedDataSach(int? idBook)
        {
            if (idBook == null)
            {
                MessageBox.Show("Lỗi ! Không tim thấy thông tin mượn  sách");
                return;
            }
            var query = from book in dbContext.Books
                        join category in dbContext.Categories on book.CategoryId equals category.Id
                        join author in dbContext.Authors on book.AuthorId equals author.Id
                        join publisher in dbContext.Publishers on book.PublisherId equals publisher.Id

                        where book.Id == idBook

                        select new { book, category, author, publisher };
            var model = query.FirstOrDefault();
            if (model != null)
            {
                this.book = model.book;
                this.idBook = model.book.Id;
                textBoxTenSach.Text = model.book.Name;

                textBoxGia.Text = model.book.Price.ToString();
                string path = System.IO.Path.Combine(this.pathApp ?? this.getDrictoryApp(), "Resources", "image", model.book.Image);
                if (!File.Exists(path))
                {
                    path = System.IO.Path.Combine(this.pathApp ?? this.getDrictoryApp(), "Resources", "image", "book.png");
                }

                Image image = Image.FromFile(path);
                pictureBoxAnh.Image = image;
                pictureBoxAnh.SizeMode = PictureBoxSizeMode.Zoom;


                textBoxGia.ReadOnly = true;
                textBoxTenSach.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin sách với mã trên !");
                textBoxTenSach.Text = null;
            }
        }
        private async void setExistedDataReader(string cmt)
        {
            var query = from reader in dbContext.Readers
                        join role in dbContext.RoleReaders on reader.RoleId equals role.Id
                        where reader.IdentityCard.Trim() == cmt
                        select new { reader, role };
            var model = query.FirstOrDefault();
            if (model != null)
            {
                this.reader = model.reader;
                this.idReader = model.reader.Id;
                textBoxCMT.Text = model.reader.IdentityCard;
                textBoxNguoiMuon.Text = model.reader.Name;

                textBoxCMT.Text = model.reader.IdentityCard.ToString();



                textBoxSoNgay.Text = model.reader.BorrowedTime.ToString();
                textBoxSoNgay2.Text = model.reader.BorrowedTime.ToString();
                textBoxSoSach.Text = model.reader.BorrowedTime.ToString();





                textBoxSoSachDaMuon.Text = await this.setBorrowedBookInMonth();


                comboBoxChucVu.Items.Add(model.role.Name); ;
                comboBoxChucVu.SelectedItem = model.role.Name;

                textBoxTenSach.ReadOnly = true;
                textBoxCMT.ReadOnly = true;

                textBoxSoNgay.ReadOnly = true;
                textBoxSoSach.ReadOnly = true;
                textBoxSoNgay2.ReadOnly = true;
                textBoxSoSachDaMuon.ReadOnly = true;
                textBoxNguoiMuon.ReadOnly = true;
                comboBoxChucVu.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin độc giả với mã trên !");
                textBoxCMT.Text = null;
            }
        }
        async public Task<string> setBorrowedBookInMonth()
        {
            var currentDate = DateTime.Now;

            // Lấy số lượng bản ghi trong bảng dbo.borrow_request
            // với điều kiện tháng và năm của cột updated_at bằng tháng và năm hiện tại
            var count = dbContext.BorrowRequests
                .Where(x => x.UpdatedAt.Month == currentDate.Month && x.UpdatedAt.Year == currentDate.Year)
                .Count();
            return count.ToString();
        }
        private void onModelEdited()
        {
            this._eventAdd?.Invoke(this, EventArgs.Empty);
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {

            BorrowTracking model = this.dbContext.BorrowTrackings.FirstOrDefault(b => b.Id == this.idBorrowTracking);
            model.ReturnDate = this.dateTimePickerReturnDate.Value;
            model.ReturnStatus = this.comboBoxTinhTrang.SelectedIndex;
            model.FineAmound = this.money;
            try
            {
                await this.dbContext.SaveChangesAsync();
                MessageBox.Show("Đã cập nhật thành công . ");
                this.onModelEdited();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi : {ex}");
            }
        }

        private void comboBoxTinhTrang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.comboBoxTinhTrang.SelectedIndex != 0)
            {
                if (this.comboBoxTinhTrang.SelectedIndex == 1) // xấu 
                {
                    this.money = (decimal)book.Price * 50 / 100;

                    this.labelMoney.Text = $"{this.money} đồng ( Tình trạng trả sách xấu : 20% giá trị quyển sách )  ";
                }
                if (this.comboBoxTinhTrang.SelectedIndex == 2) // phải bổi thường
                {
                    DateTime duaDate = this.dateTimePickerDueDate.Value;
                    DateTime returnDate = this.dateTimePickerReturnDate.Value;
                    TimeSpan interval = returnDate - duaDate;
                    int outDay = interval.Days;
                    if (outDay > 0)
                    {
                        this.money = (decimal)book.Price * outDay * 10 / 100;

                        this.labelMoney.Text = $"{this.money} đồng ( Trả sách quá hạn : {outDay} ngày  | (10% giá trị quyển sách ) * số ngày quá hạn )  ";
                    }
                    else
                    {
                        this.money = 0;
                        this.labelMoney.Text = "....(Không có )....";
                    }

                }
                if (this.comboBoxTinhTrang.SelectedIndex == 3) // phải bổi thường
                {

                    this.money = (decimal)book.Price;

                    this.labelMoney.Text = $"{this.money} đồng : Phải bồi thường (100%) giá trị quyển sách  ";
                }
            }
            else
            {
                this.money = 0;
                this.labelMoney.Text = "....(Không có )....";
            }
        }

        private void dateTimePickerReturnDate_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime duaDate = this.dateTimePickerDueDate.Value;
            DateTime returnDate = this.dateTimePickerReturnDate.Value;
            TimeSpan interval = returnDate - duaDate;
            int outDay = interval.Days;
            if (outDay > 0)
            {
                if (this.comboBoxTinhTrang.SelectedIndex != 2)
                {
                    this.comboBoxTinhTrang.SelectedIndex = 2;
                }

                this.money = (decimal)book.Price * outDay * 10 / 100;

                this.labelMoney.Text = $"{this.money} đồng ( Trả sách quá hạn : {outDay} ngày  | (10% giá trị quyển sách ) * số ngày quá hạn )  ";


            }
            else
            {
                this.money = 0;
                this.labelMoney.Text = "....(Không có )....";

            }
        }
    }
}
