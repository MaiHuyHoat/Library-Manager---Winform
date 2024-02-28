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

namespace QLTV.Module.MuonTra.DocGia
{
    public partial class detail : Form
    {
        private DBContext dbContext;
        private int idReader;
        public detail(int id)
        {
            InitializeComponent();
            dbContext = new DBContext();
            this.idReader = id;
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

                textBoxDiaChi.Text = model.reader.ReaderAddress.ToString();

                textBoxSoNgay.Text = model.reader.BorrowedTime.ToString();
                textBoxSoSach.Text = model.reader.BooksBorrowed.ToString();
                textBoxTienCoc.Text = model.reader.Deposit.ToString();

                comboBoxChucVu.Items.Add(model.role.Name); ;
                comboBoxChucVu.SelectedItem = model.role.Name;

                dateTimePickerNgaySinh.Value = model.reader.DateOfBirth;

                dateTimePickerNgayTao.Value = model.reader.StartDay;
                dateTimePickerNgayHetHan.Value = model.reader.EndDay;

                textBoxTen.ReadOnly = true;
                textBoxCMT.ReadOnly = true;
                textBoxDiaChi.ReadOnly = true;
                textBoxSoNgay.ReadOnly = true;
                textBoxSoSach.ReadOnly = true;
                textBoxTienCoc.ReadOnly = true;

                comboBoxChucVu.Enabled = false;
                dateTimePickerNgayHetHan.Enabled = false;
                dateTimePickerNgaySinh.Enabled = false;
                dateTimePickerNgayTao.Enabled = false;
            }
            else
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
