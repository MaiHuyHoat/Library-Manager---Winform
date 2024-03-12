using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.Data.Model;

namespace QLTV.Module.MuonTra.DocGia
{
    public partial class add : Form
    {
        private DBContext dbContext;
        public EventHandler _eventAdd;
        public add()
        {
            InitializeComponent();
            dbContext = new DBContext();
            this.setComboboxChucvu();
        }
        private void onModelAdded()
        {
            this._eventAdd?.Invoke(this, EventArgs.Empty);
        }
        private void setComboboxChucvu()
        {
            this.comboBoxChucVu.Items.Clear();
            this.comboBoxChucVu.Items.Add("Chọn chức vụ ");
            List<RoleReader> roleList = dbContext.RoleReaders.ToList();

            foreach (RoleReader role in roleList)
            {
                this.comboBoxChucVu.Items.Add(role.Name);
            }
            this.comboBoxChucVu.SelectedIndex = 0;
        }

        private async void buttonThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBoxTen.Text) ||
                string.IsNullOrEmpty(this.textBoxDiaChi.Text) ||
                string.IsNullOrEmpty(this.textBoxCMT.Text) ||
                string.IsNullOrEmpty(this.textBoxTienCoc.Text) ||
                string.IsNullOrEmpty(this.textBoxSoSach.Text) ||
                string.IsNullOrEmpty(this.textBoxSoNgay.Text) ||
                this.comboBoxChucVu.SelectedIndex == 0)
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin !");
            }
            else
            {
                Reader model = new Reader();
                model.Name = this.textBoxTen.Text;
                model.ReaderAddress = this.textBoxDiaChi.Text;
                model.IdentityCard = this.textBoxCMT.Text;
                model.Deposit = decimal.Parse(this.textBoxTienCoc.Text);
                model.DateOfBirth = this.dateTimePickerNgaySinh.Value;
                model.BooksBorrowed = int.Parse(this.textBoxSoSach.Text);
                model.BorrowedTime = int.Parse(this.textBoxSoNgay.Text);
                model.StartDay = this.dateTimePickerNgayTao.Value;
                model.EndDay = this.dateTimePickerNgayHetHan.Value;
                model.RoleId = (from RoleReader in dbContext.RoleReaders
                                     where RoleReader.Name.Equals(this.comboBoxChucVu.SelectedItem.ToString())
                                     select RoleReader.Id).FirstOrDefault();
                try
                {
                    var query = dbContext.Readers.FirstOrDefault(r=>r.IdentityCard==model.IdentityCard);
                    if (query != null)
                    {
                        MessageBox.Show($"Đã tồn tại thông tin độc giả với chứng minh thư : {model.IdentityCard} trong thư viện !");
                        return;
                    }
                    this.dbContext.Add(model);
                    await this.dbContext.SaveChangesAsync();
                    MessageBox.Show("Đã thêm độc giả thành công . ");
                    this.onModelAdded();
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

        private void textBoxCMT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
