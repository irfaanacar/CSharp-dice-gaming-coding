namespace Zaratma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Poor Richard", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 49);
            label1.Name = "label1";
            label1.Size = new Size(152, 38);
            label1.TabIndex = 0;
            label1.Text = "1. Oyuncu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Poor Richard", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(340, 49);
            label2.Name = "label2";
            label2.Size = new Size(160, 38);
            label2.TabIndex = 1;
            label2.Text = "2. Oyuncu";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Poor Richard", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(214, 293);
            button1.Name = "button1";
            button1.Size = new Size(140, 85);
            button1.TabIndex = 2;
            button1.Text = "Zar At!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poor Richard", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(270, 104);
            label3.Name = "label3";
            label3.Size = new Size(32, 38);
            label3.TabIndex = 3;
            label3.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(132, 104);
            label4.Name = "label4";
            label4.Size = new Size(36, 38);
            label4.TabIndex = 4;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poor Richard", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(412, 104);
            label5.Name = "label5";
            label5.Size = new Size(36, 38);
            label5.TabIndex = 5;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Oswald", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(383, 293);
            label6.Name = "label6";
            label6.Size = new Size(114, 39);
            label6.TabIndex = 6;
            label6.Text = "1. Oyuncu:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Font = new Font("Oswald", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(383, 339);
            label8.Name = "label8";
            label8.Size = new Size(117, 39);
            label8.TabIndex = 8;
            label8.Text = "2. Oyuncu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 192, 192);
            label7.Font = new Font("Oswald", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(497, 293);
            label7.Name = "label7";
            label7.Size = new Size(30, 39);
            label7.TabIndex = 9;
            label7.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(255, 192, 192);
            label9.Font = new Font("Oswald", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(497, 339);
            label9.Name = "label9";
            label9.Size = new Size(30, 39);
            label9.TabIndex = 10;
            label9.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 486);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label9;
    }
}