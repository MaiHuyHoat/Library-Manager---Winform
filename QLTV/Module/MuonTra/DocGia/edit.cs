using QLTV.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.Module.MuonTra.DocGia
{
    public partial class edit : Form
    {
        private DBContext dbContext;
        private int idReader;
        public EventHandler _eventAdd;
        public edit(int id)
        {
            InitializeComponent();
            dbContext = new DBContext();
            this.idReader = id;
            this.setComboxChucVu();
            this.setExistedData();
        }
        private void setExistedData()
        {
            var query = from reader in dbContext.Readers
                        join role in dbContext.RoleReaders on reader.RoleId equals role.Id
                        where reader.Id == this.idReader
                        select new { reader, role };
            var model = query.FirstOrDefault();
            if (model != null)
            {
                textBoxTen.Text = model.reader.Name;

                textBoxCMT.Text = model.reader.IdentityCard.ToString();

                textBoxDiaChi.Text = model.reader.ReaderAddress;

                textBoxSoSach.Text = model.reader.BooksBorrowed.ToString();

                textBoxSoNgay.Text = model.reader.BorrowedTime.ToString();
                textBoxTienCoc.Text = model.reader.Deposit.ToString();

                comboBoxChucVu.SelectedItem = model.role.Name;

                dateTimePickerNgaySinh.Value = model.reader.DateOfBirth;

                dateTimePickerNgayTao.Value = model.reader.StartDay;
                dateTimePickerNgayHetHan.Value = model.reader.EndDay;

            }
            else
            {
                this.Close();
            }
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
                Reader model = this.dbContext.Readers.FirstOrDefault(b => b.Id == this.idReader);
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
                                select RoleReader.Id).FirstOrDefault(); try
                {
                    await this.dbContext.SaveChangesAsync();
                    MessageBox.Show("Đã cập nhật độc giả thành công . ");
                    this.onModelEdited();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi : {ex}");
                }
            }
        }
        private void setComboxChucVu()
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void onModelEdited()
        {
            this._eventAdd?.Invoke(this, EventArgs.Empty);
        }
    }
}
