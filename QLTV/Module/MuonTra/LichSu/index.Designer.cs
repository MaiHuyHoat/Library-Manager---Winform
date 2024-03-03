namespace QLTV.Module.MuonTra.LichSu
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
            label1 = new Label();
            dataGridViewData = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNguoiMuon = new DataGridViewTextBoxColumn();
            ColumnAnhSach = new DataGridViewImageColumn();
            ColumnSach = new DataGridViewTextBoxColumn();
            ColumnTrangThai = new DataGridViewTextBoxColumn();
            ColumnNgayMuon = new DataGridViewTextBoxColumn();
            ColumnTienPhat = new DataGridViewTextBoxColumn();
            buttonTimKiem = new Button();
            buttonXoa = new Button();
            buttonChitiet = new Button();
            textBoxTimkiem = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            buttonSua = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(300, 37);
            label1.TabIndex = 0;
            label1.Text = "Lịch sử mượn/trả sách";
            // 
            // dataGridViewData
            // 
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNguoiMuon, ColumnAnhSach, ColumnSach, ColumnTrangThai, ColumnNgayMuon, ColumnTienPhat });
            dataGridViewData.Location = new Point(7, 183);
            dataGridViewData.Margin = new Padding(3, 4, 3, 4);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewData.RowTemplate.Height = 65;
            dataGridViewData.Size = new Size(1229, 665);
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
            ColumnId.Width = 51;
            // 
            // ColumnNguoiMuon
            // 
            ColumnNguoiMuon.HeaderText = "Người mượn";
            ColumnNguoiMuon.MinimumWidth = 6;
            ColumnNguoiMuon.Name = "ColumnNguoiMuon";
            // 
            // ColumnAnhSach
            // 
            ColumnAnhSach.DataPropertyName = "image";
            ColumnAnhSach.FillWeight = 50F;
            ColumnAnhSach.HeaderText = "Ảnh sách";
            ColumnAnhSach.Image = (Image)resources.GetObject("ColumnAnhSach.Image");
            ColumnAnhSach.ImageLayout = DataGridViewImageCellLayout.Zoom;
            ColumnAnhSach.MinimumWidth = 6;
            ColumnAnhSach.Name = "ColumnAnhSach";
            ColumnAnhSach.Resizable = DataGridViewTriState.True;
            ColumnAnhSach.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnSach
            // 
            ColumnSach.HeaderText = "Sách";
            ColumnSach.MinimumWidth = 6;
            ColumnSach.Name = "ColumnSach";
            // 
            // ColumnTrangThai
            // 
            ColumnTrangThai.FillWeight = 90F;
            ColumnTrangThai.HeaderText = "Trạng thái trả sách";
            ColumnTrangThai.MinimumWidth = 6;
            ColumnTrangThai.Name = "ColumnTrangThai";
            // 
            // ColumnNgayMuon
            // 
            ColumnNgayMuon.HeaderText = "Ngày phải trả/Ngày trả";
            ColumnNgayMuon.MinimumWidth = 6;
            ColumnNgayMuon.Name = "ColumnNgayMuon";
            // 
            // ColumnTienPhat
            // 
            ColumnTienPhat.FillWeight = 68.03777F;
            ColumnTienPhat.HeaderText = "Số tiền phạt";
            ColumnTienPhat.MinimumWidth = 6;
            ColumnTienPhat.Name = "ColumnTienPhat";
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
            buttonTimKiem.Location = new Point(725, 99);
            buttonTimKiem.Margin = new Padding(3, 4, 3, 4);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(143, 44);
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
            buttonXoa.Location = new Point(1242, 501);
            buttonXoa.Margin = new Padding(3, 4, 3, 4);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(150, 52);
            buttonXoa.TabIndex = 38;
            buttonXoa.Text = "Xoá";
            buttonXoa.UseVisualStyleBackColor = false;
            buttonXoa.Click += buttonXoa_Click;
            // 
            // buttonChitiet
            // 
            buttonChitiet.BackColor = Color.FromArgb(40, 167, 69);
            buttonChitiet.FlatAppearance.BorderSize = 0;
            buttonChitiet.FlatStyle = FlatStyle.Flat;
            buttonChitiet.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonChitiet.ForeColor = SystemColors.ButtonHighlight;
            buttonChitiet.Image = (Image)resources.GetObject("buttonChitiet.Image");
            buttonChitiet.ImageAlign = ContentAlignment.MiddleLeft;
            buttonChitiet.Location = new Point(1242, 334);
            buttonChitiet.Margin = new Padding(3, 4, 3, 4);
            buttonChitiet.Name = "buttonChitiet";
            buttonChitiet.Size = new Size(150, 52);
            buttonChitiet.TabIndex = 37;
            buttonChitiet.Text = "Xem chi tiết";
            buttonChitiet.UseVisualStyleBackColor = false;
            buttonChitiet.Click += buttonChitiet_Click;
            // 
            // textBoxTimkiem
            // 
            textBoxTimkiem.Location = new Point(517, 107);
            textBoxTimkiem.Margin = new Padding(3, 4, 3, 4);
            textBoxTimkiem.Name = "textBoxTimkiem";
            textBoxTimkiem.Size = new Size(186, 27);
            textBoxTimkiem.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(320, 107);
            label5.Name = "label5";
            label5.Size = new Size(209, 28);
            label5.TabIndex = 35;
            label5.Text = "Tìm kiếm theo CMT :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 83, 102);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1395, 77);
            panel1.TabIndex = 34;
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
            buttonSua.Location = new Point(1242, 423);
            buttonSua.Margin = new Padding(3, 4, 3, 4);
            buttonSua.Name = "buttonSua";
            buttonSua.Size = new Size(150, 52);
            buttonSua.TabIndex = 39;
            buttonSua.Text = "Sửa";
            buttonSua.UseVisualStyleBackColor = false;
            buttonSua.Click += buttonSua_Click;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewData);
            Controls.Add(buttonTimKiem);
            Controls.Add(buttonXoa);
            Controls.Add(buttonChitiet);
            Controls.Add(textBoxTimkiem);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(buttonSua);
            Name = "index";
            Size = new Size(1395, 867);
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dataGridViewData;
        private Button buttonTimKiem;
        private Button buttonXoa;
        private Button buttonChitiet;
        private TextBox textBoxTimkiem;
        private Label label5;
        private Panel panel1;
        private Button buttonSua;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNguoiMuon;
        private DataGridViewImageColumn ColumnAnhSach;
        private DataGridViewTextBoxColumn ColumnSach;
        private DataGridViewTextBoxColumn ColumnTrangThai;
        private DataGridViewTextBoxColumn ColumnNgayMuon;
        private DataGridViewTextBoxColumn ColumnTienPhat;
    }
}
