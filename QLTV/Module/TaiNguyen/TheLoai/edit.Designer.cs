﻿namespace QLTV.Module.TaiNguyen.TheLoai
{
    partial class edit
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
            buttonThem = new Button();
            button3 = new Button();
            label5 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            textBoxTen = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonThem
            // 
            buttonThem.BackColor = Color.DarkGreen;
            buttonThem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonThem.ForeColor = SystemColors.ButtonHighlight;
            buttonThem.Location = new Point(98, 199);
            buttonThem.Margin = new Padding(3, 4, 3, 4);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(91, 47);
            buttonThem.TabIndex = 85;
            buttonThem.Text = "Cập nhật";
            buttonThem.UseVisualStyleBackColor = false;
            buttonThem.Click += buttonThem_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLight;
            button3.Location = new Point(257, 199);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(94, 47);
            button3.TabIndex = 84;
            button3.Text = "Huỷ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(64, 121);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 82;
            label5.Text = "Thể loại :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 123, 255);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 65);
            panel1.TabIndex = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(137, 18);
            label1.Name = "label1";
            label1.Size = new Size(231, 28);
            label1.TabIndex = 0;
            label1.Text = "Chỉnh sửa thể loại sách";
            // 
            // textBoxTen
            // 
            textBoxTen.Location = new Point(153, 117);
            textBoxTen.Margin = new Padding(3, 4, 3, 4);
            textBoxTen.Name = "textBoxTen";
            textBoxTen.Size = new Size(228, 27);
            textBoxTen.TabIndex = 104;
            // 
            // edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(497, 350);
            Controls.Add(textBoxTen);
            Controls.Add(buttonThem);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonThem;
        private Button button3;
        private Label label5;
        private Panel panel1;
        private Label label1;
        private TextBox textBoxTen;
    }
}