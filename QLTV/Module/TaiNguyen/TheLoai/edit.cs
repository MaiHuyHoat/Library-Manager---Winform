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

namespace QLTV.Module.TaiNguyen.TheLoai
{
    public partial class edit : Form
    {
        private DBContext dbContext;
        private int idCategory;
        public EventHandler _eventAdd;
        public edit(int id)
        {
            InitializeComponent();
            dbContext = new DBContext();
            this.idCategory = id;
            this.setExistedData();
        }
        private void setExistedData()
        {
            var query = from category in dbContext.Categories
                        where category.Id == this.idCategory
                        select new { category };
            var model = query.FirstOrDefault();
            if (model != null)
            {
                textBoxTen.Text = model.category.Name;
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


                Category model = this.dbContext.Categories.FirstOrDefault(b => b.Id == this.idCategory);
                model.Name = this.textBoxTen.Text;
                try
                {


                    await this.dbContext.SaveChangesAsync();
                    MessageBox.Show("Đã cập nhật thể loại thành công . ");
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
