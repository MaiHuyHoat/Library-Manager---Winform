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

namespace QLTV.Module.MuonTra.DocGia
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
            this.setComboboxChucvu();

        }
        private void loadData(Dictionary<string, string> constraint)
        {
            var query = from reader in dbContext.Readers
                        join role in dbContext.RoleReaders on reader.RoleId equals role.Id
                        where reader.Deleted == 0
                        select new { reader, role };


            if (constraint != null)
            {
                if (constraint.TryGetValue("name", out string name))
                    query = query.Where(data => data.reader.Name.ToLower().Contains(name.ToLower()));
                //if (constraint.TryGetValue("dateofbirth", out string dateofbirth))
                //    query = query.Where(data => data.reader.DateOfBirth.ToLower().Contains(dateofbirth.ToLower()));
                if (constraint.TryGetValue("dateofbirth", out string dateofbirth))
                {
                    if (dateofbirth.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        query = query.OrderByDescending(data => data.reader.DateOfBirth);

                    if (dateofbirth.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        query = query.OrderBy(data => data.reader.DateOfBirth);
                }
                if (constraint.TryGetValue("identitycard", out string identityCard))
                    query = query.Where(data => data.reader.IdentityCard.ToLower().Contains(identityCard.ToLower()));
                if (constraint.TryGetValue("roleName", out string roleName))
                    query = query.Where(data => data.role.Name.ToLower().Contains(roleName.ToLower()));
                if (constraint.TryGetValue("startedDate", out string startedDate))
                {
                    if (startedDate.Equals("asc", StringComparison.OrdinalIgnoreCase))
                        query = query.OrderByDescending(data => data.reader.StartDay);

                    if (startedDate.Equals("desc", StringComparison.OrdinalIgnoreCase))
                        query = query.OrderBy(data => data.reader.StartDay);
                }
            }
            List<DocGiaShow> listData = query.Select(data => new DocGiaShow
            {
                Id = data.reader.Id,
                Name = data.reader.Name,
                DateOfBirth = data.reader.DateOfBirth.ToString("dd-MM-yyyy"),
                IdentityCard = data.reader.IdentityCard,
                Role = data.role.Name,
                StartDay = data.reader.StartDay.ToString("dd-MM-yyyy")
            }).ToList();

            this.dataGridViewData.Rows.Clear();
            foreach (DocGiaShow dgs in listData)
            {
                this.dataGridViewData.Rows.Add(dgs.Id.ToString(), dgs.Name, dgs.DateOfBirth, dgs.IdentityCard, dgs.Role, dgs.StartDay);
            }
        }
        private void reLoadData(object sender, EventArgs e)
        {
            this.loadData(null);
        }
        private void setComboboxChucvu()
        {
            this.comboBoxChucVu.Items.Clear();
            this.comboBoxChucVu.Items.Add("Tất cả");
            List<RoleReader> roleList = dbContext.RoleReaders.ToList();

            foreach (RoleReader role in roleList)
            {
                this.comboBoxChucVu.Items.Add(role.Name);
            }
            this.comboBoxChucVu.SelectedIndex = 0;
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> constraint = new Dictionary<string, string>();
            if (this.comboBoxChucVu.SelectedIndex != 0) constraint.Add("roleName", this.comboBoxChucVu.SelectedItem.ToString());
            if (!string.IsNullOrEmpty(this.textBoxTimkiem.Text)) constraint.Add("identitycard", this.textBoxTimkiem.Text);
            this.loadData(constraint);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            add formAdd = new add();
            formAdd._eventAdd += this.reLoadData;
            formAdd.Show();
        }

        private void buttonChiTiet_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewData.SelectedRows.Count > 0)
            {
                int id = int.Parse(this.dataGridViewData.SelectedRows[0].Cells[0].Value.ToString());
                detail formDetail = new detail(id);
                formDetail.Show();
            }
            else
            {
                MessageBox.Show("Bạn cần chọn ít nhật một đối tượng để thực hiện hành động .");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewData.SelectedRows.Count > 0)
            {
                int id = int.Parse(this.dataGridViewData.SelectedRows[0].Cells[0].Value.ToString());
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
            if (this.dataGridViewData.SelectedRows.Count > 0)
            {
                string name = this.dataGridViewData.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult rs = MessageBox.Show($"Không thể xoá \n Chỉ có thể ẩn . Bạn vẫn muốn tiếp tục ẩn độc giả có tên: \n {name}", "Xác nhận xoá ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    int id = int.Parse(this.dataGridViewData.SelectedRows[0].Cells[0].Value.ToString());
                    Reader model = dbContext.Readers.FirstOrDefault(model => model.Id == id);
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
    }
}
