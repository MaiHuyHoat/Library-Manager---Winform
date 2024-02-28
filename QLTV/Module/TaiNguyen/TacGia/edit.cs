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

namespace QLTV.Module.TaiNguyen.TacGia
{
    public partial class edit : Form
    {
        private DBContext dbContext;
        private int idAuthor;
        public EventHandler _eventAdd;
        public edit(int id)
        {
            InitializeComponent();
            dbContext = new DBContext();
            this.idAuthor = id;
            this.setExistedData();
        }
        private void setExistedData()
        {
            var query = from author in dbContext.Authors
                        where author.Id == this.idAuthor
                        select new { author };
            var model = query.FirstOrDefault();
            if (model != null)
            {
                textBoxTen.Text = model.author.Name;
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


                Author model = this.dbContext.Authors.FirstOrDefault(b => b.Id == this.idAuthor);
                model.Name = this.textBoxTen.Text;
                try
                {
                   

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
