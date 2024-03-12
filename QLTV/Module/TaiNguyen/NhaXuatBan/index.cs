using QLTV.Data.Entity;
using QLTV.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.Module.TaiNguyen.NhaXuatBan
{
    public partial class index : UserControl
    {
        private DBContext dbContext;
        private static index _instance;
        public static index Instance
        {
            get
            {
                if (_instance == null) _instance = new index();
                return _instance;
            }
        }
        public index()
        {
            InitializeComponent();
            dbContext = new DBContext();
            this.loadData(null);
        }
        private void loadData(Dictionary<string, string> constraint)
        {
            var query = from publisher in dbContext.Publishers
                        where publisher.Deleted == 0
                        select new { publisher };


            if (constraint != null)
            {
                if (constraint.TryGetValue("name", out string name))
                    query = query.Where(data => data.publisher.Name.ToLower().Contains(name.ToLower()));
            }


            List<NhaXuatBanShow> listData = query.Select(data => new NhaXuatBanShow
            {
                Id = data.publisher.Id,
                Name = data.publisher.Name
            }).ToList();

            this.dgvNhaXuatBan.Rows.Clear();
            foreach (NhaXuatBanShow tgs in listData)
            {
                this.dgvNhaXuatBan.Rows.Add(tgs.Id.ToString(), tgs.Name);
            }
        }
        private void reLoadData(object sender, EventArgs e)
        {
            this.loadData(null);
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.dgvNhaXuatBan.SelectedRows.Count > 0)
            {
                int id = int.Parse(this.dgvNhaXuatBan.SelectedRows[0].Cells[0].Value.ToString());
                edit form = new edit(id);
                form._eventAdd += this.reLoadData;
                form.Show();

            }

            else
            {
                MessageBox.Show("Bạn cần chọn ít nhật một đối tượng để thực hiện hành động .");
            }
        }

        private void buttonThem_Click_1(object sender, EventArgs e)
        {
            add formAdd = new add();
            formAdd._eventAdd += this.reLoadData;
            formAdd.Show();
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            if (this.dgvNhaXuatBan.SelectedRows.Count > 0)
            {
                int id = int.Parse(this.dgvNhaXuatBan.SelectedRows[0].Cells[0].Value.ToString());
                edit form = new edit(id);
                form._eventAdd += this.reLoadData;
                form.Show();

            }

            else
            {
                MessageBox.Show("Bạn cần chọn ít nhật một đối tượng để thực hiện hành động .");
            }
        }

        private async void buttonXoa_Click(object sender, EventArgs e)
        {
            if (this.dgvNhaXuatBan.SelectedRows.Count > 0)
            {
                string name = this.dgvNhaXuatBan.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult rs = MessageBox.Show($"Không thể xoá \n Chỉ có thể ẩn . Bạn vẫn muốn tiếp tục ẩn sách có tên: \n {name}", "Xác nhận xoá ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    int id = int.Parse(this.dgvNhaXuatBan.SelectedRows[0].Cells[0].Value.ToString());
                    Publisher model = dbContext.Publishers.FirstOrDefault(model => model.Id == id);
                    model.Deleted = 1;
                    await dbContext.SaveChangesAsync();
                    this.loadData(null);
                }

            }
            else
            {
                MessageBox.Show("Bạn cần chọn ít nhật một đối tượng để thực hiện hành động .");
            }
        }

        private void dgvNhaXuatBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> constraint = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(this.textBoxTimkiem.Text)) constraint.Add("name", this.textBoxTimkiem.Text);
            this.loadData(constraint);
        }
    }
}
