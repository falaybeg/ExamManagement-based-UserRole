namespace Sinav_Gorevlendirme_Proje
{
    partial class kullanici_Ekran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanici_Ekran));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_PanelYonetici = new System.Windows.Forms.Label();
            this.pictureBox_logOUT = new System.Windows.Forms.PictureBox();
            this.btn_kullaniciIslemler = new System.Windows.Forms.Button();
            this.imageList_anaMenu = new System.Windows.Forms.ImageList(this.components);
            this.btn_sinavIslem = new System.Windows.Forms.Button();
            this.panel_Personel = new System.Windows.Forms.Panel();
            this.btn_sinavDetay = new System.Windows.Forms.Button();
            this.btn_binaOkul = new System.Windows.Forms.Button();
            this.btn_sehirler = new System.Windows.Forms.Button();
            this.lbl_kullanici = new System.Windows.Forms.Label();
            this.btn_gorevliOnay = new System.Windows.Forms.Button();
            this.lbl_cikis = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hesapAyarlar_MenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreGüncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapBilgilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTextDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_effekt = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_saatim = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.microsoftOfficeWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logOUT)).BeginInit();
            this.panel_Personel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_PanelYonetici
            // 
            this.lbl_PanelYonetici.AutoSize = true;
            this.lbl_PanelYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PanelYonetici.Location = new System.Drawing.Point(46, 12);
            this.lbl_PanelYonetici.Name = "lbl_PanelYonetici";
            this.lbl_PanelYonetici.Size = new System.Drawing.Size(183, 25);
            this.lbl_PanelYonetici.TabIndex = 26;
            this.lbl_PanelYonetici.Text = "Kullanıcı Ekranı ";
            // 
            // pictureBox_logOUT
            // 
            this.pictureBox_logOUT.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_logOUT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_logOUT.BackgroundImage")));
            this.pictureBox_logOUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_logOUT.Location = new System.Drawing.Point(48, 415);
            this.pictureBox_logOUT.Name = "pictureBox_logOUT";
            this.pictureBox_logOUT.Size = new System.Drawing.Size(70, 58);
            this.pictureBox_logOUT.TabIndex = 27;
            this.pictureBox_logOUT.TabStop = false;
            this.pictureBox_logOUT.Click += new System.EventHandler(this.pictureBox_logOUT_Click_1);
            // 
            // btn_kullaniciIslemler
            // 
            this.btn_kullaniciIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kullaniciIslemler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kullaniciIslemler.ImageIndex = 1;
            this.btn_kullaniciIslemler.ImageList = this.imageList_anaMenu;
            this.btn_kullaniciIslemler.Location = new System.Drawing.Point(-4, 224);
            this.btn_kullaniciIslemler.Name = "btn_kullaniciIslemler";
            this.btn_kullaniciIslemler.Size = new System.Drawing.Size(175, 75);
            this.btn_kullaniciIslemler.TabIndex = 21;
            this.btn_kullaniciIslemler.Text = "Kullanıcı  \r\n İşlemleri";
            this.btn_kullaniciIslemler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kullaniciIslemler.UseVisualStyleBackColor = true;
            this.btn_kullaniciIslemler.Click += new System.EventHandler(this.btn_kullaniciIslemler_Click_1);
            // 
            // imageList_anaMenu
            // 
            this.imageList_anaMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_anaMenu.ImageStream")));
            this.imageList_anaMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_anaMenu.Images.SetKeyName(0, "bina.ico");
            this.imageList_anaMenu.Images.SetKeyName(1, "kullanici_ayarlar.ico");
            this.imageList_anaMenu.Images.SetKeyName(2, "Location-256.ico");
            this.imageList_anaMenu.Images.SetKeyName(3, "onay.ico");
            this.imageList_anaMenu.Images.SetKeyName(4, "Program Icon.ico");
            this.imageList_anaMenu.Images.SetKeyName(5, "badge-512.png");
            this.imageList_anaMenu.Images.SetKeyName(6, "Oxygen-Icons.org-Oxygen-Actions-document-edit.ico");
            this.imageList_anaMenu.Images.SetKeyName(7, "country.png");
            // 
            // btn_sinavIslem
            // 
            this.btn_sinavIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sinavIslem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sinavIslem.ImageIndex = 4;
            this.btn_sinavIslem.ImageList = this.imageList_anaMenu;
            this.btn_sinavIslem.Location = new System.Drawing.Point(-3, 149);
            this.btn_sinavIslem.Name = "btn_sinavIslem";
            this.btn_sinavIslem.Size = new System.Drawing.Size(175, 75);
            this.btn_sinavIslem.TabIndex = 20;
            this.btn_sinavIslem.Text = "Sınav  \r\nİşlemleri";
            this.btn_sinavIslem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sinavIslem.UseVisualStyleBackColor = true;
            this.btn_sinavIslem.Click += new System.EventHandler(this.btn_sinavIslem_Click_1);
            // 
            // panel_Personel
            // 
            this.panel_Personel.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Personel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_Personel.BackgroundImage")));
            this.panel_Personel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Personel.Controls.Add(this.btn_sinavDetay);
            this.panel_Personel.Controls.Add(this.btn_binaOkul);
            this.panel_Personel.Controls.Add(this.btn_sehirler);
            this.panel_Personel.Controls.Add(this.lbl_kullanici);
            this.panel_Personel.Controls.Add(this.btn_gorevliOnay);
            this.panel_Personel.Controls.Add(this.lbl_cikis);
            this.panel_Personel.Controls.Add(this.pictureBox_logOUT);
            this.panel_Personel.Controls.Add(this.btn_kullaniciIslemler);
            this.panel_Personel.Controls.Add(this.btn_sinavIslem);
            this.panel_Personel.Location = new System.Drawing.Point(2, 52);
            this.panel_Personel.Name = "panel_Personel";
            this.panel_Personel.Size = new System.Drawing.Size(175, 567);
            this.panel_Personel.TabIndex = 25;
            this.panel_Personel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Personel_Paint);
            // 
            // btn_sinavDetay
            // 
            this.btn_sinavDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sinavDetay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sinavDetay.ImageIndex = 6;
            this.btn_sinavDetay.ImageList = this.imageList_anaMenu;
            this.btn_sinavDetay.Location = new System.Drawing.Point(-2, 379);
            this.btn_sinavDetay.Name = "btn_sinavDetay";
            this.btn_sinavDetay.Size = new System.Drawing.Size(166, 35);
            this.btn_sinavDetay.TabIndex = 37;
            this.btn_sinavDetay.Text = "    Sınav \r\n          Bilgisi";
            this.btn_sinavDetay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sinavDetay.UseVisualStyleBackColor = true;
            this.btn_sinavDetay.Click += new System.EventHandler(this.btn_sinavDetay_Click);
            // 
            // btn_binaOkul
            // 
            this.btn_binaOkul.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_binaOkul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_binaOkul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_binaOkul.ImageIndex = 0;
            this.btn_binaOkul.ImageList = this.imageList_anaMenu;
            this.btn_binaOkul.Location = new System.Drawing.Point(-2, 74);
            this.btn_binaOkul.Name = "btn_binaOkul";
            this.btn_binaOkul.Size = new System.Drawing.Size(175, 75);
            this.btn_binaOkul.TabIndex = 36;
            this.btn_binaOkul.Text = "Bina / Okul\r\nİşlemleri";
            this.btn_binaOkul.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_binaOkul.UseVisualStyleBackColor = true;
            this.btn_binaOkul.Click += new System.EventHandler(this.btn_binaOkul_Click);
            // 
            // btn_sehirler
            // 
            this.btn_sehirler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sehirler.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sehirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sehirler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sehirler.ImageIndex = 7;
            this.btn_sehirler.ImageList = this.imageList_anaMenu;
            this.btn_sehirler.Location = new System.Drawing.Point(-1, -1);
            this.btn_sehirler.Name = "btn_sehirler";
            this.btn_sehirler.Size = new System.Drawing.Size(175, 75);
            this.btn_sehirler.TabIndex = 35;
            this.btn_sehirler.Text = "  \rİl/ilçe  \r\nİşlemleri";
            this.btn_sehirler.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_sehirler.UseVisualStyleBackColor = true;
            this.btn_sehirler.Click += new System.EventHandler(this.btn_sehirler_Click);
            // 
            // lbl_kullanici
            // 
            this.lbl_kullanici.AutoSize = true;
            this.lbl_kullanici.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kullanici.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lbl_kullanici.Location = new System.Drawing.Point(3, 514);
            this.lbl_kullanici.Name = "lbl_kullanici";
            this.lbl_kullanici.Size = new System.Drawing.Size(46, 20);
            this.lbl_kullanici.TabIndex = 34;
            this.lbl_kullanici.Text = "user";
            // 
            // btn_gorevliOnay
            // 
            this.btn_gorevliOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gorevliOnay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gorevliOnay.ImageIndex = 3;
            this.btn_gorevliOnay.ImageList = this.imageList_anaMenu;
            this.btn_gorevliOnay.Location = new System.Drawing.Point(-4, 299);
            this.btn_gorevliOnay.Name = "btn_gorevliOnay";
            this.btn_gorevliOnay.Size = new System.Drawing.Size(175, 75);
            this.btn_gorevliOnay.TabIndex = 29;
            this.btn_gorevliOnay.Text = "Sınav\r\n Görevliler";
            this.btn_gorevliOnay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_gorevliOnay.UseVisualStyleBackColor = true;
            this.btn_gorevliOnay.Click += new System.EventHandler(this.btn_gorevliOnay_Click);
            // 
            // lbl_cikis
            // 
            this.lbl_cikis.AutoSize = true;
            this.lbl_cikis.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cikis.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_cikis.Location = new System.Drawing.Point(59, 476);
            this.lbl_cikis.Name = "lbl_cikis";
            this.lbl_cikis.Size = new System.Drawing.Size(47, 20);
            this.lbl_cikis.TabIndex = 28;
            this.lbl_cikis.Text = "Çıkış";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapAyarlar_MenuItem1,
            this.toolsToolStripMenuItem,
            this.yardimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1219, 26);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hesapAyarlar_MenuItem1
            // 
            this.hesapAyarlar_MenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreGüncellemeToolStripMenuItem,
            this.hesapBilgilerToolStripMenuItem});
            this.hesapAyarlar_MenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hesapAyarlar_MenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("hesapAyarlar_MenuItem1.Image")));
            this.hesapAyarlar_MenuItem1.Name = "hesapAyarlar_MenuItem1";
            this.hesapAyarlar_MenuItem1.Size = new System.Drawing.Size(128, 22);
            this.hesapAyarlar_MenuItem1.Text = "Hesap Ayarları";
            // 
            // şifreGüncellemeToolStripMenuItem
            // 
            this.şifreGüncellemeToolStripMenuItem.Name = "şifreGüncellemeToolStripMenuItem";
            this.şifreGüncellemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.şifreGüncellemeToolStripMenuItem.Text = "Şifre Güncelleme";
            this.şifreGüncellemeToolStripMenuItem.Click += new System.EventHandler(this.şifreGüncellemeToolStripMenuItem_Click);
            // 
            // hesapBilgilerToolStripMenuItem
            // 
            this.hesapBilgilerToolStripMenuItem.Name = "hesapBilgilerToolStripMenuItem";
            this.hesapBilgilerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hesapBilgilerToolStripMenuItem.Text = "Hesap Bilgisi";
            this.hesapBilgilerToolStripMenuItem.Click += new System.EventHandler(this.hesapBilgilerToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTextDocumentToolStripMenuItem,
            this.microsoftOfficeWordToolStripMenuItem,
            this.microsoftExcelToolStripMenuItem});
            this.toolsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolsToolStripMenuItem.Image")));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.toolsToolStripMenuItem.Text = "Araçlar";
            // 
            // newTextDocumentToolStripMenuItem
            // 
            this.newTextDocumentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newTextDocumentToolStripMenuItem.Image")));
            this.newTextDocumentToolStripMenuItem.Name = "newTextDocumentToolStripMenuItem";
            this.newTextDocumentToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.newTextDocumentToolStripMenuItem.Text = "NewTextDocument";
            this.newTextDocumentToolStripMenuItem.Click += new System.EventHandler(this.newTextDocumentToolStripMenuItem_Click);
            // 
            // yardimToolStripMenuItem
            // 
            this.yardimToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yardimToolStripMenuItem.Image")));
            this.yardimToolStripMenuItem.Name = "yardimToolStripMenuItem";
            this.yardimToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.yardimToolStripMenuItem.Text = "Yardım";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbl_saatim);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_PanelYonetici);
            this.panel1.Controls.Add(this.panel_Personel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 620);
            this.panel1.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1170, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 28);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_saatim
            // 
            this.lbl_saatim.AutoSize = true;
            this.lbl_saatim.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saatim.Location = new System.Drawing.Point(1050, 11);
            this.lbl_saatim.Name = "lbl_saatim";
            this.lbl_saatim.Size = new System.Drawing.Size(130, 29);
            this.lbl_saatim.TabIndex = 35;
            this.lbl_saatim.Text = "saat : saat";
            this.lbl_saatim.Click += new System.EventHandler(this.lbl_saatim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(173, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1046, 564);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // microsoftOfficeWordToolStripMenuItem
            // 
            this.microsoftOfficeWordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("microsoftOfficeWordToolStripMenuItem.Image")));
            this.microsoftOfficeWordToolStripMenuItem.Name = "microsoftOfficeWordToolStripMenuItem";
            this.microsoftOfficeWordToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.microsoftOfficeWordToolStripMenuItem.Text = "Microsoft Word";
            this.microsoftOfficeWordToolStripMenuItem.Click += new System.EventHandler(this.microsoftOfficeWordToolStripMenuItem_Click);
            // 
            // microsoftExcelToolStripMenuItem
            // 
            this.microsoftExcelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("microsoftExcelToolStripMenuItem.Image")));
            this.microsoftExcelToolStripMenuItem.Name = "microsoftExcelToolStripMenuItem";
            this.microsoftExcelToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.microsoftExcelToolStripMenuItem.Text = "Microsoft Excel";
            this.microsoftExcelToolStripMenuItem.Click += new System.EventHandler(this.microsoftExcelToolStripMenuItem_Click);
            // 
            // kullanici_Ekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 646);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kullanici_Ekran";
            this.Text = "Kullanıcı Yönetim Ekranı";
            this.Load += new System.EventHandler(this.kullanici_Ekran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logOUT)).EndInit();
            this.panel_Personel.ResumeLayout(false);
            this.panel_Personel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_PanelYonetici;
        private System.Windows.Forms.ImageList imageList_anaMenu;
        private System.Windows.Forms.Panel panel_Personel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTextDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardimToolStripMenuItem;
        private System.Windows.Forms.Timer timer_effekt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_saatim;
        public System.Windows.Forms.Button btn_sehirler;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem hesapAyarlar_MenuItem1;
        private System.Windows.Forms.ToolStripMenuItem şifreGüncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapBilgilerToolStripMenuItem;
        public System.Windows.Forms.Button btn_kullaniciIslemler;
        public System.Windows.Forms.Button btn_sinavIslem;
        public System.Windows.Forms.Button btn_gorevliOnay;
        public System.Windows.Forms.Button btn_binaOkul;
        public System.Windows.Forms.Button btn_sinavDetay;
        public System.Windows.Forms.PictureBox pictureBox_logOUT;
        public System.Windows.Forms.Label lbl_cikis;
        public System.Windows.Forms.Label lbl_kullanici;
        private System.Windows.Forms.ToolStripMenuItem microsoftOfficeWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftExcelToolStripMenuItem;


    }
}