using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

//import module
using module_TacGia = QLTV.Module.TaiNguyen.TacGia;
using module_NhaXuatBan = QLTV.Module.TaiNguyen.NhaXuatBan;
using module_Sach = QLTV.Module.TaiNguyen.Sach;
using module_Dashboard = QLTV.Module.Dashboard;
using module_TheLoai = QLTV.Module.TaiNguyen.TheLoai;

using module_DocGia = QLTV.Module.MuonTra.DocGia;
using module_MuonSach = QLTV.Module.MuonTra.MuonSach;
using module_TinhHinhPV = QLTV.Module.BaoCao.TinhHinhPhucVu;

using module_LSMuonTra = QLTV.Module.MuonTra.LichSu;

using module_Login = QLTV.Module.Login;

using module_SachItSudung = QLTV.Module.BaoCao.SachItSuDung;
using module_DocGiaHetHan = QLTV.Module.BaoCao.DocGiaHetHan;




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

        }

        private void buttonLSMuon_Tra_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(module_LSMuonTra.index.Instance))
            {
                panelMain.Controls.Add(module_LSMuonTra.index.Instance);
                module_LSMuonTra.index.Instance.Dock = DockStyle.Fill;
                module_LSMuonTra.index.Instance.BringToFront();
            }
            else module_LSMuonTra.index.Instance.BringToFront();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            module_Login.index form = new module_Login.index();
            form.Show();
            this.Close();

        }

        private void buttonSachItSuDung_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(module_SachItSudung.index.Instance))
            {
                panelMain.Controls.Add(module_SachItSudung.index.Instance);
                module_SachItSudung.index.Instance.Dock = DockStyle.Fill;
                module_SachItSudung.index.Instance.BringToFront();
            }
            else module_SachItSudung.index.Instance.BringToFront();
        }

        private void buttonDocGiaHetHan_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(module_DocGiaHetHan.index.Instance))
            {
                panelMain.Controls.Add(module_DocGiaHetHan.index.Instance);
                module_DocGiaHetHan.index.Instance.Dock = DockStyle.Fill;
                module_DocGiaHetHan.index.Instance.BringToFront();
            }
            else module_DocGiaHetHan.index.Instance.BringToFront();
        }
    }
}

