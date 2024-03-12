using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using AForge.Video;
using AForge.Video.DirectShow;
using QLTV.Data.Model;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace QLTV.Module.QR
{
    public partial class index : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public EventHandler _eventAdd;
        public static string textScan;
        private int buocScan;
        private void onModelAdded()
        {
            this._eventAdd?.Invoke(this, EventArgs.Empty);
        }
        public static void setTextScanNull()
        {
            textScan = "";
        }
        public index(int buoc)
        {
            InitializeComponent();
            this.buocScan = buoc;
            if (buoc == 1)
            {
                this.labelDescription.Text = "Bước 1: Lấy thông tin sách";
            }
            else if (buoc == 2)
            {
                this.labelDescription.Text = "Bước 2 Lấy thông độc giả";
            

            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += FinalFrame_NewFrame;

            videoCaptureDevice.Start();
            timer1.Start();
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxQRScan.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void index_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cboCamera.Items.Add(Device.Name);
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();

        }

        private void index_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBoxQRScan.Image != null)
            {
                ZXing.Windows.Compatibility.BarcodeReader Reader = new ZXing.Windows.Compatibility.BarcodeReader();
                Result result = Reader.Decode((Bitmap)pictureBoxQRScan.Image);
                if (result != null)
                {

                    if (buocScan == 1)
                    {
                        textScan = result.ToString();
                    }
                    else if (buocScan == 2)
                    {
                        textScan = getCMT(result.ToString());

                    }
                    //textBoxResult.Text = textScan;

                    this.onModelAdded();
                    this.Close();

                }


            }

        }
        private string getCMT(string str)
        {
            string[] words = str.Split(new char[] { '|' });
            return words[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void buttonBuocTiep_Click(object sender, EventArgs e)
        {
            this.onModelAdded();
            this.Close();
        }




        // Phương thức chuyển đổi hình ảnh sang mảng byte
        // Phương thức chuyển đổi hình ảnh sang mảng byte

    }
}
