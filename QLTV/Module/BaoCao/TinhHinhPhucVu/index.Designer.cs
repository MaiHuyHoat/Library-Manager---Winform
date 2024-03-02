namespace QLTV.Module.BaoCao.TinhHinhPhucVu
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
            ColumnTongSL = new DataGridViewTextBoxColumn();
            ColumnSLPhucVu = new DataGridViewTextBoxColumn();
            ColumnSLMuon = new DataGridViewTextBoxColumn();
            ColumnTLTot = new DataGridViewTextBoxColumn();
            ColumnTLXau = new DataGridViewTextBoxColumn();
            ColumnTLBoiThuong = new DataGridViewTextBoxColumn();
            ColumnTien = new DataGridViewTextBoxColumn();
            buttonTimKiem = new Button();
            textBoxTimkiem = new TextBox();
            label5 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            buttonExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewData
            // 
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnTenSach, ColumnTen, ColumnTongSL, ColumnSLPhucVu, ColumnSLMuon, ColumnTLTot, ColumnTLXau, ColumnTLBoiThuong, ColumnTien });
            dataGridViewData.Location = new Point(7, 182);
            dataGridViewData.Margin = new Padding(3, 4, 3, 4);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.RowHeadersWidth = 51;
            dataGridViewData.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewData.RowTemplate.Height = 65;
            dataGridViewData.Size = new Size(1368, 667);
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
            // ColumnTongSL
            // 
            ColumnTongSL.FillWeight = 85.04722F;
            ColumnTongSL.HeaderText = "Tổng SL";
            ColumnTongSL.MinimumWidth = 6;
            ColumnTongSL.Name = "ColumnTongSL";
            // 
            // ColumnSLPhucVu
            // 
            ColumnSLPhucVu.FillWeight = 68.03777F;
            ColumnSLPhucVu.HeaderText = "SL Phục vụ";
            ColumnSLPhucVu.MinimumWidth = 6;
            ColumnSLPhucVu.Name = "ColumnSLPhucVu";
            // 
            // ColumnSLMuon
            // 
            ColumnSLMuon.FillWeight = 46.5289536F;
            ColumnSLMuon.HeaderText = "Đang mượn";
            ColumnSLMuon.MinimumWidth = 6;
            ColumnSLMuon.Name = "ColumnSLMuon";
            // 
            // ColumnTLTot
            // 
            ColumnTLTot.FillWeight = 46.5289536F;
            ColumnTLTot.HeaderText = "TL Tốt";
            ColumnTLTot.MinimumWidth = 6;
            ColumnTLTot.Name = "ColumnTLTot";
            // 
            // ColumnTLXau
            // 
            ColumnTLXau.FillWeight = 59.53306F;
            ColumnTLXau.HeaderText = "TL Xấu";
            ColumnTLXau.MinimumWidth = 6;
            ColumnTLXau.Name = "ColumnTLXau";
            // 
            // ColumnTLBoiThuong
            // 
            ColumnTLBoiThuong.HeaderText = "TL Bồi thường";
            ColumnTLBoiThuong.MinimumWidth = 6;
            ColumnTLBoiThuong.Name = "ColumnTLBoiThuong";
            // 
            // ColumnTien
            // 
            ColumnTien.HeaderText = "Tiền bồi thường";
            ColumnTien.MinimumWidth = 6;
            ColumnTien.Name = "ColumnTien";
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
            buttonTimKiem.Location = new Point(769, 106);
            buttonTimKiem.Margin = new Padding(3, 4, 3, 4);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(150, 40);
            buttonTimKiem.TabIndex = 29;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = false;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // textBoxTimkiem
            // 
            textBoxTimkiem.Location = new Point(558, 113);
            textBoxTimkiem.Margin = new Padding(3, 4, 3, 4);
            textBoxTimkiem.Name = "textBoxTimkiem";
            textBoxTimkiem.Size = new Size(186, 27);
            textBoxTimkiem.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(449, 115);
            label5.Name = "label5";
            label5.Size = new Size(111, 28);
            label5.TabIndex = 23;
            label5.Text = "Tìm kiếm :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(696, 31);
            label1.TabIndex = 0;
            label1.Text = "Thống kê tình hình phục vụ sách của thư viện (6 tháng gần đây)";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 83, 102);
            panel1.Controls.Add(buttonExport);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1395, 77);
            panel1.TabIndex = 16;
            // 
            // buttonExport
            // 
            buttonExport.BackColor = Color.FromArgb(40, 167, 69);
            buttonExport.FlatAppearance.BorderSize = 0;
            buttonExport.FlatStyle = FlatStyle.Flat;
            buttonExport.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExport.ForeColor = SystemColors.ButtonHighlight;
            buttonExport.Location = new Point(1234, 21);
            buttonExport.Margin = new Padding(3, 4, 3, 4);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(113, 52);
            buttonExport.TabIndex = 31;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = false;
            buttonExport.Click += buttonExport_Click;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewData);
            Controls.Add(buttonTimKiem);
            Controls.Add(textBoxTimkiem);
            Controls.Add(label5);
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
        private TextBox textBoxTimkiem;
        private Label label5;
        private Label label1;
        private Panel panel1;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewImageColumn ColumnTenSach;
        private DataGridViewTextBoxColumn ColumnTen;
        private DataGridViewTextBoxColumn ColumnTongSL;
        private DataGridViewTextBoxColumn ColumnSLPhucVu;
        private DataGridViewTextBoxColumn ColumnSLMuon;
        private DataGridViewTextBoxColumn ColumnTLTot;
        private DataGridViewTextBoxColumn ColumnTLXau;
        private DataGridViewTextBoxColumn ColumnTLBoiThuong;
        private DataGridViewTextBoxColumn ColumnTien;
        private Button buttonExport;
    }
}
