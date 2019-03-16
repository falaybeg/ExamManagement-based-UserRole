namespace Sinav_Gorevlendirme_Proje
{
    partial class Yonetici_Secimi_Ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetici_Secimi_Ekle));
            this.btn_devam = new FlatUI.FlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_secim = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_devam
            // 
            this.btn_devam.BackColor = System.Drawing.Color.Transparent;
            this.btn_devam.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_devam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_devam.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_devam.Location = new System.Drawing.Point(329, 109);
            this.btn_devam.Name = "btn_devam";
            this.btn_devam.Rounded = false;
            this.btn_devam.Size = new System.Drawing.Size(106, 32);
            this.btn_devam.TabIndex = 1;
            this.btn_devam.Text = "Devam";
            this.btn_devam.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_devam.Click += new System.EventHandler(this.btn_devam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pozisyon Seçiniz : *";
            // 
            // combo_secim
            // 
            this.combo_secim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_secim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_secim.FormattingEnabled = true;
            this.combo_secim.IntegralHeight = false;
            this.combo_secim.Items.AddRange(new object[] {
            "Genel Yönetici",
            "İl Yöneticisi",
            "İl Yardımcısı",
            "İlçe Yöneticisi",
            "Bina Yöneticisi",
            "Bina Yardımcısı",
            "Sınav Sorumlusu"});
            this.combo_secim.Location = new System.Drawing.Point(221, 50);
            this.combo_secim.Name = "combo_secim";
            this.combo_secim.Size = new System.Drawing.Size(214, 28);
            this.combo_secim.TabIndex = 0;
            // 
            // Yonetici_Secimi_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(460, 168);
            this.Controls.Add(this.btn_devam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_secim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Yonetici_Secimi_Ekle";
            this.Text = "Yonetici Secimi";
            this.Load += new System.EventHandler(this.Yonetici_Secimi_Ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatUI.FlatButton btn_devam;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox combo_secim;
    }
}