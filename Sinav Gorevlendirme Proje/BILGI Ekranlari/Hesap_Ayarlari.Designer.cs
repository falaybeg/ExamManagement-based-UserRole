namespace Sinav_Gorevlendirme_Proje
{
    partial class Hesap_Ayarlari
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hesap_Ayarlari));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_eskiSifre = new System.Windows.Forms.TextBox();
            this.txt_yeniSifre = new System.Windows.Forms.TextBox();
            this.txt_yeniSifre2 = new System.Windows.Forms.TextBox();
            this.check_sifreGoste = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eski  Şifreniz : *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yeni  Şifreniz : *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni  Şifreniz  : *";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.ImageIndex = 2;
            this.btn_update.ImageList = this.imageList1;
            this.btn_update.Location = new System.Drawing.Point(222, 219);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(132, 41);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "     UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1469349853_save.ico");
            this.imageList1.Images.SetKeyName(1, "delte.png");
            this.imageList1.Images.SetKeyName(2, "update.ico");
            this.imageList1.Images.SetKeyName(3, "1469350363_find.ico");
            this.imageList1.Images.SetKeyName(4, "1469351211_broom_stick_3.ico");
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.ImageIndex = 4;
            this.btn_clear.ImageList = this.imageList1;
            this.btn_clear.Location = new System.Drawing.Point(74, 219);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(132, 41);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_eskiSifre
            // 
            this.txt_eskiSifre.BackColor = System.Drawing.SystemColors.Control;
            this.txt_eskiSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eskiSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_eskiSifre.Location = new System.Drawing.Point(169, 17);
            this.txt_eskiSifre.Multiline = true;
            this.txt_eskiSifre.Name = "txt_eskiSifre";
            this.txt_eskiSifre.PasswordChar = '●';
            this.txt_eskiSifre.Size = new System.Drawing.Size(185, 32);
            this.txt_eskiSifre.TabIndex = 0;
            // 
            // txt_yeniSifre
            // 
            this.txt_yeniSifre.BackColor = System.Drawing.SystemColors.Control;
            this.txt_yeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_yeniSifre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_yeniSifre.Location = new System.Drawing.Point(169, 86);
            this.txt_yeniSifre.Multiline = true;
            this.txt_yeniSifre.Name = "txt_yeniSifre";
            this.txt_yeniSifre.PasswordChar = '●';
            this.txt_yeniSifre.Size = new System.Drawing.Size(185, 32);
            this.txt_yeniSifre.TabIndex = 1;
            // 
            // txt_yeniSifre2
            // 
            this.txt_yeniSifre2.BackColor = System.Drawing.SystemColors.Control;
            this.txt_yeniSifre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_yeniSifre2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_yeniSifre2.Location = new System.Drawing.Point(169, 128);
            this.txt_yeniSifre2.Multiline = true;
            this.txt_yeniSifre2.Name = "txt_yeniSifre2";
            this.txt_yeniSifre2.PasswordChar = '●';
            this.txt_yeniSifre2.Size = new System.Drawing.Size(185, 32);
            this.txt_yeniSifre2.TabIndex = 2;
            // 
            // check_sifreGoste
            // 
            this.check_sifreGoste.AutoSize = true;
            this.check_sifreGoste.BackColor = System.Drawing.Color.DimGray;
            this.check_sifreGoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_sifreGoste.Location = new System.Drawing.Point(169, 176);
            this.check_sifreGoste.Name = "check_sifreGoste";
            this.check_sifreGoste.Size = new System.Drawing.Size(122, 24);
            this.check_sifreGoste.TabIndex = 15;
            this.check_sifreGoste.Text = "  Şifre Göster";
            this.check_sifreGoste.UseVisualStyleBackColor = false;
            this.check_sifreGoste.CheckedChanged += new System.EventHandler(this.check_sifreGoste_CheckedChanged);
            // 
            // Hesap_Ayarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(382, 278);
            this.Controls.Add(this.check_sifreGoste);
            this.Controls.Add(this.txt_yeniSifre2);
            this.Controls.Add(this.txt_yeniSifre);
            this.Controls.Add(this.txt_eskiSifre);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hesap_Ayarlari";
            this.Text = "Şifre Güncelle";
            this.Load += new System.EventHandler(this.Hesap_Ayarlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_eskiSifre;
        private System.Windows.Forms.TextBox txt_yeniSifre;
        private System.Windows.Forms.TextBox txt_yeniSifre2;
        private System.Windows.Forms.CheckBox check_sifreGoste;
    }
}