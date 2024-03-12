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
using Main = QLTV.Main;
namespace QLTV.Module.Login
{
    public partial class index : Form
    {
        private DBContext dBContext;
        public index()
        {
            InitializeComponent();
            dBContext = new DBContext();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxUserName.Text) ||
                string.IsNullOrEmpty(this.textBoxPassword.Text)
                )
            {


                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được trống ! ");
            }
            else
            {
                string userName = this.textBoxUserName.Text;
                string password = this.textBoxPassword.Text;
                var query = await dBContext.Users.FirstOrDefaultAsync(u => u.Username == userName && u.Password == password);
                if (query!=null)
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng! ");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBoxUserName_GotFocus(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "Tên đăng nhập")
            {
                textBoxUserName.Text = "";
                textBoxUserName.ForeColor = SystemColors.WindowText; // Đặt màu chữ về màu mặc định
            }
        }
        private void textBoxUserName_LostGotFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserName.Text) || textBoxUserName.Text == "Tên đăng nhập")
            {
                textBoxUserName.Text = "Tên đăng nhập";
                textBoxUserName.ForeColor = Color.Gray; // Đặt màu chữ thành màu xám
            }
        }
        private void textBoxPassword_GotFocus(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Mật khẩu")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = SystemColors.WindowText; // Đặt màu chữ về màu mặc định
            }
        }

        private void textBoxPassword_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text) || textBoxPassword.Text == "Mật khẩu")
            {
                textBoxPassword.Text = "Mật khẩu";
                textBoxPassword.ForeColor = Color.Gray; // Đặt màu chữ thành màu xám
            }
        }

     
    }
}
