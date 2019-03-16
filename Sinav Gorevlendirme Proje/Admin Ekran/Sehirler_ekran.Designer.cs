namespace Sinav_Gorevlendirme_Proje
{
    partial class Sehirler_ekran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sehirler_ekran));
            this.openFileDialog_KimlikBelge = new System.Windows.Forms.OpenFileDialog();
            this.imagelis_resimYukle = new System.Windows.Forms.ImageList(this.components);
            this.imglist_kaydet = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog_vesikalik = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog_kontratBelge = new System.Windows.Forms.OpenFileDialog();
            this.tab_il = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_il_guncelle = new System.Windows.Forms.Button();
            this.btn_il_ekle = new System.Windows.Forms.Button();
            this.imageList_il_ilce = new System.Windows.Forms.ImageList(this.components);
            this.combo_iller = new System.Windows.Forms.ComboBox();
            this.lbl_Il = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TabControl_ILilce = new FlatUI.FlatTabControl();
            this.tab_ilce = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ilce_guncelle = new System.Windows.Forms.Button();
            this.btn_semt_ekle = new System.Windows.Forms.Button();
            this.btn_ilce_Ekle = new System.Windows.Forms.Button();
            this.comboBox_semt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_ilce = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_il.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TabControl_ILilce.SuspendLayout();
            this.tab_ilce.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_KimlikBelge
            // 
            this.openFileDialog_KimlikBelge.FileName = "openFileDialog1";
            // 
            // imagelis_resimYukle
            // 
            this.imagelis_resimYukle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelis_resimYukle.ImageStream")));
            this.imagelis_resimYukle.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelis_resimYukle.Images.SetKeyName(0, "add new stuff.ico");
            // 
            // imglist_kaydet
            // 
            this.imglist_kaydet.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist_kaydet.ImageStream")));
            this.imglist_kaydet.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist_kaydet.Images.SetKeyName(0, "1469243214_savesda.ico");
            this.imglist_kaydet.Images.SetKeyName(1, "update.ico");
            // 
            // openFileDialog_vesikalik
            // 
            this.openFileDialog_vesikalik.FileName = "openFileDialog1";
            // 
            // openFileDialog_kontratBelge
            // 
            this.openFileDialog_kontratBelge.FileName = "openFileDialog1";
            // 
            // tab_il
            // 
            this.tab_il.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tab_il.Controls.Add(this.groupBox1);
            this.tab_il.Controls.Add(this.label4);
            this.tab_il.Location = new System.Drawing.Point(4, 44);
            this.tab_il.Name = "tab_il";
            this.tab_il.Padding = new System.Windows.Forms.Padding(3);
            this.tab_il.Size = new System.Drawing.Size(523, 344);
            this.tab_il.TabIndex = 0;
            this.tab_il.Text = "İl Kaydı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_il_guncelle);
            this.groupBox1.Controls.Add(this.btn_il_ekle);
            this.groupBox1.Controls.Add(this.combo_iller);
            this.groupBox1.Controls.Add(this.lbl_Il);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(11, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 236);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İl Kaydı";
            // 
            // btn_il_guncelle
            // 
            this.btn_il_guncelle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_il_guncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_il_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_il_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_il_guncelle.ImageIndex = 1;
            this.btn_il_guncelle.ImageList = this.imglist_kaydet;
            this.btn_il_guncelle.Location = new System.Drawing.Point(350, 173);
            this.btn_il_guncelle.Name = "btn_il_guncelle";
            this.btn_il_guncelle.Size = new System.Drawing.Size(134, 41);
            this.btn_il_guncelle.TabIndex = 14;
            this.btn_il_guncelle.Text = "        IL GÜNCELLE";
            this.btn_il_guncelle.UseVisualStyleBackColor = false;
            this.btn_il_guncelle.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_il_ekle
            // 
            this.btn_il_ekle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_il_ekle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_il_ekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_il_ekle.ImageIndex = 0;
            this.btn_il_ekle.ImageList = this.imageList_il_ilce;
            this.btn_il_ekle.Location = new System.Drawing.Point(398, 83);
            this.btn_il_ekle.Name = "btn_il_ekle";
            this.btn_il_ekle.Size = new System.Drawing.Size(86, 47);
            this.btn_il_ekle.TabIndex = 13;
            this.btn_il_ekle.Text = " İl Ekle";
            this.btn_il_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_il_ekle.UseVisualStyleBackColor = true;
            this.btn_il_ekle.Click += new System.EventHandler(this.btn_il_ekle_Click);
            // 
            // imageList_il_ilce
            // 
            this.imageList_il_ilce.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_il_ilce.ImageStream")));
            this.imageList_il_ilce.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_il_ilce.Images.SetKeyName(0, "il_ilce.ico");
            // 
            // combo_iller
            // 
            this.combo_iller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_iller.FormattingEnabled = true;
            this.combo_iller.Items.AddRange(new object[] {
            "Istanbul",
            "Ankara"});
            this.combo_iller.Location = new System.Drawing.Point(164, 94);
            this.combo_iller.Name = "combo_iller";
            this.combo_iller.Size = new System.Drawing.Size(211, 28);
            this.combo_iller.TabIndex = 0;
            this.combo_iller.SelectedIndexChanged += new System.EventHandler(this.combo_iller_SelectedIndexChanged);
            // 
            // lbl_Il
            // 
            this.lbl_Il.AutoSize = true;
            this.lbl_Il.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Il.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Il.Location = new System.Drawing.Point(24, 96);
            this.lbl_Il.Name = "lbl_Il";
            this.lbl_Il.Size = new System.Drawing.Size(95, 21);
            this.lbl_Il.TabIndex = 11;
            this.lbl_Il.Text = "İl seçiniz : *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(252, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 23;
            // 
            // TabControl_ILilce
            // 
            this.TabControl_ILilce.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.TabControl_ILilce.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.TabControl_ILilce.Controls.Add(this.tab_il);
            this.TabControl_ILilce.Controls.Add(this.tab_ilce);
            this.TabControl_ILilce.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl_ILilce.ItemSize = new System.Drawing.Size(120, 40);
            this.TabControl_ILilce.Location = new System.Drawing.Point(1, 1);
            this.TabControl_ILilce.Name = "TabControl_ILilce";
            this.TabControl_ILilce.SelectedIndex = 0;
            this.TabControl_ILilce.Size = new System.Drawing.Size(531, 392);
            this.TabControl_ILilce.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl_ILilce.TabIndex = 2;
            // 
            // tab_ilce
            // 
            this.tab_ilce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tab_ilce.Controls.Add(this.groupBox2);
            this.tab_ilce.Location = new System.Drawing.Point(4, 44);
            this.tab_ilce.Name = "tab_ilce";
            this.tab_ilce.Size = new System.Drawing.Size(523, 344);
            this.tab_ilce.TabIndex = 1;
            this.tab_ilce.Text = "İlçe Kaydı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ilce_guncelle);
            this.groupBox2.Controls.Add(this.btn_semt_ekle);
            this.groupBox2.Controls.Add(this.btn_ilce_Ekle);
            this.groupBox2.Controls.Add(this.comboBox_semt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_ilce);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(10, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 249);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Kaydı";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_ilce_guncelle
            // 
            this.btn_ilce_guncelle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_ilce_guncelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ilce_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_ilce_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ilce_guncelle.ImageIndex = 1;
            this.btn_ilce_guncelle.ImageList = this.imglist_kaydet;
            this.btn_ilce_guncelle.Location = new System.Drawing.Point(347, 188);
            this.btn_ilce_guncelle.Name = "btn_ilce_guncelle";
            this.btn_ilce_guncelle.Size = new System.Drawing.Size(147, 41);
            this.btn_ilce_guncelle.TabIndex = 18;
            this.btn_ilce_guncelle.Text = "        ILCE GÜNCELLE";
            this.btn_ilce_guncelle.UseVisualStyleBackColor = false;
            this.btn_ilce_guncelle.Click += new System.EventHandler(this.btn_ilce_guncelle_Click);
            // 
            // btn_semt_ekle
            // 
            this.btn_semt_ekle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_semt_ekle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_semt_ekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_semt_ekle.ImageIndex = 0;
            this.btn_semt_ekle.ImageList = this.imageList_il_ilce;
            this.btn_semt_ekle.Location = new System.Drawing.Point(409, 125);
            this.btn_semt_ekle.Name = "btn_semt_ekle";
            this.btn_semt_ekle.Size = new System.Drawing.Size(86, 44);
            this.btn_semt_ekle.TabIndex = 17;
            this.btn_semt_ekle.Text = "Semt Ekle";
            this.btn_semt_ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_semt_ekle.UseVisualStyleBackColor = true;
            this.btn_semt_ekle.Click += new System.EventHandler(this.btn_semt_ekle_Click_1);
            // 
            // btn_ilce_Ekle
            // 
            this.btn_ilce_Ekle.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_ilce_Ekle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ilce_Ekle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ilce_Ekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ilce_Ekle.ImageIndex = 0;
            this.btn_ilce_Ekle.ImageList = this.imageList_il_ilce;
            this.btn_ilce_Ekle.Location = new System.Drawing.Point(408, 59);
            this.btn_ilce_Ekle.Name = "btn_ilce_Ekle";
            this.btn_ilce_Ekle.Size = new System.Drawing.Size(86, 41);
            this.btn_ilce_Ekle.TabIndex = 16;
            this.btn_ilce_Ekle.Text = "  İlçe Ekle";
            this.btn_ilce_Ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ilce_Ekle.UseVisualStyleBackColor = true;
            this.btn_ilce_Ekle.Click += new System.EventHandler(this.btn_ilce_Ekle_Click);
            // 
            // comboBox_semt
            // 
            this.comboBox_semt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_semt.FormattingEnabled = true;
            this.comboBox_semt.Location = new System.Drawing.Point(188, 141);
            this.comboBox_semt.Name = "comboBox_semt";
            this.comboBox_semt.Size = new System.Drawing.Size(212, 28);
            this.comboBox_semt.TabIndex = 1;
            this.comboBox_semt.SelectedIndexChanged += new System.EventHandler(this.comboBox_semt_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(17, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Semt seçiniz : *";
            // 
            // comboBox_ilce
            // 
            this.comboBox_ilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ilce.FormattingEnabled = true;
            this.comboBox_ilce.Location = new System.Drawing.Point(188, 73);
            this.comboBox_ilce.Name = "comboBox_ilce";
            this.comboBox_ilce.Size = new System.Drawing.Size(212, 28);
            this.comboBox_ilce.TabIndex = 0;
            this.comboBox_ilce.SelectedIndexChanged += new System.EventHandler(this.comboBox_ilce_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(17, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "İlçe seçiniz : *";
            // 
            // Sehirler_ekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 396);
            this.Controls.Add(this.TabControl_ILilce);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sehirler_ekran";
            this.Text = "İl/İlçe Kayıt Ekranı";
            this.Load += new System.EventHandler(this.Sehirler_ekran_Load);
            this.tab_il.ResumeLayout(false);
            this.tab_il.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TabControl_ILilce.ResumeLayout(false);
            this.tab_ilce.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_KimlikBelge;
        private System.Windows.Forms.ImageList imagelis_resimYukle;
        private System.Windows.Forms.ImageList imglist_kaydet;
        private System.Windows.Forms.OpenFileDialog openFileDialog_vesikalik;
        private System.Windows.Forms.OpenFileDialog openFileDialog_kontratBelge;
        private System.Windows.Forms.TabPage tab_il;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Il;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tab_ilce;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_semt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public FlatUI.FlatTabControl TabControl_ILilce;
        private System.Windows.Forms.Button btn_il_ekle;
        private System.Windows.Forms.ImageList imageList_il_ilce;
        public System.Windows.Forms.ComboBox combo_iller;
        public System.Windows.Forms.Button btn_ilce_Ekle;
        public System.Windows.Forms.Button btn_semt_ekle;
        public System.Windows.Forms.Button btn_il_guncelle;
        public System.Windows.Forms.Button btn_ilce_guncelle;
        public System.Windows.Forms.ComboBox comboBox_ilce;
    }
}