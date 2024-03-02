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

namespace QLTV.Module.TaiNguyen.NhaXuatBan
{
    public partial class add : Form
    {
        private DBContext dbContext;
        public EventHandler _eventAdd;
        public add()
        {
            InitializeComponent();
            dbContext = new DBContext();
        }
        private void onModelAdded()
        {
            this._eventAdd?.Invoke(this, EventArgs.Empty);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxTen.Text))
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin !");
            }
            else
            {
                Publisher model = new Publisher();
                model.Name = this.textBoxTen.Text;

                try
                {
                    this.dbContext.Add(model);
                    await this.dbContext.SaveChangesAsync();
                    MessageBox.Show("Đã thêm nhà xuất bản thành công.");
                    this.onModelAdded();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
        }
    }
}
