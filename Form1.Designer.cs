namespace NDP_SozlukSinavi
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
            lstSozlukler = new ListBox();
            btnYukle = new Button();
            btnBaslat = new Button();
            label1 = new Label();
            btnCikis = new Button();
            SuspendLayout();
            // 
            // lstSozlukler
            // 
            lstSozlukler.FormattingEnabled = true;
            lstSozlukler.Location = new Point(12, 62);
            lstSozlukler.Name = "lstSozlukler";
            lstSozlukler.Size = new Size(473, 124);
            lstSozlukler.TabIndex = 0;
            lstSozlukler.SelectedIndexChanged += lstSozlukler_SelectedIndexChanged;
            // 
            // btnYukle
            // 
            btnYukle.Location = new Point(12, 225);
            btnYukle.Name = "btnYukle";
            btnYukle.Size = new Size(94, 29);
            btnYukle.TabIndex = 1;
            btnYukle.Text = "Yükle";
            btnYukle.UseVisualStyleBackColor = true;
            btnYukle.Click += btnYukle_Click;
            // 
            // btnBaslat
            // 
            btnBaslat.Enabled = false;
            btnBaslat.Location = new Point(143, 225);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(94, 29);
            btnBaslat.TabIndex = 2;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 3;
            label1.Text = "Sözcükler";
            label1.Click += label1_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(290, 225);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(94, 29);
            btnCikis.TabIndex = 4;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(497, 317);
            Controls.Add(btnCikis);
            Controls.Add(label1);
            Controls.Add(btnBaslat);
            Controls.Add(btnYukle);
            Controls.Add(lstSozlukler);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Kelime Ezber";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSozlukler;
        private Button btnYukle;
        private Button btnBaslat;
        private Label label1;
        private Button btnCikis;
    }
}
