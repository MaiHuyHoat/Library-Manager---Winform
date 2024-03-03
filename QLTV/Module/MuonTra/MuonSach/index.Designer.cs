namespace QLTV.Module.MuonTra.MuonSach
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
            ColumnAnhSach = new DataGridViewImageColumn();
            ColumnTenSach = new DataGridViewTextBoxColumn();
            ColumnNguoiMuon = new DataGridViewTextBoxColumn();
            ColumnCMT = new DataGridViewTextBoxColumn();
            ColumnNgayMuon = new DataGridViewTextBoxColumn();
            ColumnHanTra = new DataGridViewTextBoxColumn();
            buttonTimKiem = new Button();
            buttonSua = new Button();
            buttonXoa = new Button();
            buttonThem = new Button();
            textBoxTimkiem = new TextBox();
            label5 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            comboBoxNgayTao = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewData
            // 
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnAnhSach, ColumnTenSach, ColumnNguoiMuon, ColumnCMT, ColumnNgayMuon, ColumnHanTra });
            dataGridViewData.Location = new Point(6, 135);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewData.RowTemplate.Height = 65;
            dataGridViewData.Size = new Size(1075, 499);
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
            // ColumnAnhSach
            // 
            ColumnAnhSach.DataPropertyName = "image";
            ColumnAnhSach.HeaderText = "Ảnh sách";
            ColumnAnhSach.Image = (Image)resources.GetObject("ColumnAnhSach.Image");
            ColumnAnhSach.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ColumnAnhSach.MinimumWidth = 6;
            ColumnAnhSach.Name = "ColumnAnhSach";
            ColumnAnhSach.Resizable = DataGridViewTriState.True;
            ColumnAnhSach.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnTenSach
            // 
            ColumnTenSach.FillWeight = 85.04722F;
            ColumnTenSach.HeaderText = "Tên sách";
            ColumnTenSach.MinimumWidth = 6;
            ColumnTenSach.Name = "ColumnTenSach";
            // 
            // ColumnNguoiMuon
            // 
            ColumnNguoiMuon.FillWeight = 85.04722F;
            ColumnNguoiMuon.HeaderText = "Người mượn";
            ColumnNguoiMuon.MinimumWidth = 6;
            ColumnNguoiMuon.Name = "ColumnNguoiMuon";
            // 
            // ColumnCMT
            // 
            ColumnCMT.HeaderText = "Chứng minh thư";
            ColumnCMT.Name = "ColumnCMT";
            // 
            // ColumnNgayMuon
            // 
            ColumnNgayMuon.FillWeight = 46.5289536F;
            ColumnNgayMuon.HeaderText = "Ngày mượn";
            ColumnNgayMuon.MinimumWidth = 6;
            ColumnNgayMuon.Name = "ColumnNgayMuon";
            // 
            // ColumnHanTra
            // 
            ColumnHanTra.FillWeight = 68.03777F;
            ColumnHanTra.HeaderText = "Hạn trả";
            ColumnHanTra.MinimumWidth = 6;
            ColumnHanTra.Name = "ColumnHanTra";
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
            buttonTimKiem.Location = new Point(634, 72);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(125, 33);
            buttonTimKiem.TabIndex = 29;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = false;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // buttonSua
            // 
            buttonSua.BackColor = SystemColors.Highlight;
            buttonSua.FlatAppearance.BorderSize = 0;
            buttonSua.FlatStyle = FlatStyle.Flat;
            buttonSua.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSua.ForeColor = SystemColors.ButtonHighlight;
            buttonSua.Image = (Image)resources.GetObject("buttonSua.Image");
            buttonSua.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSua.Location = new Point(1087, 315);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(131, 39);
            buttonSua.TabIndex = 28;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = false;
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
            buttonXoa.Location = new Point(1087, 432);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(131, 39);
            buttonXoa.TabIndex = 27;
            buttonXoa.Text = "Xoá";
            buttonXoa.UseVisualStyleBackColor = false;
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
            buttonThem.Location = new Point(1087, 248);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(131, 39);
            buttonThem.TabIndex = 25;
            buttonThem.Text = "Mượn sách";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // textBoxTimkiem
            // 
            textBoxTimkiem.Location = new Point(452, 78);
            textBoxTimkiem.Name = "textBoxTimkiem";
            textBoxTimkiem.Size = new Size(163, 23);
            textBoxTimkiem.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(280, 78);
            label5.Name = "label5";
            label5.Size = new Size(166, 21);
            label5.TabIndex = 23;
            label5.Text = "Tìm kiếm theo CMT :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(284, 30);
            label1.TabIndex = 0;
            label1.Text = "Danh sách đang mượn sách";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 83, 102);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1221, 58);
            panel1.TabIndex = 16;
            // 
            // comboBoxNgayTao
            // 
            comboBoxNgayTao.FormattingEnabled = true;
            comboBoxNgayTao.Location = new Point(111, 80);
            comboBoxNgayTao.Name = "comboBoxNgayTao";
            comboBoxNgayTao.Size = new Size(121, 23);
            comboBoxNgayTao.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 78);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 31;
            label2.Text = "Ngày tạo :";
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(1087, 372);
            button1.Name = "button1";
            button1.Size = new Size(131, 39);
            button1.TabIndex = 33;
            button1.Text = "Trả sách";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(comboBoxNgayTao);
            Controls.Add(label2);
            Controls.Add(dataGridViewData);
            Controls.Add(buttonTimKiem);
            Controls.Add(buttonSua);
            Controls.Add(buttonXoa);
            Controls.Add(buttonThem);
            Controls.Add(textBoxTimkiem);
            Controls.Add(label5);
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
        private Button buttonSua;
        private Button buttonXoa;
        private Button buttonThem;
        private TextBox textBoxTimkiem;
        private Label label5;
        private Label label1;
        private Panel panel1;
        private ComboBox comboBoxNgayTao;
        private Label label2;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewImageColumn ColumnAnhSach;
        private DataGridViewTextBoxColumn ColumnTenSach;
        private DataGridViewTextBoxColumn ColumnNguoiMuon;
        private DataGridViewTextBoxColumn ColumnCMT;
        private DataGridViewTextBoxColumn ColumnNgayMuon;
        private DataGridViewTextBoxColumn ColumnHanTra;
        private Button button1;
    }
}
