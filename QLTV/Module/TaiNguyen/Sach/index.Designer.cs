namespace QLTV.Module.TaiNguyen.Sach
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            comboBoxNgayTao = new ComboBox();
            comboBoxTheLoai = new ComboBox();
            label3 = new Label();
            comboBoxTacGia = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            textBoxTimkiem = new TextBox();
            buttonThem = new Button();
            buttonChiTiet = new Button();
            buttonXoa = new Button();
            buttonEdit = new Button();
            buttonTimKiem = new Button();
            dataGridViewData = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnTenSach = new DataGridViewImageColumn();
            ColumnTen = new DataGridViewTextBoxColumn();
            ColumnTheLoai = new DataGridViewTextBoxColumn();
            ColumnTacGia = new DataGridViewTextBoxColumn();
            ColumnGia = new DataGridViewTextBoxColumn();
            ColumnAmount = new DataGridViewTextBoxColumn();
            ColumnNgayTao = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 83, 102);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1395, 77);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(177, 37);
            label1.TabIndex = 0;
            label1.Text = "Quản lý sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 108);
            label2.Name = "label2";
            label2.Size = new Size(110, 28);
            label2.TabIndex = 1;
            label2.Text = "Ngày tạo :";
            // 
            // comboBoxNgayTao
            // 
            comboBoxNgayTao.FormattingEnabled = true;
            comboBoxNgayTao.Location = new Point(123, 103);
            comboBoxNgayTao.Margin = new Padding(3, 4, 3, 4);
            comboBoxNgayTao.Name = "comboBoxNgayTao";
            comboBoxNgayTao.Size = new Size(138, 28);
            comboBoxNgayTao.TabIndex = 2;
            // 
            // comboBoxTheLoai
            // 
            comboBoxTheLoai.FormattingEnabled = true;
            comboBoxTheLoai.Location = new Point(629, 103);
            comboBoxTheLoai.Margin = new Padding(3, 4, 3, 4);
            comboBoxTheLoai.Name = "comboBoxTheLoai";
            comboBoxTheLoai.Size = new Size(138, 28);
            comboBoxTheLoai.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(531, 105);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 3;
            label3.Text = "Thể loại :";
            // 
            // comboBoxTacGia
            // 
            comboBoxTacGia.FormattingEnabled = true;
            comboBoxTacGia.Location = new Point(375, 105);
            comboBoxTacGia.Margin = new Padding(3, 4, 3, 4);
            comboBoxTacGia.Name = "comboBoxTacGia";
            comboBoxTacGia.Size = new Size(138, 28);
            comboBoxTacGia.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(287, 108);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 5;
            label4.Text = "Tác giả :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(794, 105);
            label5.Name = "label5";
            label5.Size = new Size(111, 28);
            label5.TabIndex = 7;
            label5.Text = "Tìm kiếm :";
            // 
            // textBoxTimkiem
            // 
            textBoxTimkiem.Location = new Point(903, 103);
            textBoxTimkiem.Margin = new Padding(3, 4, 3, 4);
            textBoxTimkiem.Name = "textBoxTimkiem";
            textBoxTimkiem.Size = new Size(186, 27);
            textBoxTimkiem.TabIndex = 8;
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
            buttonThem.TabIndex = 9;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
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
            buttonChiTiet.TabIndex = 11;
            buttonChiTiet.Text = "Chi tiết";
            buttonChiTiet.UseVisualStyleBackColor = false;
            buttonChiTiet.Click += buttonChiTiet_Click;
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
            buttonXoa.TabIndex = 12;
            buttonXoa.Text = "Xoá";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
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
            buttonEdit.TabIndex = 13;
            buttonEdit.Text = "Sửa";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
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
            buttonTimKiem.Location = new Point(1114, 96);
            buttonTimKiem.Margin = new Padding(3, 4, 3, 4);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(150, 51);
            buttonTimKiem.TabIndex = 14;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = false;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // dataGridViewData
            // 
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnTenSach, ColumnTen, ColumnTheLoai, ColumnTacGia, ColumnGia, ColumnAmount, ColumnNgayTao });
            dataGridViewData.Location = new Point(7, 183);
            dataGridViewData.Margin = new Padding(3, 4, 3, 4);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewData.RowTemplate.Height = 65;
            dataGridViewData.Size = new Size(1229, 667);
            dataGridViewData.TabIndex = 15;
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
            // ColumnGia
            // 
            ColumnGia.FillWeight = 46.5289536F;
            ColumnGia.HeaderText = "Giá";
            ColumnGia.MinimumWidth = 6;
            ColumnGia.Name = "ColumnGia";
            // 
            // ColumnAmount
            // 
            ColumnAmount.FillWeight = 46.5289536F;
            ColumnAmount.HeaderText = "Số lượng";
            ColumnAmount.MinimumWidth = 6;
            ColumnAmount.Name = "ColumnAmount";
            // 
            // ColumnNgayTao
            // 
            ColumnNgayTao.FillWeight = 59.53306F;
            ColumnNgayTao.HeaderText = "Ngày tạo";
            ColumnNgayTao.MinimumWidth = 6;
            ColumnNgayTao.Name = "ColumnNgayTao";
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
            Controls.Add(comboBoxTacGia);
            Controls.Add(label4);
            Controls.Add(comboBoxTheLoai);
            Controls.Add(label3);
            Controls.Add(comboBoxNgayTao);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "index";
            Size = new Size(1395, 867);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxNgayTao;
        private ComboBox comboBoxTheLoai;
        private Label label3;
        private ComboBox comboBoxTacGia;
        private Label label4;
        private Label label5;
        private TextBox textBoxTimkiem;
        private Button buttonThem;
        private Button buttonChiTiet;
        private Button buttonXoa;
        private Button buttonEdit;
        private Button buttonTimKiem;
        private DataGridView dataGridViewData;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewImageColumn ColumnTenSach;
        private DataGridViewTextBoxColumn ColumnTen;
        private DataGridViewTextBoxColumn ColumnTheLoai;
        private DataGridViewTextBoxColumn ColumnTacGia;
        private DataGridViewTextBoxColumn ColumnGia;
        private DataGridViewTextBoxColumn ColumnAmount;
        private DataGridViewTextBoxColumn ColumnNgayTao;
    }
}
