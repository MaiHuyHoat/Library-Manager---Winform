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
    public partial class edit : Form
    {
        private DBContext dbContext;
        private int idPublisher;
        public EventHandler _eventAdd;
        public edit(int id)
        {
            InitializeComponent();
            dbContext = new DBContext();
            this.idPublisher = id;
            this.setExistedData();
        }
        private void setExistedData()
        {
            var query = from publisher in dbContext.Publishers
                        where publisher.Id == this.idPublisher
                        select new { publisher };
            var model = query.FirstOrDefault();
            if (model != null)
            {
                textBoxTen.Text = model.publisher.Name;
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

        private async void buttonThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxTen.Text))
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin !");
            }
            else
            {


                Publisher model = this.dbContext.Publishers.FirstOrDefault(b => b.Id == this.idPublisher);
                model.Name = this.textBoxTen.Text;
                try
                {


                    await this.dbContext.SaveChangesAsync();
                    MessageBox.Show("Đã cập nhật nhà xuất bản thành công. ");
                    this.onModelEdited();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi : {ex}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
