using QLTV.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.Module.TaiNguyen.Sach
{
    public partial class edit : Form
    {
        private DBContext dbContext;
        private OpenFileDialog openFileDialog;
        private string filePath;
        private int idBook;
        private string destinationFolder;
        private string pathApp;
        public EventHandler _eventAdd;
        public edit(int id)
        {
            InitializeComponent();
            dbContext = new DBContext();
            this.destinationFolder = Path.Combine(this.getDrictoryApp(), "Resources", "image");
            this.setComboboxTacgia();
            this.setComboxTheLoai();
            this.setComboxNhaXuatBan();
            this.idBook = id;
            this.setExistedData();
        }
        private void setExistedData()
        {
            var query = from book in dbContext.Books
                        join category in dbContext.Categories on book.CategoryId equals category.Id
                        join author in dbContext.Authors on book.AuthorId equals author.Id
                        join publisher in dbContext.Publishers on book.PublisherId equals publisher.Id
                        where book.Id == this.idBook
                        select new { book, category, author, publisher };
            var model = query.FirstOrDefault();
            if (model != null)
            {
                textBoxTen.Text = model.book.Name;

                textBoxGia.Text = model.book.Price.ToString();

                textBoxSoLuong.Text = model.book.Amount.ToString();

                textBoxSoTrang.Text = model.book.NumberOffPages.ToString();

              
                comboBoxNhaXuatBan.SelectedItem = model.publisher.Name;

        
                comboBoxTacGia.SelectedItem = model.author.Name;

             
                comboBoxTheLoai.SelectedItem = model.category.Name;

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



            }
            else
            {
                this.Close();
            }
        }
        private void onModelEdited()
        {
            this._eventAdd?.Invoke(this, EventArgs.Empty);
        }
        private void setComboboxTacgia()
        {
            this.comboBoxTacGia.Items.Clear();
            this.comboBoxTacGia.Items.Add("Chọn tác giả ");
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
            this.comboBoxTheLoai.Items.Add("Chọn thể loại ");
            List<Category> categoryList = dbContext.Categories.ToList();

            foreach (Category category in categoryList)
            {
                this.comboBoxTheLoai.Items.Add(category.Name);
            }
            this.comboBoxTheLoai.SelectedIndex = 0;
        }
        private void setComboxNhaXuatBan()
        {
            this.comboBoxNhaXuatBan.Items.Clear();
            this.comboBoxNhaXuatBan.Items.Add("Chọn nhà xuất bản ");
            List<Publisher> list = dbContext.Publishers.ToList();

            foreach (Publisher item in list)
            {
                this.comboBoxNhaXuatBan.Items.Add(item.Name);
            }
            this.comboBoxNhaXuatBan.SelectedIndex = 0;
        }

        public string getDrictoryApp()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string[] words = projectDirectory.Split(new char[] { '\\' });
            Array.Resize(ref words, words.Length - 4);
            return string.Join("\\", words);
        }
        private async void buttonThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxTen.Text) ||
                string.IsNullOrEmpty(this.textBoxSoLuong.Text) ||
                string.IsNullOrEmpty(this.textBoxSoTrang.Text) ||

                this.comboBoxTheLoai.SelectedIndex == 0 ||
                this.comboBoxNhaXuatBan.SelectedIndex == 0 ||
                this.comboBoxTacGia.SelectedIndex == 0

                )
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin !");
            }
            else
            {


                Book model = this.dbContext.Books.FirstOrDefault(b => b.Id == this.idBook);
                model.Name = this.textBoxTen.Text;
                model.Amount = int.Parse(this.textBoxSoLuong.Text);
                model.Price = decimal.Parse(this.textBoxGia.Text);
                model.NumberOffPages = int.Parse(this.textBoxSoTrang.Text);
                model.CreateDay = this.dateTimePickerNgayTao.Value;
                model.Image = Path.GetFileName(this.filePath) ?? model.Image;
                model.PublisherId = (from Publisher in dbContext.Publishers
                                     where Publisher.Name.Equals(this.comboBoxNhaXuatBan.SelectedItem.ToString())
                                     select Publisher.Id
                                     ).FirstOrDefault();
                model.AuthorId = (from Author in dbContext.Authors
                                  where Author.Name.Equals(this.comboBoxTacGia.SelectedItem.ToString())
                                  select Author.Id
                                 ).FirstOrDefault();
                model.CategoryId = (from Category in dbContext.Categories
                                    where Category.Name.Equals(this.comboBoxTheLoai.SelectedItem.ToString())
                                    select Category.Id).FirstOrDefault();
                model.PublicationYear = this.dateTimePickerNamXuatBan.Value;
                try
                {
                    string destinationPath = Path.Combine(this.destinationFolder, model.Image);
                    if (!string.IsNullOrEmpty(this.filePath)) File.Copy(this.filePath, destinationPath, true);


                    await this.dbContext.SaveChangesAsync();
                    MessageBox.Show("Đã cập nhật sách thành công . ");
                    this.onModelEdited();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi : {ex}");
                }
            }

        }

        private void buttonThemAnh_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn tệp để tải lên";
            openFileDialog.Filter = "Tất cả các tệp ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp|JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif|Bitmap (*.bmp)|*.bmp";



            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                this.filePath = openFileDialog.FileName;
                labelFileName.Text = Path.GetFileName(this.filePath);
                Image image = Image.FromFile(this.filePath);
                pictureBoxAnh.Image = image;
                pictureBoxAnh.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
