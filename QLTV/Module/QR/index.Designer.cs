namespace QLTV.Module.QR
{
    partial class index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            label1 = new Label();
            pictureBoxQRScan = new PictureBox();
            cboCamera = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            buttonStart = new Button();
            labelDescription = new Label();
            buttonHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRScan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(106, 104);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Camera :";
            // 
            // pictureBoxQRScan
            // 
            pictureBoxQRScan.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxQRScan.ErrorImage = (Image)resources.GetObject("pictureBoxQRScan.ErrorImage");
            pictureBoxQRScan.Image = (Image)resources.GetObject("pictureBoxQRScan.Image");
            pictureBoxQRScan.Location = new Point(92, 144);
            pictureBoxQRScan.Name = "pictureBoxQRScan";
            pictureBoxQRScan.Size = new Size(294, 278);
            pictureBoxQRScan.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxQRScan.TabIndex = 1;
            pictureBoxQRScan.TabStop = false;
            // 
            // cboCamera
            // 
            cboCamera.FormattingEnabled = true;
            cboCamera.Location = new Point(167, 101);
            cboCamera.Name = "cboCamera";
            cboCamera.Size = new Size(167, 23);
            cboCamera.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(151, 23);
            label3.Name = "label3";
            label3.Size = new Size(152, 32);
            label3.TabIndex = 6;
            label3.Text = "Quét mã QR";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(361, 101);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 7;
            buttonStart.Text = "Quét";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.ForeColor = Color.Red;
            labelDescription.Location = new Point(136, 69);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(25, 15);
            labelDescription.TabIndex = 9;
            labelDescription.Text = "......";
            // 
            // buttonHuy
            // 
            buttonHuy.BackColor = Color.Crimson;
            buttonHuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHuy.ForeColor = SystemColors.ButtonHighlight;
            buttonHuy.Location = new Point(190, 451);
            buttonHuy.Name = "buttonHuy";
            buttonHuy.Size = new Size(89, 36);
            buttonHuy.TabIndex = 11;
            buttonHuy.Text = "Huỷ";
            buttonHuy.UseVisualStyleBackColor = false;
            buttonHuy.Click += button2_Click;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 540);
            Controls.Add(buttonHuy);
            Controls.Add(labelDescription);
            Controls.Add(buttonStart);
            Controls.Add(label3);
            Controls.Add(cboCamera);
            Controls.Add(pictureBoxQRScan);
            Controls.Add(label1);
            Name = "index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "index";
            FormClosing += index_FormClosing;
            Load += index_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRScan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBoxQRScan;
        private ComboBox cboCamera;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Button buttonStart;
        private Label labelDescription;
        private Button buttonHuy;
    }
}