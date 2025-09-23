namespace NDP_SozlukSinavi
{
    partial class Form2
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
            lblSoruDurum = new Label();
            lblPuan = new Label();
            lblKelime = new Label();
            btnSecenek1 = new Button();
            btnSecenek2 = new Button();
            btnSecenek3 = new Button();
            btnSecenek4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblSoruDurum
            // 
            lblSoruDurum.AutoSize = true;
            lblSoruDurum.BackColor = Color.MediumTurquoise;
            lblSoruDurum.Font = new Font("Segoe UI", 9F);
            lblSoruDurum.ForeColor = Color.Black;
            lblSoruDurum.Location = new Point(26, 18);
            lblSoruDurum.Name = "lblSoruDurum";
            lblSoruDurum.Size = new Size(50, 20);
            lblSoruDurum.TabIndex = 4;
            lblSoruDurum.Text = "label1";
            lblSoruDurum.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPuan
            // 
            lblPuan.AutoSize = true;
            lblPuan.BackColor = Color.MediumTurquoise;
            lblPuan.ForeColor = Color.Black;
            lblPuan.Location = new Point(483, 18);
            lblPuan.Name = "lblPuan";
            lblPuan.Size = new Size(50, 20);
            lblPuan.TabIndex = 5;
            lblPuan.Text = "label1";
            lblPuan.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblKelime
            // 
            lblKelime.AutoSize = true;
            lblKelime.BackColor = Color.DarkCyan;
            lblKelime.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblKelime.ForeColor = SystemColors.Control;
            lblKelime.Location = new Point(234, 12);
            lblKelime.Name = "lblKelime";
            lblKelime.Size = new Size(64, 28);
            lblKelime.TabIndex = 6;
            lblKelime.Text = "label1";
            lblKelime.TextAlign = ContentAlignment.MiddleCenter;
            lblKelime.Click += lblKelime_Click;
            // 
            // btnSecenek1
            // 
            btnSecenek1.Location = new Point(135, 176);
            btnSecenek1.Name = "btnSecenek1";
            btnSecenek1.Size = new Size(94, 29);
            btnSecenek1.TabIndex = 7;
            btnSecenek1.Text = "button1";
            btnSecenek1.UseVisualStyleBackColor = true;
            // 
            // btnSecenek2
            // 
            btnSecenek2.Location = new Point(341, 172);
            btnSecenek2.Name = "btnSecenek2";
            btnSecenek2.Size = new Size(94, 29);
            btnSecenek2.TabIndex = 8;
            btnSecenek2.Text = "button2";
            btnSecenek2.UseVisualStyleBackColor = true;
            // 
            // btnSecenek3
            // 
            btnSecenek3.Location = new Point(136, 256);
            btnSecenek3.Name = "btnSecenek3";
            btnSecenek3.Size = new Size(94, 29);
            btnSecenek3.TabIndex = 9;
            btnSecenek3.Text = "button3";
            btnSecenek3.UseVisualStyleBackColor = true;
            // 
            // btnSecenek4
            // 
            btnSecenek4.Location = new Point(341, 256);
            btnSecenek4.Name = "btnSecenek4";
            btnSecenek4.Size = new Size(94, 29);
            btnSecenek4.TabIndex = 10;
            btnSecenek4.Text = "button4";
            btnSecenek4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 176);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 11;
            label1.Text = "A";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 176);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 12;
            label2.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 260);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 13;
            label3.Text = "C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 260);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 14;
            label4.Text = "E";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumTurquoise;
            panel1.Controls.Add(lblSoruDurum);
            panel1.Controls.Add(lblPuan);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 52);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(lblKelime);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(586, 56);
            panel2.TabIndex = 16;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(586, 355);
            Controls.Add(btnSecenek4);
            Controls.Add(btnSecenek1);
            Controls.Add(btnSecenek2);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnSecenek3);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            Text = "Çokten Seçmeli Sınavı";
            TransparencyKey = Color.White;
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSoruDurum;
        private Label lblPuan;
        private Label lblKelime;
        private Button btnSecenek1;
        private Button btnSecenek2;
        private Button btnSecenek3;
        private Button btnSecenek4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
    }
}