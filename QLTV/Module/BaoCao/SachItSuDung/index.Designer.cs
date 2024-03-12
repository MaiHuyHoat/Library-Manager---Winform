namespace QLTV.Module.BaoCao.SachItSuDung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            dataGridViewData = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnTenSach = new DataGridViewImageColumn();
            ColumnTen = new DataGridViewTextBoxColumn();
            ColumnTheLoai = new DataGridViewTextBoxColumn();
            ColumnTacGia = new DataGridViewTextBoxColumn();
            ColumnSoLuongPhucVu = new DataGridViewTextBoxColumn();
            buttonTimKiem = new Button();
            textBoxTimkiem = new TextBox();
            label5 = new Label();
            comboBoxTacGia = new ComboBox();
            label4 = new Label();
            comboBoxTheLoai = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            buttonExport = new Button();
            comboBoxSetLoaiSachItSuDung = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBoxSetLoaiSachItDuocSuDung = new TextBox();
            buttonCaiDat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewData
            // 
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnTenSach, ColumnTen, ColumnTheLoai, ColumnTacGia, ColumnSoLuongPhucVu });
            dataGridViewData.Location = new Point(6, 144);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewData.RowTemplate.Height = 65;
            dataGridViewData.Size = new Size(1075, 500);
            dataGridViewData.TabIndex = 30;
            // 
            // ColumnId
            // 
            ColumnId.DataPropertyName = "id";
            ColumnId.FillWeight = 46.5289536F;
            ColumnId.HeaderText = "Id";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            // 
            // ColumnTenSach
            // 
            ColumnTenSach.DataPropertyName = "image";
            ColumnTenSach.HeaderText = "Ảnh";
            ColumnTenSach.Image = (Image)resources.GetObject("ColumnTenSach.Image");
            ColumnTenSach.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ColumnTenSach.MinimumWidth = 6;
            ColumnTenSach.Name = "ColumnTenSach";
            ColumnTenSach.Resizable = DataGridViewTriState.True;
            ColumnTenSach.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnTen
            // 
            ColumnTen.FillWeight = 85.04722F;
            ColumnTen.HeaderText = "Tên";
            ColumnTen.MinimumWidth = 6;
            ColumnTen.Name = "ColumnTen";
            // 
            // ColumnTheLoai
            // 
            ColumnTheLoai.FillWeight = 85.04722F;
            ColumnTheLoai.HeaderText = "Thể loại";
            ColumnTheLoai.MinimumWidth = 6;
            ColumnTheLoai.Name = "ColumnTheLoai";
            // 
            // ColumnTacGia
            // 
            ColumnTacGia.FillWeight = 68.03777F;
            ColumnTacGia.HeaderText = "Tác giả";
            ColumnTacGia.MinimumWidth = 6;
            ColumnTacGia.Name = "ColumnTacGia";
            // 
            // ColumnSoLuongPhucVu
            // 
            ColumnSoLuongPhucVu.FillWeight = 59.53306F;
            ColumnSoLuongPhucVu.HeaderText = "Số lượng đã phục vụ";
            ColumnSoLuongPhucVu.MinimumWidth = 6;
            ColumnSoLuongPhucVu.Name = "ColumnSoLuongPhucVu";
            // 
            // buttonTimKiem
            // 
            buttonTimKiem.BackColor = SystemColors.MenuHighlight;
            buttonTimKiem.FlatAppearance.BorderSize = 0;
            buttonTimKiem.FlatStyle = FlatStyle.Flat;
            buttonTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTimKiem.ForeColor = SystemColors.ButtonFace;
            buttonTimKiem.Image = (Image)resources.GetObject("buttonTimKiem.Image");
            buttonTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTimKiem.Location = new Point(742, 81);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(131, 30);
            buttonTimKiem.TabIndex = 29;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = false;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // textBoxTimkiem
            // 
            textBoxTimkiem.Location = new Point(557, 86);
            textBoxTimkiem.Name = "textBoxTimkiem";
            textBoxTimkiem.Size = new Size(163, 23);
            textBoxTimkiem.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(462, 88);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 23;
            label5.Text = "Tìm kiếm :";
            // 
            // comboBoxTacGia
            // 
            comboBoxTacGia.FormattingEnabled = true;
            comboBoxTacGia.Location = new Point(95, 88);
            comboBoxTacGia.Name = "comboBoxTacGia";
            comboBoxTacGia.Size = new Size(121, 23);
            comboBoxTacGia.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 90);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 21;
            label4.Text = "Tác giả :";
            // 
            // comboBoxTheLoai
            // 
            comboBoxTheLoai.FormattingEnabled = true;
            comboBoxTheLoai.Location = new Point(317, 86);
            comboBoxTheLoai.Name = "comboBoxTheLoai";
            comboBoxTheLoai.Size = new Size(121, 23);
            comboBoxTheLoai.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(232, 88);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 19;
            label3.Text = "Thể loại :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(389, 30);
            label1.TabIndex = 0;
            label1.Text = "Sách ít sử dụng ( Trong vòng 6 tháng)";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 83, 102);
            panel1.Controls.Add(buttonExport);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1221, 58);
            panel1.TabIndex = 16;
            // 
            // buttonExport
            // 
            buttonExport.BackColor = Color.FromArgb(40, 167, 69);
            buttonExport.FlatAppearance.BorderSize = 0;
            buttonExport.FlatStyle = FlatStyle.Flat;
            buttonExport.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExport.ForeColor = SystemColors.ButtonHighlight;
            buttonExport.Image = (Image)resources.GetObject("buttonExport.Image");
            buttonExport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExport.Location = new Point(1028, 10);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(99, 39);
            buttonExport.TabIndex = 32;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = false;
            buttonExport.Click += buttonExport_Click;
            // 
            // comboBoxSetLoaiSachItSuDung
            // 
            comboBoxSetLoaiSachItSuDung.FormattingEnabled = true;
            comboBoxSetLoaiSachItSuDung.Items.AddRange(new object[] { "Mặc định ( <=5)", "<=10", "<=15", "<=20" });
            comboBoxSetLoaiSachItSuDung.Location = new Point(1093, 278);
            comboBoxSetLoaiSachItSuDung.Name = "comboBoxSetLoaiSachItSuDung";
            comboBoxSetLoaiSachItSuDung.Size = new Size(121, 23);
            comboBoxSetLoaiSachItSuDung.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1089, 144);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 32;
            label6.Text = "Cài đặt ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1093, 185);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 33;
            label7.Text = "Số lượng phục vụ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1087, 200);
            label8.Name = "label8";
            label8.Size = new Size(125, 15);
            label8.TabIndex = 34;
            label8.Text = " của quyển sách được ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1093, 215);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 35;
            label9.Text = "coi là ít:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(1093, 260);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 36;
            label10.Text = "Chọn :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 37;
            label11.Text = "label11";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(1096, 319);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 38;
            label12.Text = "Nhập :";
            // 
            // textBoxSetLoaiSachItDuocSuDung
            // 
            textBoxSetLoaiSachItDuocSuDung.Location = new Point(1096, 349);
            textBoxSetLoaiSachItDuocSuDung.Name = "textBoxSetLoaiSachItDuocSuDung";
            textBoxSetLoaiSachItDuocSuDung.Size = new Size(118, 23);
            textBoxSetLoaiSachItDuocSuDung.TabIndex = 39;
            // 
            // buttonCaiDat
            // 
            buttonCaiDat.Location = new Point(1101, 401);
            buttonCaiDat.Name = "buttonCaiDat";
            buttonCaiDat.Size = new Size(75, 23);
            buttonCaiDat.TabIndex = 40;
            buttonCaiDat.Text = "Cài đặt";
            buttonCaiDat.UseVisualStyleBackColor = true;
            buttonCaiDat.Click += buttonCaiDat_Click;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonCaiDat);
            Controls.Add(textBoxSetLoaiSachItDuocSuDung);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBoxSetLoaiSachItSuDung);
            Controls.Add(dataGridViewData);
            Controls.Add(buttonTimKiem);
            Controls.Add(textBoxTimkiem);
            Controls.Add(label5);
            Controls.Add(comboBoxTacGia);
            Controls.Add(label4);
            Controls.Add(comboBoxTheLoai);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "index";
            Size = new Size(1221, 650);
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewData;
        private Button buttonTimKiem;
        private TextBox textBoxTimkiem;
        private Label label5;
        private ComboBox comboBoxTacGia;
        private Label label4;
        private ComboBox comboBoxTheLoai;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Button buttonExport;
        private ComboBox comboBoxSetLoaiSachItSuDung;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBoxSetLoaiSachItDuocSuDung;
        private Button buttonCaiDat;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewImageColumn ColumnTenSach;
        private DataGridViewTextBoxColumn ColumnTen;
        private DataGridViewTextBoxColumn ColumnTheLoai;
        private DataGridViewTextBoxColumn ColumnTacGia;
        private DataGridViewTextBoxColumn ColumnSoLuongPhucVu;
    }
}
