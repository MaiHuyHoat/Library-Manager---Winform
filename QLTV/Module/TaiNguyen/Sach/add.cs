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

namespace QLTV.Module.TaiNguyen.Sach
{
    public partial class add : Form
    {
        private DBContext dbContext;
        private OpenFileDialog openFileDialog;
        private string filePath;
        private string destinationFolder;
        public EventHandler _eventAdd;

        public add()
        {
            InitializeComponent();
            dbContext = new DBContext();
            this.destinationFolder = Path.Combine(this.getDrictoryApp(), "Resources", "image");
            this.setComboboxTacgia();
            this.setComboxTheLoai();
            this.setComboxNhaXuatBan();
        }
        public string getDrictoryApp()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string[] words = projectDirectory.Split(new char[] { '\\' });
            Array.Resize(ref words, words.Length - 4);
            return string.Join("\\", words);
        }
        private void onModelAdded()
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
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void buttonThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxTen.Text) ||
                string.IsNullOrEmpty(this.textBoxSoLuong.Text) ||
                string.IsNullOrEmpty(this.textBoxSoTrang.Text) ||
                this.filePath == null ||
                this.comboBoxTheLoai.SelectedIndex == 0 ||
                this.comboBoxNhaXuatBan.SelectedIndex == 0 ||
                this.comboBoxTacGia.SelectedIndex == 0

                )
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin !");
            }
            else
            {


                Book model = new Book();
                model.Name = this.textBoxTen.Text;
                model.Amount = int.Parse(this.textBoxSoLuong.Text);
                model.Price = decimal.Parse(this.textBoxGia.Text);
                model.NumberOffPages = int.Parse(this.textBoxSoTrang.Text);
                model.CreateDay = this.dateTimePickerNgayTao.Value;
                model.Image = Path.GetFileName(this.filePath);
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
                    File.Copy(this.filePath, destinationPath, true);

                    this.dbContext.Add(model);
                    await this.dbContext.SaveChangesAsync();
                    MessageBox.Show("Đã thêm sách thành công . ");
                    this.onModelAdded();
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

        
    }
}
