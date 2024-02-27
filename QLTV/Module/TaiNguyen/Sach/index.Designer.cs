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
            panel1.Name = "panel1";
            panel1.Size = new Size(1221, 58);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(138, 30);
            label1.TabIndex = 0;
            label1.Text = "Quản lý sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 81);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 1;
            label2.Text = "Ngày tạo :";
            // 
            // comboBoxNgayTao
            // 
            comboBoxNgayTao.FormattingEnabled = true;
            comboBoxNgayTao.Location = new Point(108, 77);
            comboBoxNgayTao.Name = "comboBoxNgayTao";
            comboBoxNgayTao.Size = new Size(121, 23);
            comboBoxNgayTao.TabIndex = 2;
            // 
            // comboBoxTheLoai
            // 
            comboBoxTheLoai.FormattingEnabled = true;
            comboBoxTheLoai.Location = new Point(550, 77);
            comboBoxTheLoai.Name = "comboBoxTheLoai";
            comboBoxTheLoai.Size = new Size(121, 23);
            comboBoxTheLoai.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(465, 79);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 3;
            label3.Text = "Thể loại :";
            // 
            // comboBoxTacGia
            // 
            comboBoxTacGia.FormattingEnabled = true;
            comboBoxTacGia.Location = new Point(328, 79);
            comboBoxTacGia.Name = "comboBoxTacGia";
            comboBoxTacGia.Size = new Size(121, 23);
            comboBoxTacGia.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(251, 81);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 5;
            label4.Text = "Tác giả :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(695, 79);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 7;
            label5.Text = "Tìm kiếm :";
            // 
            // textBoxTimkiem
            // 
            textBoxTimkiem.Location = new Point(790, 77);
            textBoxTimkiem.Name = "textBoxTimkiem";
            textBoxTimkiem.Size = new Size(163, 23);
            textBoxTimkiem.TabIndex = 8;
            // 
            // buttonThem
            // 
            buttonThem.BackColor = Color.FromArgb(40, 167, 69);
            buttonThem.FlatAppearance.BorderSize = 0;
            buttonThem.FlatStyle = FlatStyle.Flat;
            buttonThem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonThem.ForeColor = SystemColors.ButtonHighlight;
            buttonThem.Location = new Point(1101, 285);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(99, 39);
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
            buttonChiTiet.Location = new Point(1101, 221);
            buttonChiTiet.Name = "buttonChiTiet";
            buttonChiTiet.Size = new Size(99, 39);
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
            buttonXoa.Location = new Point(1101, 433);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(99, 39);
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
            buttonEdit.Location = new Point(1101, 352);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(99, 39);
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
            buttonTimKiem.Location = new Point(975, 72);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(131, 38);
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
            dataGridViewData.Location = new Point(6, 137);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewData.RowTemplate.Height = 65;
            dataGridViewData.Size = new Size(1075, 500);
            dataGridViewData.TabIndex = 15;
            // 
            // ColumnId
            // 
            ColumnId.DataPropertyName = "id";
            ColumnId.FillWeight = 46.5289536F;
            ColumnId.HeaderText = "Id";
            ColumnId.Name = "ColumnId";
            // 
            // ColumnTenSach
            // 
            ColumnTenSach.DataPropertyName = "image";
            ColumnTenSach.HeaderText = "Ảnh";
            ColumnTenSach.Image = (Image)resources.GetObject("ColumnTenSach.Image");
            ColumnTenSach.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ColumnTenSach.Name = "ColumnTenSach";
            ColumnTenSach.Resizable = DataGridViewTriState.True;
            ColumnTenSach.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnTen
            // 
            ColumnTen.FillWeight = 85.04722F;
            ColumnTen.HeaderText = "Tên";
            ColumnTen.Name = "ColumnTen";
            // 
            // ColumnTheLoai
            // 
            ColumnTheLoai.FillWeight = 85.04722F;
            ColumnTheLoai.HeaderText = "Thể loại";
            ColumnTheLoai.Name = "ColumnTheLoai";
            // 
            // ColumnTacGia
            // 
            ColumnTacGia.FillWeight = 68.03777F;
            ColumnTacGia.HeaderText = "Tác giả";
            ColumnTacGia.Name = "ColumnTacGia";
            // 
            // ColumnGia
            // 
            ColumnGia.FillWeight = 46.5289536F;
            ColumnGia.HeaderText = "Giá";
            ColumnGia.Name = "ColumnGia";
            // 
            // ColumnAmount
            // 
            ColumnAmount.FillWeight = 46.5289536F;
            ColumnAmount.HeaderText = "Số lượng";
            ColumnAmount.Name = "ColumnAmount";
            // 
            // ColumnNgayTao
            // 
            ColumnNgayTao.FillWeight = 59.53306F;
            ColumnNgayTao.HeaderText = "Ngày tạo";
            ColumnNgayTao.Name = "ColumnNgayTao";
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Name = "index";
            Size = new Size(1221, 650);
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
