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
using module_QR = QLTV.Module.QR;
namespace QLTV.Module.MuonTra.MuonSach
{
    public partial class edit : Form
    {
        private DBContext dbContext;

        private string pathApp;
        private int idBorowRequest;
        private int idBook;
        private Book book;
        private int idReader;
        private Reader reader;
        private decimal money = 0;
        public EventHandler _eventAdd;
        public edit(int idBorowRequest)
        {
            InitializeComponent();
            dbContext = new DBContext();
            this.pathApp = this.getDrictoryApp();
            this.idBorowRequest = idBorowRequest;
            this.loadDataBorrowRequest(this.idBorowRequest);
            this.textBoxCMT.ReadOnly = false;
            this.textBoxMaSach.ReadOnly = false;
        }


        public string getDrictoryApp()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string[] words = projectDirectory.Split(new char[] { '\\' });
            Array.Resize(ref words, words.Length - 4);
            return string.Join("\\", words);
        }
        private void loadDataBorrowRequest(int id)
        {
            var query = from BorrowRequest in dbContext.BorrowRequests
                        join Reader in dbContext.Readers on BorrowRequest.ReaderId equals Reader.Id
                        join Book in dbContext.Books on BorrowRequest.BookId equals Book.Id
                        where BorrowRequest.Id == id
                        select new { Reader, BorrowRequest, Book };
            var model = query.FirstOrDefault();
            if (model != null)
            {
                this.setExistedDataSach(model.Book.Id);
                Reader reader = dbContext.Readers.FirstOrDefault(r => r.Id == model.Reader.Id);
                this.setExistedDataReader(reader.IdentityCard);
                this.dateTimePickerDueDate.Value = model.BorrowRequest.DueDate;
            }
            else
            {
                MessageBox.Show("Lỗi ! Không tim thấy thông tin mượn trả sách");
                this.Close();
            }
        }
        private void onModelAdded()
        {
            this._eventAdd?.Invoke(this, EventArgs.Empty);
        }
        private void LoadDataSach(object sender, EventArgs e)
        {
            module_QR.index formQR;
            try
            {
                int maSach = int.Parse(module_QR.index.textScan);
                this.setExistedDataSach(maSach);
                formQR = new module_QR.index(2);
                formQR._eventAdd += this.LoadDataDocGia;

                formQR.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi! Không nhận dạng được mã QR của sách \n Vui lòng quét lại . ");
                formQR = new module_QR.index(1);
                formQR._eventAdd += this.LoadDataSach;

                formQR.Show();

            }


        }
        private void LoadDataDocGia(object sender, EventArgs e)
        {
            module_QR.index formQR;
            try
            {
                string cmt = module_QR.index.textScan.Trim();
                this.setExistedDataReader(cmt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi! Không nhận dạng được mã QR của độc giả \n Vui lòng quét lại . ");
                formQR = new module_QR.index(2);
                formQR._eventAdd += this.LoadDataSach;

                formQR.Show();
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
                this.textBoxMaSach.Text = model.book.Id.ToString();
                textBoxTenSach.Text = model.book.Name;

                textBoxGia.Text = model.book.Price.ToString();



                comboBoxNhaXuatBan.Items.Add(model.publisher.Name);
                comboBoxNhaXuatBan.SelectedItem = model.publisher.Name;

                comboBoxTacGia.Items.Add(model.author.Name);
                comboBoxTacGia.SelectedIndex = 0;

                comboBoxTheLoai.Items.Add(model.category.Name);
                comboBoxTheLoai.SelectedIndex = 0;

                dateTimePickerNgayTao.Value = model.book.CreateDay;

                dateTimePickerNamXuatBan.Value = model.book.PublicationYear;

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

                comboBoxNhaXuatBan.Enabled = false;
                comboBoxTacGia.Enabled = false;
                comboBoxTheLoai.Enabled = false;
                dateTimePickerNamXuatBan.Enabled = false;
                dateTimePickerNgayTao.Enabled = false;

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin sách với mã trên !");
                textBoxMaSach.Text = null;
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
                textBoxTenDocGia.Text = model.reader.Name;

                textBoxCMT.Text = model.reader.IdentityCard.ToString();



                textBoxSoNgay.Text = model.reader.BorrowedTime.ToString();
                textBoxSoNgay2.Text = model.reader.BorrowedTime.ToString();
                textBoxSoSach.Text = model.reader.BorrowedTime.ToString();





                textBoxSoSachDaMuon.Text = await this.setBorrowedBookInMonth();


                comboBoxChucVu.Items.Add(model.role.Name); ;
                comboBoxChucVu.SelectedItem = model.role.Name;



                dateTimePickerNgayTao.Value = model.reader.StartDay;
                dateTimePickerNgayHetHan.Value = model.reader.EndDay;

                textBoxTenSach.ReadOnly = true;
                textBoxCMT.ReadOnly = true;

                textBoxSoNgay.ReadOnly = true;
                textBoxSoSach.ReadOnly = true;
                textBoxSoNgay2.ReadOnly = true;
                textBoxSoSachDaMuon.ReadOnly = true;
                textBoxTenDocGia.ReadOnly = true;


                comboBoxChucVu.Enabled = false;
                dateTimePickerNgayHetHan.Enabled = false;

                dateTimePickerNgayTao.Enabled = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTraDocGia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaSach.Text))
            {
                MessageBox.Show("Mã độc giả tra không được trống !");
            }
            else
            {
                string cmt = textBoxCMT.Text.Trim();
                this.setExistedDataReader(cmt);
            }
            if (string.IsNullOrEmpty(textBoxMaSach.Text))
            {
                MessageBox.Show("Mã sách tra không được trống !");
            }
            else
            {
                int maSach = int.Parse(textBoxMaSach.Text);
                this.setExistedDataSach(maSach);
            }
        }

        private void buttonQR_Click(object sender, EventArgs e)
        {
            module_QR.index formQR = new module_QR.index(1);
            formQR._eventAdd += this.LoadDataSach;

            formQR.Show();
        }

        private async void buttonThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaSach.Text) ||
              string.IsNullOrEmpty(textBoxCMT.Text) ||
              string.IsNullOrEmpty(textBoxTenSach.Text) ||
              string.IsNullOrEmpty(textBoxTenDocGia.Text)
              )
            {
                MessageBox.Show("Không được thiếu thông tin độc giả vả thông tin sách");
                return;
            }
            if (int.Parse(textBoxSoSachDaMuon.Text) >= int.Parse(textBoxSoSach.Text))
            {
                MessageBox.Show("Độc giả đã mượn sách quá số lần quy định !");
                return;
            }
            BorrowRequest br = dbContext.BorrowRequests.FirstOrDefault(br=>br.Id==this.idBorowRequest);
            br.UpdatedAt = DateTime.Now;
            br.DueDate = this.dateTimePickerDueDate.Value;
            br.ReaderId = this.idReader;
            br.BookId = this.idBook;
            br.Status = 0;
            br.Deleted = 0;
            await dbContext.SaveChangesAsync();
            MessageBox.Show("Đã sửa thông tin mượn sách thành công !");
            this.onModelAdded();
            this.Close();
        }
    }
}
