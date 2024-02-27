namespace QLTV.Module.TaiNguyen.TacGia
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
            label2 = new Label();
            label1 = new Label();
            btnTimKiem = new Button();
            txtTimkiem = new TextBox();
            label5 = new Label();
            dgvAuthors = new DataGridView();
            clmId = new DataGridViewTextBoxColumn();
            clmname = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(75, 83, 102);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-278, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1395, 65);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(292, 13);
            label2.Name = "label2";
            label2.Size = new Size(207, 37);
            label2.TabIndex = 1;
            label2.Text = "Quản lý tác giả";
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
            // btnTimKiem
            // 
            btnTimKiem.BackColor = SystemColors.MenuHighlight;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.ForeColor = SystemColors.ButtonFace;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(516, 87);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(150, 51);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(305, 94);
            txtTimkiem.Margin = new Padding(3, 4, 3, 4);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(186, 27);
            txtTimkiem.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(196, 96);
            label5.Name = "label5";
            label5.Size = new Size(111, 28);
            label5.TabIndex = 15;
            label5.Text = "Tìm kiếm :";
            // 
            // dgvAuthors
            // 
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.Columns.AddRange(new DataGridViewColumn[] { clmId, clmname });
            dgvAuthors.Location = new Point(266, 165);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.RowHeadersWidth = 51;
            dgvAuthors.RowTemplate.Height = 29;
            dgvAuthors.Size = new Size(305, 213);
            dgvAuthors.TabIndex = 18;
            // 
            // clmId
            // 
            clmId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            clmId.HeaderText = "Id";
            clmId.MinimumWidth = 6;
            clmId.Name = "clmId";
            clmId.Width = 51;
            // 
            // clmname
            // 
            clmname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmname.HeaderText = "Tên tác giả";
            clmname.MinimumWidth = 6;
            clmname.Name = "clmname";
            // 
            // index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvAuthors);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimkiem);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "index";
            Size = new Size(921, 535);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btnTimKiem;
        private TextBox txtTimkiem;
        private Label label5;
        private DataGridView dgvAuthors;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewTextBoxColumn clmname;
    }
}
