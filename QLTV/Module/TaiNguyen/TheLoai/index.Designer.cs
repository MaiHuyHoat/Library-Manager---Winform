namespace QLTV.Module.TaiNguyen.TheLoai
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
            ColumnTheLoai = new DataGridViewTextBoxColumn();
            buttonTimKiem = new Button();
            button4 = new Button();
            button3 = new Button();
            label3 = new Label();
            label1 = new Label();
            buttonThem = new Button();
            panel1 = new Panel();
            textBoxTimKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewData
            // 
            dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnTheLoai });
            dataGridViewData.Location = new Point(7, 191);
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
            // ColumnTheLoai
            // 
            ColumnTheLoai.FillWeight = 85.04722F;
            ColumnTheLoai.HeaderText = "Thể loại";
            ColumnTheLoai.MinimumWidth = 6;
            ColumnTheLoai.Name = "ColumnTheLoai";
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
            buttonTimKiem.Location = new Point(733, 110);
            buttonTimKiem.Margin = new Padding(3, 4, 3, 4);
            buttonTimKiem.Name = "buttonTimKiem";
            buttonTimKiem.Size = new Size(150, 51);
            buttonTimKiem.TabIndex = 29;
            buttonTimKiem.Text = "Tìm kiếm";
            buttonTimKiem.UseVisualStyleBackColor = false;
            buttonTimKiem.Click += buttonTimKiem_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 0);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(1258, 477);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(113, 52);
            button4.TabIndex = 28;
            button4.Text = "Sửa";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1258, 585);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(113, 52);
            button3.TabIndex = 27;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(315, 121);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 19;
            label3.Text = "Thể loại sách :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(191, 37);
            label1.TabIndex = 0;
            label1.Text = "Thể Loại Sách";
            // 
            // buttonThem
            // 
            buttonThem.BackColor = Color.FromArgb(40, 167, 69);
            buttonThem.FlatAppearance.BorderSize = 0;
            buttonThem.FlatStyle = FlatStyle.Flat;
            buttonThem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonThem.ForeColor = SystemColors.ButtonHighlight;
            buttonThem.Location = new Point(1258, 388);
            buttonThem.Margin = new Padding(3, 4, 3, 4);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(113, 52);
            buttonThem.TabIndex = 25;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
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
            // textBoxTimKiem
            // 
            textBoxTimKiem.Location = new Point(468, 125);
            textBoxTimKiem.Margin = new Padding(3, 4, 3, 4);
            textBoxTimKiem.Name = "textBoxTimKiem";
            textBoxTimKiem.Size = new Size(228, 27);
            textBoxTimKiem.TabIndex = 104;
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxTimKiem);
            Controls.Add(dataGridViewData);
            Controls.Add(buttonTimKiem);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(buttonThem);
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
        private Button button4;
        private Button button3;
        private Label label3;
        private Label label1;
        private Button buttonThem;
        private Panel panel1;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnTheLoai;
        private TextBox textBoxTimKiem;
    }
}
