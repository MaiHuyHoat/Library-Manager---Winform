namespace QLTV.Module.BaoCao.DocGiaHetHan
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
            label5 = new Label();
            label1 = new Label();
            dataGridViewData = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnTen = new DataGridViewTextBoxColumn();
            ColumnNgaySinh = new DataGridViewTextBoxColumn();
            ColumnCMT = new DataGridViewTextBoxColumn();
            ColumnChucVu = new DataGridViewTextBoxColumn();
            ColumnNgayCapThe = new DataGridViewTextBoxColumn();
            ColumnNgayHetHan = new DataGridViewTextBoxColumn();
            ColumnSoSachDaMuon = new DataGridViewTextBoxColumn();
            ColumnSoSachDaTra = new DataGridViewTextBoxColumn();
            ColumnSoSachChuaTra = new DataGridViewTextBoxColumn();
            buttonTimKiem = new Button();
            buttonXoa = new Button();
            buttonChiTiet = new Button();
            buttonThem = new Button();
            textBoxTimkiem = new TextBox();
            comboBoxChucVu = new ComboBox();
            label3 = new Label();
            panel1 = new Panel();
            buttonEdit = new Button();
            buttonExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(297, 81);
            label5.Name = "label5";
            label5.Size = new Size(166, 21);
            label5.TabIndex = 42;
            label5.Text = "Tìm kiếm theo CMT :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(206, 30);
            label1.TabIndex = 0;
            label1.Text = "Độc giả hết hạn thẻ";
            // 
            // dataGridViewData
            // 
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnTen, ColumnNgaySinh, ColumnCMT, ColumnChucVu, ColumnNgayCapThe, ColumnNgayHetHan, ColumnSoSachDaMuon, ColumnSoSachDaTra, ColumnSoSachChuaTra });
            dataGridViewData.Location = new Point(4, 132);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewData.RowTemplate.Height = 65;
            dataGridViewData.Size = new Size(1062, 515);
            dataGridViewData.TabIndex = 41;
            // 
            // ColumnId
            // 
            ColumnId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumnId.DataPropertyName = "id";
            ColumnId.FillWeight = 46.5289536F;
            ColumnId.HeaderText = "Id";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.Width = 42;
            // 
            // ColumnTen
            // 
            ColumnTen.FillWeight = 19.90304F;
            ColumnTen.HeaderText = "Tên";
            ColumnTen.MinimumWidth = 6;
            ColumnTen.Name = "ColumnTen";
            ColumnTen.Width = 200;
            // 
            // ColumnNgaySinh
            // 
            ColumnNgaySinh.FillWeight = 19.90304F;
            ColumnNgaySinh.HeaderText = "Ngày sinh";
            ColumnNgaySinh.MinimumWidth = 6;
            ColumnNgaySinh.Name = "ColumnNgaySinh";
            // 
            // ColumnCMT
            // 
            ColumnCMT.FillWeight = 18F;
            ColumnCMT.HeaderText = "CMT";
            ColumnCMT.MinimumWidth = 6;
            ColumnCMT.Name = "ColumnCMT";
            ColumnCMT.Width = 150;
            // 
            // ColumnChucVu
            // 
            ColumnChucVu.FillWeight = 12F;
            ColumnChucVu.HeaderText = "Chức vụ ";
            ColumnChucVu.MinimumWidth = 6;
            ColumnChucVu.Name = "ColumnChucVu";
            ColumnChucVu.Width = 90;
            // 
            // ColumnNgayCapThe
            // 
            ColumnNgayCapThe.HeaderText = "Ngày cấp thẻ";
            ColumnNgayCapThe.Name = "ColumnNgayCapThe";
            ColumnNgayCapThe.Width = 110;
            // 
            // ColumnNgayHetHan
            // 
            ColumnNgayHetHan.FillWeight = 21.0621071F;
            ColumnNgayHetHan.HeaderText = "Ngày hết hạn thẻ";
            ColumnNgayHetHan.MinimumWidth = 6;
            ColumnNgayHetHan.Name = "ColumnNgayHetHan";
            ColumnNgayHetHan.Width = 110;
            // 
            // ColumnSoSachDaMuon
            // 
            ColumnSoSachDaMuon.HeaderText = "Số sách đã mượn";
            ColumnSoSachDaMuon.Name = "ColumnSoSachDaMuon";
            ColumnSoSachDaMuon.Width = 70;
            // 
            // ColumnSoSachDaTra
            // 
            ColumnSoSachDaTra.HeaderText = "Số sách đã trả";
            ColumnSoSachDaTra.Name = "ColumnSoSachDaTra";
            ColumnSoSachDaTra.Width = 70;
            // 
            // ColumnSoSachChuaTra
            // 
            ColumnSoSachChuaTra.HeaderText = "Số sách chưa trả";
            ColumnSoSachChuaTra.Name = "ColumnSoSachChuaTra";
            ColumnSoSachChuaTra.Width = 70;
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
            buttonTimKiem.Location = new Point(670, 75);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(131, 38);
            buttonTimKiem.TabIndex = 40;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = false;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = Color.Red;
            buttonXoa.FlatAppearance.BorderSize = 0;
            buttonXoa.FlatStyle = FlatStyle.Flat;
            buttonXoa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonXoa.ForeColor = SystemColors.ButtonHighlight;
            buttonXoa.Image = (Image)resources.GetObject("buttonXoa.Image");
            buttonXoa.ImageAlign = ContentAlignment.MiddleLeft;
            buttonXoa.Location = new Point(1099, 428);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(99, 39);
            buttonXoa.TabIndex = 38;
            buttonXoa.Text = "Xoá";
            buttonXoa.UseVisualStyleBackColor = false;
            // 
            // buttonChiTiet
            // 
            buttonChiTiet.BackColor = Color.FromArgb(192, 64, 0);
            buttonChiTiet.FlatAppearance.BorderSize = 0;
            buttonChiTiet.FlatStyle = FlatStyle.Flat;
            buttonChiTiet.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonChiTiet.ForeColor = SystemColors.ButtonHighlight;
            buttonChiTiet.Image = (Image)resources.GetObject("buttonChiTiet.Image");
            buttonChiTiet.ImageAlign = ContentAlignment.MiddleLeft;
            buttonChiTiet.Location = new Point(1099, 216);
            buttonChiTiet.Name = "buttonChiTiet";
            buttonChiTiet.Size = new Size(99, 39);
            buttonChiTiet.TabIndex = 37;
            buttonChiTiet.Text = "Chi tiết";
            buttonChiTiet.UseVisualStyleBackColor = false;
            // 
            // buttonThem
            // 
            buttonThem.BackColor = Color.FromArgb(40, 167, 69);
            buttonThem.FlatAppearance.BorderSize = 0;
            buttonThem.FlatStyle = FlatStyle.Flat;
            buttonThem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonThem.ForeColor = SystemColors.ButtonHighlight;
            buttonThem.Image = (Image)resources.GetObject("buttonThem.Image");
            buttonThem.ImageAlign = ContentAlignment.MiddleLeft;
            buttonThem.Location = new Point(1099, 280);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(99, 39);
            buttonThem.TabIndex = 36;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = false;
            // 
            // textBoxTimkiem
            // 
            textBoxTimkiem.Location = new Point(485, 81);
            textBoxTimkiem.Name = "textBoxTimkiem";
            textBoxTimkiem.Size = new Size(163, 23);
            textBoxTimkiem.TabIndex = 35;
            // 
            // comboBoxChucVu
            // 
            comboBoxChucVu.FormattingEnabled = true;
            comboBoxChucVu.Location = new Point(156, 78);
            comboBoxChucVu.Name = "comboBoxChucVu";
            comboBoxChucVu.Size = new Size(121, 23);
            comboBoxChucVu.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(71, 80);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 33;
            label3.Text = "Chức vụ :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 83, 102);
            panel1.Controls.Add(buttonExport);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1221, 58);
            panel1.TabIndex = 32;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(255, 128, 0);
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.ForeColor = SystemColors.ButtonHighlight;
            buttonEdit.Image = (Image)resources.GetObject("buttonEdit.Image");
            buttonEdit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEdit.Location = new Point(1099, 347);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(99, 39);
            buttonEdit.TabIndex = 39;
            buttonEdit.Text = "Sửa";
            buttonEdit.UseVisualStyleBackColor = false;
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
            buttonExport.Location = new Point(1036, 10);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(99, 39);
            buttonExport.TabIndex = 43;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = false;
            buttonExport.Click += buttonExport_Click;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(dataGridViewData);
            Controls.Add(buttonTimKiem);
            Controls.Add(buttonXoa);
            Controls.Add(buttonChiTiet);
            Controls.Add(buttonThem);
            Controls.Add(textBoxTimkiem);
            Controls.Add(comboBoxChucVu);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(buttonEdit);
            Name = "index";
            Size = new Size(1221, 650);
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private DataGridView dataGridViewData;
        private Button buttonTimKiem;
        private Button buttonXoa;
        private Button buttonChiTiet;
        private Button buttonThem;
        private TextBox textBoxTimkiem;
        private ComboBox comboBoxChucVu;
        private Label label3;
        private Panel panel1;
        private Button buttonEdit;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnTen;
        private DataGridViewTextBoxColumn ColumnNgaySinh;
        private DataGridViewTextBoxColumn ColumnCMT;
        private DataGridViewTextBoxColumn ColumnChucVu;
        private DataGridViewTextBoxColumn ColumnNgayCapThe;
        private DataGridViewTextBoxColumn ColumnNgayHetHan;
        private DataGridViewTextBoxColumn ColumnSoSachDaMuon;
        private DataGridViewTextBoxColumn ColumnSoSachDaTra;
        private DataGridViewTextBoxColumn ColumnSoSachChuaTra;
        private Button buttonExport;
    }
}
