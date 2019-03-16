namespace Sinav_Gorevlendirme_Proje
{
    partial class Bina_Okul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bina_Okul));
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tab_adresBilgi = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_bina_FaxNo = new System.Windows.Forms.TextBox();
            this.txt_bina_CepNO = new System.Windows.Forms.TextBox();
            this.txt_bina_Telefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_kaydetBinaBilgiler = new System.Windows.Forms.Button();
            this.imglist_kaydet = new System.Windows.Forms.ImageList(this.components);
            this.groupBox_Adres = new System.Windows.Forms.GroupBox();
            this.combo_sokak_no = new System.Windows.Forms.ComboBox();
            this.txt_BinaAdi = new System.Windows.Forms.TextBox();
            this.lbl_binaAdi = new System.Windows.Forms.Label();
            this.txt_bina_sokak = new System.Windows.Forms.TextBox();
            this.txt_bina_cadde = new System.Windows.Forms.TextBox();
            this.txt_okulBina_Acik_Adres = new System.Windows.Forms.TextBox();
            this.lbl_bina_AcikAdres = new System.Windows.Forms.Label();
            this.lbl_sokak_no = new System.Windows.Forms.Label();
            this.lbl_sokak = new System.Windows.Forms.Label();
            this.lbl_cadde = new System.Windows.Forms.Label();
            this.combo_bina_semt = new System.Windows.Forms.ComboBox();
            this.combo_bina_ilce = new System.Windows.Forms.ComboBox();
            this.combo_bina_il = new System.Windows.Forms.ComboBox();
            this.lbl_il = new System.Windows.Forms.Label();
            this.lbl_ilce = new System.Windows.Forms.Label();
            this.lbl_semt = new System.Windows.Forms.Label();
            this.tabPage_bina_yonetici_bilgi = new System.Windows.Forms.TabPage();
            this.btn_bina_Yonetici_kaydi = new System.Windows.Forms.Button();
            this.groupBox_yonetici = new System.Windows.Forms.GroupBox();
            this.combobox_binaAdi_Sec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combobox_Bina_Yonetici_Yardimcisi = new System.Windows.Forms.ComboBox();
            this.combobox_Bina_Yoneticisi = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Bina_Yonetici_ekle = new System.Windows.Forms.Button();
            this.imagelis_resimYukle = new System.Windows.Forms.ImageList(this.components);
            this.groupBox_katBilgi = new System.Windows.Forms.GroupBox();
            this.txt_sinif_Sayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combobox_OkulBina_KatSayi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flatTabControl1.SuspendLayout();
            this.tab_adresBilgi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Adres.SuspendLayout();
            this.tabPage_bina_yonetici_bilgi.SuspendLayout();
            this.groupBox_yonetici.SuspendLayout();
            this.groupBox_katBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tab_adresBilgi);
            this.flatTabControl1.Controls.Add(this.tabPage_bina_yonetici_bilgi);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(-1, 0);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(645, 677);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 0;
            // 
            // tab_adresBilgi
            // 
            this.tab_adresBilgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tab_adresBilgi.Controls.Add(this.groupBox1);
            this.tab_adresBilgi.Controls.Add(this.btn_kaydetBinaBilgiler);
            this.tab_adresBilgi.Controls.Add(this.groupBox_Adres);
            this.tab_adresBilgi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_adresBilgi.Location = new System.Drawing.Point(4, 44);
            this.tab_adresBilgi.Name = "tab_adresBilgi";
            this.tab_adresBilgi.Padding = new System.Windows.Forms.Padding(3);
            this.tab_adresBilgi.Size = new System.Drawing.Size(637, 629);
            this.tab_adresBilgi.TabIndex = 0;
            this.tab_adresBilgi.Text = "Adress ve Iletisim Bilgileri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_bina_FaxNo);
            this.groupBox1.Controls.Add(this.txt_bina_CepNO);
            this.groupBox1.Controls.Add(this.txt_bina_Telefon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(14, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 184);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telefon Bilgileri";
            // 
            // txt_bina_FaxNo
            // 
            this.txt_bina_FaxNo.Location = new System.Drawing.Point(161, 129);
            this.txt_bina_FaxNo.MaxLength = 15;
            this.txt_bina_FaxNo.Multiline = true;
            this.txt_bina_FaxNo.Name = "txt_bina_FaxNo";
            this.txt_bina_FaxNo.Size = new System.Drawing.Size(223, 29);
            this.txt_bina_FaxNo.TabIndex = 10;
            // 
            // txt_bina_CepNO
            // 
            this.txt_bina_CepNO.Location = new System.Drawing.Point(161, 78);
            this.txt_bina_CepNO.MaxLength = 15;
            this.txt_bina_CepNO.Multiline = true;
            this.txt_bina_CepNO.Name = "txt_bina_CepNO";
            this.txt_bina_CepNO.Size = new System.Drawing.Size(223, 29);
            this.txt_bina_CepNO.TabIndex = 9;
            // 
            // txt_bina_Telefon
            // 
            this.txt_bina_Telefon.Location = new System.Drawing.Point(161, 28);
            this.txt_bina_Telefon.MaxLength = 15;
            this.txt_bina_Telefon.Multiline = true;
            this.txt_bina_Telefon.Name = "txt_bina_Telefon";
            this.txt_bina_Telefon.Size = new System.Drawing.Size(223, 29);
            this.txt_bina_Telefon.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fax NO : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cep NO : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon NO : *";
            // 
            // btn_kaydetBinaBilgiler
            // 
            this.btn_kaydetBinaBilgiler.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kaydetBinaBilgiler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_kaydetBinaBilgiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydetBinaBilgiler.ImageIndex = 0;
            this.btn_kaydetBinaBilgiler.ImageList = this.imglist_kaydet;
            this.btn_kaydetBinaBilgiler.Location = new System.Drawing.Point(497, 563);
            this.btn_kaydetBinaBilgiler.Name = "btn_kaydetBinaBilgiler";
            this.btn_kaydetBinaBilgiler.Size = new System.Drawing.Size(127, 47);
            this.btn_kaydetBinaBilgiler.TabIndex = 11;
            this.btn_kaydetBinaBilgiler.Text = "       KAYDET";
            this.btn_kaydetBinaBilgiler.UseVisualStyleBackColor = true;
            this.btn_kaydetBinaBilgiler.Click += new System.EventHandler(this.btn_kaydetBinaBilgiler_Click);
            // 
            // imglist_kaydet
            // 
            this.imglist_kaydet.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist_kaydet.ImageStream")));
            this.imglist_kaydet.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist_kaydet.Images.SetKeyName(0, "1469243214_savesda.ico");
            // 
            // groupBox_Adres
            // 
            this.groupBox_Adres.Controls.Add(this.combo_sokak_no);
            this.groupBox_Adres.Controls.Add(this.txt_BinaAdi);
            this.groupBox_Adres.Controls.Add(this.lbl_binaAdi);
            this.groupBox_Adres.Controls.Add(this.txt_bina_sokak);
            this.groupBox_Adres.Controls.Add(this.txt_bina_cadde);
            this.groupBox_Adres.Controls.Add(this.txt_okulBina_Acik_Adres);
            this.groupBox_Adres.Controls.Add(this.lbl_bina_AcikAdres);
            this.groupBox_Adres.Controls.Add(this.lbl_sokak_no);
            this.groupBox_Adres.Controls.Add(this.lbl_sokak);
            this.groupBox_Adres.Controls.Add(this.lbl_cadde);
            this.groupBox_Adres.Controls.Add(this.combo_bina_semt);
            this.groupBox_Adres.Controls.Add(this.combo_bina_ilce);
            this.groupBox_Adres.Controls.Add(this.combo_bina_il);
            this.groupBox_Adres.Controls.Add(this.lbl_il);
            this.groupBox_Adres.Controls.Add(this.lbl_ilce);
            this.groupBox_Adres.Controls.Add(this.lbl_semt);
            this.groupBox_Adres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Adres.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox_Adres.Location = new System.Drawing.Point(14, 6);
            this.groupBox_Adres.Name = "groupBox_Adres";
            this.groupBox_Adres.Size = new System.Drawing.Size(604, 407);
            this.groupBox_Adres.TabIndex = 26;
            this.groupBox_Adres.TabStop = false;
            // 
            // combo_sokak_no
            // 
            this.combo_sokak_no.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_sokak_no.FormattingEnabled = true;
            this.combo_sokak_no.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.combo_sokak_no.Location = new System.Drawing.Point(470, 213);
            this.combo_sokak_no.Name = "combo_sokak_no";
            this.combo_sokak_no.Size = new System.Drawing.Size(85, 28);
            this.combo_sokak_no.TabIndex = 5;
            // 
            // txt_BinaAdi
            // 
            this.txt_BinaAdi.Location = new System.Drawing.Point(134, 261);
            this.txt_BinaAdi.MaxLength = 100;
            this.txt_BinaAdi.Name = "txt_BinaAdi";
            this.txt_BinaAdi.Size = new System.Drawing.Size(211, 27);
            this.txt_BinaAdi.TabIndex = 6;
            // 
            // lbl_binaAdi
            // 
            this.lbl_binaAdi.AutoSize = true;
            this.lbl_binaAdi.Location = new System.Drawing.Point(26, 264);
            this.lbl_binaAdi.Name = "lbl_binaAdi";
            this.lbl_binaAdi.Size = new System.Drawing.Size(87, 20);
            this.lbl_binaAdi.TabIndex = 22;
            this.lbl_binaAdi.Text = "Bina Adı : *";
            // 
            // txt_bina_sokak
            // 
            this.txt_bina_sokak.Location = new System.Drawing.Point(134, 213);
            this.txt_bina_sokak.MaxLength = 100;
            this.txt_bina_sokak.Name = "txt_bina_sokak";
            this.txt_bina_sokak.Size = new System.Drawing.Size(211, 27);
            this.txt_bina_sokak.TabIndex = 4;
            // 
            // txt_bina_cadde
            // 
            this.txt_bina_cadde.Location = new System.Drawing.Point(134, 169);
            this.txt_bina_cadde.MaxLength = 100;
            this.txt_bina_cadde.Name = "txt_bina_cadde";
            this.txt_bina_cadde.Size = new System.Drawing.Size(211, 27);
            this.txt_bina_cadde.TabIndex = 3;
            // 
            // txt_okulBina_Acik_Adres
            // 
            this.txt_okulBina_Acik_Adres.Location = new System.Drawing.Point(232, 303);
            this.txt_okulBina_Acik_Adres.MaxLength = 500;
            this.txt_okulBina_Acik_Adres.Multiline = true;
            this.txt_okulBina_Acik_Adres.Name = "txt_okulBina_Acik_Adres";
            this.txt_okulBina_Acik_Adres.Size = new System.Drawing.Size(343, 85);
            this.txt_okulBina_Acik_Adres.TabIndex = 7;
            // 
            // lbl_bina_AcikAdres
            // 
            this.lbl_bina_AcikAdres.AutoSize = true;
            this.lbl_bina_AcikAdres.Location = new System.Drawing.Point(26, 358);
            this.lbl_bina_AcikAdres.Name = "lbl_bina_AcikAdres";
            this.lbl_bina_AcikAdres.Size = new System.Drawing.Size(189, 20);
            this.lbl_bina_AcikAdres.TabIndex = 18;
            this.lbl_bina_AcikAdres.Text = "Okul / Bina Açık Adresi : *";
            // 
            // lbl_sokak_no
            // 
            this.lbl_sokak_no.AutoSize = true;
            this.lbl_sokak_no.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_sokak_no.Location = new System.Drawing.Point(394, 220);
            this.lbl_sokak_no.Name = "lbl_sokak_no";
            this.lbl_sokak_no.Size = new System.Drawing.Size(70, 20);
            this.lbl_sokak_no.TabIndex = 17;
            this.lbl_sokak_no.Text = "Sokak  :  ";
            // 
            // lbl_sokak
            // 
            this.lbl_sokak.AutoSize = true;
            this.lbl_sokak.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_sokak.Location = new System.Drawing.Point(26, 217);
            this.lbl_sokak.Name = "lbl_sokak";
            this.lbl_sokak.Size = new System.Drawing.Size(70, 20);
            this.lbl_sokak.TabIndex = 15;
            this.lbl_sokak.Text = "Sokak  :  ";
            // 
            // lbl_cadde
            // 
            this.lbl_cadde.AutoSize = true;
            this.lbl_cadde.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_cadde.Location = new System.Drawing.Point(26, 172);
            this.lbl_cadde.Name = "lbl_cadde";
            this.lbl_cadde.Size = new System.Drawing.Size(72, 20);
            this.lbl_cadde.TabIndex = 13;
            this.lbl_cadde.Text = "Cadde  :  ";
            // 
            // combo_bina_semt
            // 
            this.combo_bina_semt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_bina_semt.FormattingEnabled = true;
            this.combo_bina_semt.Location = new System.Drawing.Point(134, 122);
            this.combo_bina_semt.Name = "combo_bina_semt";
            this.combo_bina_semt.Size = new System.Drawing.Size(211, 28);
            this.combo_bina_semt.TabIndex = 2;
            this.combo_bina_semt.SelectedIndexChanged += new System.EventHandler(this.combo_bina_semt_SelectedIndexChanged);
            // 
            // combo_bina_ilce
            // 
            this.combo_bina_ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_bina_ilce.FormattingEnabled = true;
            this.combo_bina_ilce.Location = new System.Drawing.Point(134, 77);
            this.combo_bina_ilce.Name = "combo_bina_ilce";
            this.combo_bina_ilce.Size = new System.Drawing.Size(211, 28);
            this.combo_bina_ilce.TabIndex = 1;
            this.combo_bina_ilce.SelectedIndexChanged += new System.EventHandler(this.combo_bina_ilce_SelectedIndexChanged);
            // 
            // combo_bina_il
            // 
            this.combo_bina_il.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_bina_il.FormattingEnabled = true;
            this.combo_bina_il.Location = new System.Drawing.Point(134, 32);
            this.combo_bina_il.Name = "combo_bina_il";
            this.combo_bina_il.Size = new System.Drawing.Size(211, 28);
            this.combo_bina_il.TabIndex = 0;
            this.combo_bina_il.SelectedIndexChanged += new System.EventHandler(this.combo_bina_il_SelectedIndexChanged);
            // 
            // lbl_il
            // 
            this.lbl_il.AutoSize = true;
            this.lbl_il.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_il.Location = new System.Drawing.Point(26, 32);
            this.lbl_il.Name = "lbl_il";
            this.lbl_il.Size = new System.Drawing.Size(80, 20);
            this.lbl_il.TabIndex = 11;
            this.lbl_il.Text = "İl seçiniz : ";
            // 
            // lbl_ilce
            // 
            this.lbl_ilce.AutoSize = true;
            this.lbl_ilce.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_ilce.Location = new System.Drawing.Point(26, 81);
            this.lbl_ilce.Name = "lbl_ilce";
            this.lbl_ilce.Size = new System.Drawing.Size(45, 20);
            this.lbl_ilce.TabIndex = 2;
            this.lbl_ilce.Text = "İlçe  :";
            // 
            // lbl_semt
            // 
            this.lbl_semt.AutoSize = true;
            this.lbl_semt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_semt.Location = new System.Drawing.Point(26, 125);
            this.lbl_semt.Name = "lbl_semt";
            this.lbl_semt.Size = new System.Drawing.Size(68, 20);
            this.lbl_semt.TabIndex = 4;
            this.lbl_semt.Text = "Semt  : *";
            // 
            // tabPage_bina_yonetici_bilgi
            // 
            this.tabPage_bina_yonetici_bilgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage_bina_yonetici_bilgi.Controls.Add(this.btn_bina_Yonetici_kaydi);
            this.tabPage_bina_yonetici_bilgi.Controls.Add(this.groupBox_yonetici);
            this.tabPage_bina_yonetici_bilgi.Controls.Add(this.groupBox_katBilgi);
            this.tabPage_bina_yonetici_bilgi.Location = new System.Drawing.Point(4, 44);
            this.tabPage_bina_yonetici_bilgi.Name = "tabPage_bina_yonetici_bilgi";
            this.tabPage_bina_yonetici_bilgi.Size = new System.Drawing.Size(637, 629);
            this.tabPage_bina_yonetici_bilgi.TabIndex = 2;
            this.tabPage_bina_yonetici_bilgi.Text = "Kat ve Yönetici Bilgileri";
            // 
            // btn_bina_Yonetici_kaydi
            // 
            this.btn_bina_Yonetici_kaydi.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bina_Yonetici_kaydi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_bina_Yonetici_kaydi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bina_Yonetici_kaydi.ImageIndex = 0;
            this.btn_bina_Yonetici_kaydi.ImageList = this.imglist_kaydet;
            this.btn_bina_Yonetici_kaydi.Location = new System.Drawing.Point(468, 513);
            this.btn_bina_Yonetici_kaydi.Name = "btn_bina_Yonetici_kaydi";
            this.btn_bina_Yonetici_kaydi.Size = new System.Drawing.Size(145, 48);
            this.btn_bina_Yonetici_kaydi.TabIndex = 29;
            this.btn_bina_Yonetici_kaydi.Text = "       KAYDET";
            this.btn_bina_Yonetici_kaydi.UseVisualStyleBackColor = true;
            this.btn_bina_Yonetici_kaydi.Click += new System.EventHandler(this.btn_bina_Yonetici_kaydi_Click);
            // 
            // groupBox_yonetici
            // 
            this.groupBox_yonetici.Controls.Add(this.combobox_binaAdi_Sec);
            this.groupBox_yonetici.Controls.Add(this.label1);
            this.groupBox_yonetici.Controls.Add(this.combobox_Bina_Yonetici_Yardimcisi);
            this.groupBox_yonetici.Controls.Add(this.combobox_Bina_Yoneticisi);
            this.groupBox_yonetici.Controls.Add(this.label12);
            this.groupBox_yonetici.Controls.Add(this.label13);
            this.groupBox_yonetici.Controls.Add(this.btn_Bina_Yonetici_ekle);
            this.groupBox_yonetici.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_yonetici.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_yonetici.Location = new System.Drawing.Point(20, 37);
            this.groupBox_yonetici.Name = "groupBox_yonetici";
            this.groupBox_yonetici.Size = new System.Drawing.Size(593, 222);
            this.groupBox_yonetici.TabIndex = 1;
            this.groupBox_yonetici.TabStop = false;
            this.groupBox_yonetici.Text = "Bina ve Yönetici Bilgileri";
            // 
            // combobox_binaAdi_Sec
            // 
            this.combobox_binaAdi_Sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_binaAdi_Sec.FormattingEnabled = true;
            this.combobox_binaAdi_Sec.Location = new System.Drawing.Point(241, 48);
            this.combobox_binaAdi_Sec.Name = "combobox_binaAdi_Sec";
            this.combobox_binaAdi_Sec.Size = new System.Drawing.Size(232, 33);
            this.combobox_binaAdi_Sec.TabIndex = 34;
            this.combobox_binaAdi_Sec.SelectedIndexChanged += new System.EventHandler(this.combobox_binaAdi_Sec_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(118, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Bina Adi : *";
            // 
            // combobox_Bina_Yonetici_Yardimcisi
            // 
            this.combobox_Bina_Yonetici_Yardimcisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_Bina_Yonetici_Yardimcisi.FormattingEnabled = true;
            this.combobox_Bina_Yonetici_Yardimcisi.Location = new System.Drawing.Point(241, 153);
            this.combobox_Bina_Yonetici_Yardimcisi.Name = "combobox_Bina_Yonetici_Yardimcisi";
            this.combobox_Bina_Yonetici_Yardimcisi.Size = new System.Drawing.Size(232, 33);
            this.combobox_Bina_Yonetici_Yardimcisi.TabIndex = 30;
            this.combobox_Bina_Yonetici_Yardimcisi.SelectedIndexChanged += new System.EventHandler(this.combobox_Bina_Yonetici_Yardimcisi_SelectedIndexChanged);
            // 
            // combobox_Bina_Yoneticisi
            // 
            this.combobox_Bina_Yoneticisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_Bina_Yoneticisi.FormattingEnabled = true;
            this.combobox_Bina_Yoneticisi.Location = new System.Drawing.Point(241, 104);
            this.combobox_Bina_Yoneticisi.Name = "combobox_Bina_Yoneticisi";
            this.combobox_Bina_Yoneticisi.Size = new System.Drawing.Size(232, 33);
            this.combobox_Bina_Yoneticisi.TabIndex = 29;
            this.combobox_Bina_Yoneticisi.SelectedIndexChanged += new System.EventHandler(this.combobox_Bina_Yoneticisi_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(13, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 21);
            this.label12.TabIndex = 28;
            this.label12.Text = "Bina Yönetici Yardımcısı : *";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(81, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 21);
            this.label13.TabIndex = 27;
            this.label13.Text = "Bina Yöneticisi : *";
            // 
            // btn_Bina_Yonetici_ekle
            // 
            this.btn_Bina_Yonetici_ekle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bina_Yonetici_ekle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Bina_Yonetici_ekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Bina_Yonetici_ekle.ImageIndex = 0;
            this.btn_Bina_Yonetici_ekle.ImageList = this.imagelis_resimYukle;
            this.btn_Bina_Yonetici_ekle.Location = new System.Drawing.Point(484, 116);
            this.btn_Bina_Yonetici_ekle.Name = "btn_Bina_Yonetici_ekle";
            this.btn_Bina_Yonetici_ekle.Size = new System.Drawing.Size(84, 68);
            this.btn_Bina_Yonetici_ekle.TabIndex = 13;
            this.btn_Bina_Yonetici_ekle.Text = "Yeni Ekle";
            this.btn_Bina_Yonetici_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Bina_Yonetici_ekle.UseVisualStyleBackColor = true;
            this.btn_Bina_Yonetici_ekle.Click += new System.EventHandler(this.btn_Bina_Yonetici_ekle_Click);
            // 
            // imagelis_resimYukle
            // 
            this.imagelis_resimYukle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelis_resimYukle.ImageStream")));
            this.imagelis_resimYukle.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelis_resimYukle.Images.SetKeyName(0, "add new stuff.ico");
            // 
            // groupBox_katBilgi
            // 
            this.groupBox_katBilgi.Controls.Add(this.txt_sinif_Sayisi);
            this.groupBox_katBilgi.Controls.Add(this.label2);
            this.groupBox_katBilgi.Controls.Add(this.combobox_OkulBina_KatSayi);
            this.groupBox_katBilgi.Controls.Add(this.label8);
            this.groupBox_katBilgi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_katBilgi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_katBilgi.Location = new System.Drawing.Point(26, 312);
            this.groupBox_katBilgi.Name = "groupBox_katBilgi";
            this.groupBox_katBilgi.Size = new System.Drawing.Size(426, 249);
            this.groupBox_katBilgi.TabIndex = 0;
            this.groupBox_katBilgi.TabStop = false;
            this.groupBox_katBilgi.Text = "Kat ve Sinif Bilgileri";
            // 
            // txt_sinif_Sayisi
            // 
            this.txt_sinif_Sayisi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sinif_Sayisi.ForeColor = System.Drawing.Color.DimGray;
            this.txt_sinif_Sayisi.Location = new System.Drawing.Point(279, 145);
            this.txt_sinif_Sayisi.MaxLength = 3;
            this.txt_sinif_Sayisi.Multiline = true;
            this.txt_sinif_Sayisi.Name = "txt_sinif_Sayisi";
            this.txt_sinif_Sayisi.Size = new System.Drawing.Size(105, 27);
            this.txt_sinif_Sayisi.TabIndex = 34;
            this.txt_sinif_Sayisi.Text = "Sayı Giriniz..";
            this.txt_sinif_Sayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sinif_Sayisi.Click += new System.EventHandler(this.txt_sinif_Sayisi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(81, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Sinif Sayisi : *";
            // 
            // combobox_OkulBina_KatSayi
            // 
            this.combobox_OkulBina_KatSayi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_OkulBina_KatSayi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_OkulBina_KatSayi.FormattingEnabled = true;
            this.combobox_OkulBina_KatSayi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.combobox_OkulBina_KatSayi.Location = new System.Drawing.Point(231, 105);
            this.combobox_OkulBina_KatSayi.Name = "combobox_OkulBina_KatSayi";
            this.combobox_OkulBina_KatSayi.Size = new System.Drawing.Size(153, 29);
            this.combobox_OkulBina_KatSayi.TabIndex = 28;
            this.combobox_OkulBina_KatSayi.SelectedIndexChanged += new System.EventHandler(this.combobox_OkulBina_KatSayi_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(13, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Okul/Bina Kat Sayısı : *";
            // 
            // Bina_Okul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 677);
            this.Controls.Add(this.flatTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bina_Okul";
            this.Text = "Bina Okul Kaydı";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Bina_Okul_Load);
            this.flatTabControl1.ResumeLayout(false);
            this.tab_adresBilgi.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Adres.ResumeLayout(false);
            this.groupBox_Adres.PerformLayout();
            this.tabPage_bina_yonetici_bilgi.ResumeLayout(false);
            this.groupBox_yonetici.ResumeLayout(false);
            this.groupBox_yonetici.PerformLayout();
            this.groupBox_katBilgi.ResumeLayout(false);
            this.groupBox_katBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_adresBilgi;
        private System.Windows.Forms.ComboBox combo_bina_semt;
        private System.Windows.Forms.ComboBox combo_bina_ilce;
        private System.Windows.Forms.ComboBox combo_bina_il;
        private System.Windows.Forms.Label lbl_il;
        private System.Windows.Forms.Label lbl_ilce;
        private System.Windows.Forms.Label lbl_semt;
        private System.Windows.Forms.TextBox txt_okulBina_Acik_Adres;
        private System.Windows.Forms.Label lbl_bina_AcikAdres;
        private System.Windows.Forms.Label lbl_sokak_no;
        private System.Windows.Forms.Label lbl_sokak;
        private System.Windows.Forms.Label lbl_cadde;
        private System.Windows.Forms.ImageList imglist_kaydet;
        private System.Windows.Forms.Button btn_bina_Yonetici_kaydi;
        private System.Windows.Forms.ComboBox combobox_OkulBina_KatSayi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Bina_Yonetici_ekle;
        private System.Windows.Forms.ImageList imagelis_resimYukle;
        private System.Windows.Forms.ComboBox combobox_Bina_Yonetici_Yardimcisi;
        private System.Windows.Forms.ComboBox combobox_Bina_Yoneticisi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.GroupBox groupBox_yonetici;
        public System.Windows.Forms.GroupBox groupBox_katBilgi;
        public System.Windows.Forms.TabPage tabPage_bina_yonetici_bilgi;
        public FlatUI.FlatTabControl flatTabControl1;
        public System.Windows.Forms.Button btn_kaydetBinaBilgiler;
        public System.Windows.Forms.GroupBox groupBox_Adres;
        private System.Windows.Forms.TextBox txt_bina_sokak;
        private System.Windows.Forms.TextBox txt_bina_cadde;
        private System.Windows.Forms.TextBox txt_BinaAdi;
        private System.Windows.Forms.Label lbl_binaAdi;
        public System.Windows.Forms.ComboBox combo_sokak_no;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_bina_FaxNo;
        private System.Windows.Forms.TextBox txt_bina_CepNO;
        private System.Windows.Forms.TextBox txt_bina_Telefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combobox_binaAdi_Sec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sinif_Sayisi;
        private System.Windows.Forms.Label label2;
    }
}