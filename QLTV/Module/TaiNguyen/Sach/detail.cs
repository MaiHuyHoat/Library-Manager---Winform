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

namespace QLTV.Module.TaiNguyen.Sach
{
    public partial class detail : Form
    {
        private DBContext dbContext;
        private int idBook;
        private string pathApp;
        public detail(int id)
        {
            
            InitializeComponent();
            dbContext = new DBContext();
            pathApp = this.getDrictoryApp();
            this.idBook = id;
            this.setExistedData();
        }
        public string getDrictoryApp()
        {
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string[] words = projectDirectory.Split(new char[] { '\\' });
            Array.Resize(ref words, words.Length - 4);
            return string.Join("\\", words);
        }
        private void setExistedData()
        {
            var query = from book in dbContext.Books
                        join category in dbContext.Categories on book.CategoryId equals category.Id
                        join author in dbContext.Authors on book.AuthorId equals author.Id
                        join publisher in dbContext.Publishers on book.PublisherId equals publisher.Id
                        where book.Id == this.idBook
                        select new { book, category, author,publisher };
            var model= query.FirstOrDefault();
            if (model != null) {
               textBoxTen.Text=model.book.Name;
              
                textBoxGia.Text = model.book.Price.ToString();
              
                textBoxSoLuong.Text=model.book.Amount.ToString();
               
                textBoxSoTrang.Text=model.book.NumberOffPages.ToString();

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

                textBoxSoLuong.ReadOnly = true;
                textBoxGia.ReadOnly = true;
                textBoxTen.ReadOnly = true;
                textBoxSoTrang.ReadOnly=true;
                comboBoxNhaXuatBan.Enabled = false;
                comboBoxTacGia.Enabled = false;
                comboBoxTheLoai.Enabled = false;
                dateTimePickerNamXuatBan.Enabled=false;
                dateTimePickerNgayTao.Enabled = false;

            } else
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
