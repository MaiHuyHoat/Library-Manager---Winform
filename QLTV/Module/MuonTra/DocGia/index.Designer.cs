namespace QLTV.Module.MuonTra.DocGia
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
            ColumnTen = new DataGridViewTextBoxColumn();
            ColumnNgaySinh = new DataGridViewTextBoxColumn();
            ColumnCMT = new DataGridViewTextBoxColumn();
            ColumnNgayTao = new DataGridViewTextBoxColumn();
            buttonTimKiem = new Button();
            buttonEdit = new Button();
            buttonXoa = new Button();
            buttonChiTiet = new Button();
            buttonThem = new Button();
            textBoxTimkiem = new TextBox();
            label5 = new Label();
            comboBoxTheLoai = new ComboBox();
            label3 = new Label();
            comboBoxNgayTao = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewData
            // 
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnTen, ColumnNgaySinh, ColumnCMT, ColumnNgayTao });
            dataGridViewData.Location = new Point(7, 183);
            dataGridViewData.Margin = new Padding(3, 4, 3, 4);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewData.RowTemplate.Height = 65;
            dataGridViewData.Size = new Size(1229, 667);
            dataGridViewData.TabIndex = 30;
            // 
            // ColumnId
            // 
            ColumnId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumnId.DataPropertyName = "id";
            ColumnId.FillWeight = 46.5289536F;
            ColumnId.HeaderText = "Id";
            ColumnId.MinimumWidth = 6;
            ColumnId.Name = "ColumnId";
            ColumnId.Width = 51;
            // 
            // ColumnTen
            // 
            ColumnTen.FillWeight = 85.04722F;
            ColumnTen.HeaderText = "Tên";
            ColumnTen.MinimumWidth = 6;
            ColumnTen.Name = "ColumnTen";
            // 
            // ColumnNgaySinh
            // 
            ColumnNgaySinh.FillWeight = 85.04722F;
            ColumnNgaySinh.HeaderText = "Ngày sinh";
            ColumnNgaySinh.MinimumWidth = 6;
            ColumnNgaySinh.Name = "ColumnNgaySinh";
            // 
            // ColumnCMT
            // 
            ColumnCMT.FillWeight = 46.5289536F;
            ColumnCMT.HeaderText = "CMT";
            ColumnCMT.MinimumWidth = 6;
            ColumnCMT.Name = "ColumnCMT";
            // 
            // ColumnNgayTao
            // 
            ColumnNgayTao.FillWeight = 59.53306F;
            ColumnNgayTao.HeaderText = "Ngày tạo";
            ColumnNgayTao.MinimumWidth = 6;
            ColumnNgayTao.Name = "ColumnNgayTao";
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
            buttonTimKiem.Location = new Point(866, 105);
            buttonTimKiem.Margin = new Padding(3, 4, 3, 4);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(150, 51);
            buttonTimKiem.TabIndex = 29;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(255, 128, 0);
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.ForeColor = SystemColors.ButtonHighlight;
            buttonEdit.Location = new Point(1258, 469);
            buttonEdit.Margin = new Padding(3, 4, 3, 4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(113, 52);
            buttonEdit.TabIndex = 28;
            buttonEdit.Text = "Sửa";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonXoa
            // 
            buttonXoa.BackColor = Color.Red;
            buttonXoa.FlatAppearance.BorderSize = 0;
            buttonXoa.FlatStyle = FlatStyle.Flat;
            buttonXoa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonXoa.ForeColor = SystemColors.ButtonHighlight;
            buttonXoa.Location = new Point(1258, 577);
            buttonXoa.Margin = new Padding(3, 4, 3, 4);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(113, 52);
            buttonXoa.TabIndex = 27;
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
            buttonChiTiet.Location = new Point(1258, 295);
            buttonChiTiet.Margin = new Padding(3, 4, 3, 4);
            buttonChiTiet.Name = "buttonChiTiet";
            buttonChiTiet.Size = new Size(113, 52);
            buttonChiTiet.TabIndex = 26;
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
            buttonThem.Location = new Point(1258, 380);
            buttonThem.Margin = new Padding(3, 4, 3, 4);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(113, 52);
            buttonThem.TabIndex = 25;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = false;
            // 
            // textBoxTimkiem
            // 
            textBoxTimkiem.Location = new Point(655, 112);
            textBoxTimkiem.Margin = new Padding(3, 4, 3, 4);
            textBoxTimkiem.Name = "textBoxTimkiem";
            textBoxTimkiem.Size = new Size(186, 27);
            textBoxTimkiem.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(546, 114);
            label5.Name = "label5";
            label5.Size = new Size(111, 28);
            label5.TabIndex = 23;
            label5.Text = "Tìm kiếm :";
            // 
            // comboBoxTheLoai
            // 
            comboBoxTheLoai.FormattingEnabled = true;
            comboBoxTheLoai.Location = new Point(381, 112);
            comboBoxTheLoai.Margin = new Padding(3, 4, 3, 4);
            comboBoxTheLoai.Name = "comboBoxTheLoai";
            comboBoxTheLoai.Size = new Size(138, 28);
            comboBoxTheLoai.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(283, 114);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 19;
            label3.Text = "Thể loại :";
            // 
            // comboBoxNgayTao
            // 
            comboBoxNgayTao.FormattingEnabled = true;
            comboBoxNgayTao.Location = new Point(125, 111);
            comboBoxNgayTao.Margin = new Padding(3, 4, 3, 4);
            comboBoxNgayTao.Name = "comboBoxNgayTao";
            comboBoxNgayTao.Size = new Size(138, 28);
            comboBoxNgayTao.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 116);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 17;
            label2.Text = "Ngày tạo :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(215, 37);
            label1.TabIndex = 0;
            label1.Text = "Quản lý độc giả";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 83, 102);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1395, 77);
            panel1.TabIndex = 16;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewData);
            Controls.Add(buttonTimKiem);
            Controls.Add(buttonEdit);
            Controls.Add(buttonXoa);
            Controls.Add(buttonChiTiet);
            Controls.Add(buttonThem);
            Controls.Add(textBoxTimkiem);
            Controls.Add(label5);
            Controls.Add(comboBoxTheLoai);
            Controls.Add(label3);
            Controls.Add(comboBoxNgayTao);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "index";
            Size = new Size(1395, 867);
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewData;
        private Button buttonTimKiem;
        private Button buttonEdit;
        private Button buttonXoa;
        private Button buttonChiTiet;
        private Button buttonThem;
        private TextBox textBoxTimkiem;
        private Label label5;
        private ComboBox comboBoxTheLoai;
        private Label label3;
        private ComboBox comboBoxNgayTao;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnTen;
        private DataGridViewTextBoxColumn ColumnNgaySinh;
        private DataGridViewTextBoxColumn ColumnCMT;
        private DataGridViewTextBoxColumn ColumnNgayTao;
    }
}
