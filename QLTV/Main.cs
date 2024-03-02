using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using module_TacGia = QLTV.Module.TaiNguyen.TacGia;
using module_NhaXuatBan = QLTV.Module.TaiNguyen.NhaXuatBan;
using module_Sach = QLTV.Module.TaiNguyen.Sach;
using module_Dashboard = QLTV.Module.Dashboard;
using module_TheLoai = QLTV.Module.TaiNguyen.TheLoai;

using module_DocGia = QLTV.Module.MuonTra.DocGia;
using System.Xml.Linq;
<<<<<<< HEAD

using module_MuonSach = QLTV.Module.MuonTra.MuonSach;

=======

using module_MuonSach = QLTV.Module.MuonTra.MuonSach;
using module_TinhHinhPV = QLTV.Module.BaoCao.TinhHinhPhucVu;
>>>>>>> acc54b6c4f8b8e3d9045bc553781642549eddf54



namespace QLTV
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;


            setDefaultPanelMain();
        }

        private void setDefaultPanelMain()
        {

            if (!panelMain.Controls.Contains(module_Dashboard.index.Instance))
            {
                panelMain.Controls.Add(module_Dashboard.index.Instance);
                module_Dashboard.index.Instance.Dock = DockStyle.Fill;
                module_Dashboard.index.Instance.BringToFront();
            }
            else module_Dashboard.index.Instance.BringToFront();
        }
        private void buttonTheLoai_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(module_TheLoai.index.Instance))
            {
                panelMain.Controls.Add(module_TheLoai.index.Instance);
                module_TheLoai.index.Instance.Dock = DockStyle.Fill;
                module_TheLoai.index.Instance.BringToFront();
            }
            else module_TheLoai.index.Instance.BringToFront();
        }

        private void buttonSach_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(module_Sach.index.Instance))
            {
                panelMain.Controls.Add(module_Sach.index.Instance);
                module_Sach.index.Instance.Dock = DockStyle.Fill;
                module_Sach.index.Instance.BringToFront();
            }
            else module_Sach.index.Instance.BringToFront();
        }

        private void buttonCuaSoLamViec_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(module_Dashboard.index.Instance))
            {
                panelMain.Controls.Add(module_Dashboard.index.Instance);
                module_Dashboard.index.Instance.Dock = DockStyle.Fill;
                module_Dashboard.index.Instance.BringToFront();
            }
            else module_Dashboard.index.Instance.BringToFront();

        }

        private void buttonTacGia_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(module_TacGia.index.Instance))
            {
                panelMain.Controls.Add(module_TacGia.index.Instance);
                module_TacGia.index.Instance.Dock = DockStyle.Fill;
                module_TacGia.index.Instance.BringToFront();
            }
            else module_TacGia.index.Instance.BringToFront();
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
        private void buttonNhaXuatBan_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(module_NhaXuatBan.index.Instance))
            {
                panelMain.Controls.Add(module_NhaXuatBan.index.Instance);
                module_NhaXuatBan.index.Instance.Dock = DockStyle.Fill;
                module_NhaXuatBan.index.Instance.BringToFront();

            }
            else module_NhaXuatBan.index.Instance.BringToFront();

        }

        private void label1_Click(object sender, EventArgs e)
        {

=======
>>>>>>> acc54b6c4f8b8e3d9045bc553781642549eddf54

        private void buttonDocGia_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(module_DocGia.index.Instance))
            {
                panelMain.Controls.Add(module_DocGia.index.Instance);
                module_DocGia.index.Instance.Dock = DockStyle.Fill;
                module_DocGia.index.Instance.BringToFront();
            }
            else module_DocGia.index.Instance.BringToFront();
        }

        private void buttonMuonSach_Click(object sender, EventArgs e)
        {

            if (!panelMain.Controls.Contains(module_MuonSach.index.Instance))
            {
                panelMain.Controls.Add(module_MuonSach.index.Instance);
                module_MuonSach.index.Instance.Dock = DockStyle.Fill;
                module_MuonSach.index.Instance.BringToFront();
            }
            else module_MuonSach.index.Instance.BringToFront();
<<<<<<< HEAD

=======
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(module_TinhHinhPV.index.Instance))
            {
                panelMain.Controls.Add(module_TinhHinhPV.index.Instance);
                module_TinhHinhPV.index.Instance.Dock = DockStyle.Fill;
                module_TinhHinhPV.index.Instance.BringToFront();
            }
            else module_TinhHinhPV.index.Instance.BringToFront();
>>>>>>> 6a86b6b2eeec0450416422be297075061c3f76a4
>>>>>>> acc54b6c4f8b8e3d9045bc553781642549eddf54
        }
    }
}
