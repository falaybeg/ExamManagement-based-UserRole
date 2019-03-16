namespace Sinav_Gorevlendirme_Proje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.iconlar = new System.Windows.Forms.ImageList(this.components);
            this.timer_saat = new System.Windows.Forms.Timer(this.components);
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_guvenlikKodu = new FlatUI.FlatTextBox();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.check_sifreGoste = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sifreUret = new System.Windows.Forms.TextBox();
            this.lbl_sifreUnuttum = new System.Windows.Forms.Label();
            this.userTXT = new FlatUI.FlatTextBox();
            this.passTXT = new FlatUI.FlatTextBox();
            this.passLBL = new System.Windows.Forms.Label();
            this.Giris_button = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.userLBL = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconlar
            // 
            this.iconlar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconlar.ImageStream")));
            this.iconlar.TransparentColor = System.Drawing.Color.Transparent;
            this.iconlar.Images.SetKeyName(0, "1466351955_sign-check.ico");
            this.iconlar.Images.SetKeyName(1, "1466351960_sign-error.ico");
            // 
            // timer_saat
            // 
            this.timer_saat.Enabled = true;
            this.timer_saat.Tick += new System.EventHandler(this.timer_saat_Tick);
            // 
            // minimize
            // 
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(260, 7);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(26, 24);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize.TabIndex = 24;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(286, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(36, 34);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 23;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.txt_guvenlikKodu);
            this.groupBox1.Controls.Add(this.btn_yenile);
            this.groupBox1.Controls.Add(this.check_sifreGoste);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_sifreUret);
            this.groupBox1.Controls.Add(this.lbl_sifreUnuttum);
            this.groupBox1.Controls.Add(this.userTXT);
            this.groupBox1.Controls.Add(this.passTXT);
            this.groupBox1.Controls.Add(this.passLBL);
            this.groupBox1.Controls.Add(this.Giris_button);
            this.groupBox1.Controls.Add(this.exit);
            this.groupBox1.Controls.Add(this.userLBL);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(12, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 276);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // txt_guvenlikKodu
            // 
            this.txt_guvenlikKodu.BackColor = System.Drawing.Color.Transparent;
            this.txt_guvenlikKodu.FocusOnHover = false;
            this.txt_guvenlikKodu.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guvenlikKodu.Location = new System.Drawing.Point(181, 158);
            this.txt_guvenlikKodu.MaxLength = 11;
            this.txt_guvenlikKodu.Multiline = false;
            this.txt_guvenlikKodu.Name = "txt_guvenlikKodu";
            this.txt_guvenlikKodu.ReadOnly = false;
            this.txt_guvenlikKodu.Size = new System.Drawing.Size(105, 30);
            this.txt_guvenlikKodu.TabIndex = 10;
            this.txt_guvenlikKodu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_guvenlikKodu.TextColor = System.Drawing.Color.White;
            this.txt_guvenlikKodu.UseSystemPasswordChar = false;
            // 
            // btn_yenile
            // 
            this.btn_yenile.ImageIndex = 0;
            this.btn_yenile.ImageList = this.imageList2;
            this.btn_yenile.Location = new System.Drawing.Point(136, 160);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(25, 27);
            this.btn_yenile.TabIndex = 6;
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "update.ico");
            // 
            // check_sifreGoste
            // 
            this.check_sifreGoste.AutoSize = true;
            this.check_sifreGoste.BackColor = System.Drawing.Color.Transparent;
            this.check_sifreGoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_sifreGoste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.check_sifreGoste.Location = new System.Drawing.Point(152, 110);
            this.check_sifreGoste.Name = "check_sifreGoste";
            this.check_sifreGoste.Size = new System.Drawing.Size(136, 24);
            this.check_sifreGoste.TabIndex = 7;
            this.check_sifreGoste.Text = "  Şifre Göster";
            this.check_sifreGoste.UseVisualStyleBackColor = false;
            this.check_sifreGoste.CheckedChanged += new System.EventHandler(this.check_sifreGoste_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Güvenlik Kodu :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txt_sifreUret
            // 
            this.txt_sifreUret.BackColor = System.Drawing.Color.DimGray;
            this.txt_sifreUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sifreUret.ForeColor = System.Drawing.Color.Yellow;
            this.txt_sifreUret.Location = new System.Drawing.Point(14, 160);
            this.txt_sifreUret.Multiline = true;
            this.txt_sifreUret.Name = "txt_sifreUret";
            this.txt_sifreUret.Size = new System.Drawing.Size(122, 28);
            this.txt_sifreUret.TabIndex = 7;
            this.txt_sifreUret.Text = "123456789";
            this.txt_sifreUret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_sifreUnuttum
            // 
            this.lbl_sifreUnuttum.AutoSize = true;
            this.lbl_sifreUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sifreUnuttum.ForeColor = System.Drawing.Color.Blue;
            this.lbl_sifreUnuttum.Location = new System.Drawing.Point(171, 252);
            this.lbl_sifreUnuttum.Name = "lbl_sifreUnuttum";
            this.lbl_sifreUnuttum.Size = new System.Drawing.Size(115, 16);
            this.lbl_sifreUnuttum.TabIndex = 5;
            this.lbl_sifreUnuttum.Text = "Şifremi Unuttum";
            this.lbl_sifreUnuttum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // userTXT
            // 
            this.userTXT.BackColor = System.Drawing.Color.Transparent;
            this.userTXT.FocusOnHover = false;
            this.userTXT.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTXT.Location = new System.Drawing.Point(117, 33);
            this.userTXT.MaxLength = 11;
            this.userTXT.Multiline = false;
            this.userTXT.Name = "userTXT";
            this.userTXT.ReadOnly = false;
            this.userTXT.Size = new System.Drawing.Size(171, 29);
            this.userTXT.TabIndex = 0;
            this.userTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userTXT.TextColor = System.Drawing.Color.White;
            this.userTXT.UseSystemPasswordChar = false;
            // 
            // passTXT
            // 
            this.passTXT.BackColor = System.Drawing.Color.Transparent;
            this.passTXT.FocusOnHover = false;
            this.passTXT.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTXT.Location = new System.Drawing.Point(117, 77);
            this.passTXT.MaxLength = 18;
            this.passTXT.Multiline = false;
            this.passTXT.Name = "passTXT";
            this.passTXT.ReadOnly = false;
            this.passTXT.Size = new System.Drawing.Size(171, 27);
            this.passTXT.TabIndex = 1;
            this.passTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passTXT.TextColor = System.Drawing.Color.White;
            this.passTXT.UseSystemPasswordChar = true;
            // 
            // passLBL
            // 
            this.passLBL.AutoSize = true;
            this.passLBL.BackColor = System.Drawing.Color.Transparent;
            this.passLBL.Font = new System.Drawing.Font("Adobe Heiti Std R", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.passLBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passLBL.Location = new System.Drawing.Point(55, 84);
            this.passLBL.Name = "passLBL";
            this.passLBL.Size = new System.Drawing.Size(49, 19);
            this.passLBL.TabIndex = 5;
            this.passLBL.Text = "Sifre :";
            // 
            // Giris_button
            // 
            this.Giris_button.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Giris_button.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Giris_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Giris_button.ImageIndex = 0;
            this.Giris_button.ImageList = this.iconlar;
            this.Giris_button.Location = new System.Drawing.Point(104, 199);
            this.Giris_button.Name = "Giris_button";
            this.Giris_button.Size = new System.Drawing.Size(81, 40);
            this.Giris_button.TabIndex = 3;
            this.Giris_button.Text = "Giris ";
            this.Giris_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Giris_button.UseVisualStyleBackColor = false;
            this.Giris_button.Click += new System.EventHandler(this.Giris_button_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.ImageIndex = 1;
            this.exit.ImageList = this.iconlar;
            this.exit.Location = new System.Drawing.Point(200, 199);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 39);
            this.exit.TabIndex = 4;
            this.exit.Text = "    Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // userLBL
            // 
            this.userLBL.AutoSize = true;
            this.userLBL.BackColor = System.Drawing.Color.Transparent;
            this.userLBL.Font = new System.Drawing.Font("Adobe Heiti Std R", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userLBL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userLBL.Location = new System.Drawing.Point(7, 41);
            this.userLBL.Name = "userLBL";
            this.userLBL.Size = new System.Drawing.Size(104, 19);
            this.userLBL.TabIndex = 4;
            this.userLBL.Text = "Kullanıcı Adı :";
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saat.ForeColor = System.Drawing.Color.White;
            this.lbl_saat.Location = new System.Drawing.Point(238, 460);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(65, 25);
            this.lbl_saat.TabIndex = 28;
            this.lbl_saat.Text = "label1";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tarih.ForeColor = System.Drawing.Color.White;
            this.lbl_tarih.Location = new System.Drawing.Point(9, 460);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(65, 25);
            this.lbl_tarih.TabIndex = 26;
            this.lbl_tarih.Text = "label2";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1471267315_Admin.ico");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(102, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 132);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(335, 490);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList iconlar;
        private System.Windows.Forms.Timer timer_saat;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox1;
        public FlatUI.FlatTextBox userTXT;
        private System.Windows.Forms.Label passLBL;
        private System.Windows.Forms.Button Giris_button;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label userLBL;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.ImageList imageList1;
        public FlatUI.FlatTextBox passTXT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_sifreUnuttum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sifreUret;
        private System.Windows.Forms.CheckBox check_sifreGoste;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.ImageList imageList2;
        public FlatUI.FlatTextBox txt_guvenlikKodu;
    }
}

