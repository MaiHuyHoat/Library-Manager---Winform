namespace QLTV.Module.TaiNguyen.NhaXuatBan
{
    partial class add
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button3 = new Button();
            buttonThem = new Button();
            textBoxTen = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLight;
            button3.Location = new Point(333, 228);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(94, 47);
            button3.TabIndex = 107;
            button3.Text = "Huỷ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // buttonThem
            // 
            buttonThem.BackColor = Color.DarkGreen;
            buttonThem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonThem.ForeColor = SystemColors.ButtonHighlight;
            buttonThem.Location = new Point(-174, 291);
            buttonThem.Margin = new Padding(3, 4, 3, 4);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(91, 47);
            buttonThem.TabIndex = 106;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = false;
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(221, 129);
            textBoxTen.Margin = new Padding(3, 4, 3, 4);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(228, 27);
            textBoxTen.TabIndex = 105;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(-189, 197);
            label2.Name = "label2";
            label2.Size = new Size(106, 23);
            label2.TabIndex = 104;
            label2.Text = "Tên tác giả :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 123, 255);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 61);
            panel1.TabIndex = 103;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(195, 28);
            label1.TabIndex = 0;
            label1.Text = "Thêm nhà xuất bản";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(138, 228);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(91, 47);
            button1.TabIndex = 108;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(59, 130);
            label3.Name = "label3";
            label3.Size = new Size(151, 23);
            label3.TabIndex = 109;
            label3.Text = "Tên nhà xuất bản:";
            // 
            // add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 403);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(buttonThem);
            Controls.Add(textBoxTen);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "add";
            Text = "add";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button buttonThem;
        private TextBox textBoxTen;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Label label3;
    }
}