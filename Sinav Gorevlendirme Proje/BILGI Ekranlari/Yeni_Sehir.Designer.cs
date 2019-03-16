namespace Sinav_Gorevlendirme_Proje
{
    partial class Yeni_Sehir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yeni_Sehir));
            this.label4 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_il_ismi = new System.Windows.Forms.TextBox();
            this.txt_ilce_ismi = new System.Windows.Forms.TextBox();
            this.txt_semt_ismi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.combo_ilce_sec = new System.Windows.Forms.ComboBox();
            this.comboBox_il_sec = new System.Windows.Forms.ComboBox();
            this.btn_IlceEkle = new System.Windows.Forms.Button();
            this.btn_semtEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(37, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yeni İl / İlçe / Semt Kaydı";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_kaydet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.ImageIndex = 0;
            this.btn_kaydet.ImageList = this.imageList1;
            this.btn_kaydet.Location = new System.Drawing.Point(280, 328);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(121, 41);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.Text = "        KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
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
            this.btn_clear.Location = new System.Drawing.Point(137, 328);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(119, 41);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "      TEMIZLE";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "İl ismi  :  *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(53, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "İlçe ismi  :  *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(53, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Semt ismi   : ";
            // 
            // txt_il_ismi
            // 
            this.txt_il_ismi.BackColor = System.Drawing.SystemColors.Control;
            this.txt_il_ismi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_il_ismi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_il_ismi.Location = new System.Drawing.Point(200, 28);
            this.txt_il_ismi.Multiline = true;
            this.txt_il_ismi.Name = "txt_il_ismi";
            this.txt_il_ismi.Size = new System.Drawing.Size(207, 32);
            this.txt_il_ismi.TabIndex = 0;
            this.txt_il_ismi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ilce_ismi
            // 
            this.txt_ilce_ismi.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ilce_ismi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ilce_ismi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_ilce_ismi.Location = new System.Drawing.Point(200, 89);
            this.txt_ilce_ismi.Multiline = true;
            this.txt_ilce_ismi.Name = "txt_ilce_ismi";
            this.txt_ilce_ismi.Size = new System.Drawing.Size(207, 32);
            this.txt_ilce_ismi.TabIndex = 1;
            this.txt_ilce_ismi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_semt_ismi
            // 
            this.txt_semt_ismi.BackColor = System.Drawing.SystemColors.Control;
            this.txt_semt_ismi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_semt_ismi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_semt_ismi.Location = new System.Drawing.Point(200, 144);
            this.txt_semt_ismi.Multiline = true;
            this.txt_semt_ismi.Name = "txt_semt_ismi";
            this.txt_semt_ismi.Size = new System.Drawing.Size(207, 32);
            this.txt_semt_ismi.TabIndex = 2;
            this.txt_semt_ismi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.combo_ilce_sec);
            this.groupBox1.Controls.Add(this.comboBox_il_sec);
            this.groupBox1.Controls.Add(this.txt_semt_ismi);
            this.groupBox1.Controls.Add(this.txt_ilce_ismi);
            this.groupBox1.Controls.Add(this.txt_il_ismi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(42, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // combo_ilce_sec
            // 
            this.combo_ilce_sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_ilce_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_ilce_sec.FormattingEnabled = true;
            this.combo_ilce_sec.Location = new System.Drawing.Point(6, 117);
            this.combo_ilce_sec.Name = "combo_ilce_sec";
            this.combo_ilce_sec.Size = new System.Drawing.Size(207, 32);
            this.combo_ilce_sec.TabIndex = 13;
            this.combo_ilce_sec.SelectedIndexChanged += new System.EventHandler(this.combo_ilce_sec_SelectedIndexChanged);
            // 
            // comboBox_il_sec
            // 
            this.comboBox_il_sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_il_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_il_sec.FormattingEnabled = true;
            this.comboBox_il_sec.Location = new System.Drawing.Point(6, 53);
            this.comboBox_il_sec.Name = "comboBox_il_sec";
            this.comboBox_il_sec.Size = new System.Drawing.Size(207, 32);
            this.comboBox_il_sec.TabIndex = 12;
            this.comboBox_il_sec.SelectedIndexChanged += new System.EventHandler(this.comboBox_il_sec_SelectedIndexChanged);
            // 
            // btn_IlceEkle
            // 
            this.btn_IlceEkle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_IlceEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IlceEkle.ForeColor = System.Drawing.Color.White;
            this.btn_IlceEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_IlceEkle.ImageIndex = 0;
            this.btn_IlceEkle.ImageList = this.imageList1;
            this.btn_IlceEkle.Location = new System.Drawing.Point(407, 297);
            this.btn_IlceEkle.Name = "btn_IlceEkle";
            this.btn_IlceEkle.Size = new System.Drawing.Size(121, 41);
            this.btn_IlceEkle.TabIndex = 12;
            this.btn_IlceEkle.Text = "        KAYDET";
            this.btn_IlceEkle.UseVisualStyleBackColor = false;
            this.btn_IlceEkle.Click += new System.EventHandler(this.btn_IlceEkle_Click);
            // 
            // btn_semtEkle
            // 
            this.btn_semtEkle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_semtEkle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_semtEkle.ForeColor = System.Drawing.Color.White;
            this.btn_semtEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_semtEkle.ImageIndex = 0;
            this.btn_semtEkle.ImageList = this.imageList1;
            this.btn_semtEkle.Location = new System.Drawing.Point(407, 344);
            this.btn_semtEkle.Name = "btn_semtEkle";
            this.btn_semtEkle.Size = new System.Drawing.Size(121, 41);
            this.btn_semtEkle.TabIndex = 13;
            this.btn_semtEkle.Text = "        KAYDET";
            this.btn_semtEkle.UseVisualStyleBackColor = false;
            this.btn_semtEkle.Click += new System.EventHandler(this.btn_semtEkle_Click);
            // 
            // Yeni_Sehir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(540, 397);
            this.Controls.Add(this.btn_semtEkle);
            this.Controls.Add(this.btn_IlceEkle);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Yeni_Sehir";
            this.Text = "Yeni Sehir";
            this.Load += new System.EventHandler(this.Yeni_Sehir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_il_ismi;
        public System.Windows.Forms.TextBox txt_ilce_ismi;
        public System.Windows.Forms.TextBox txt_semt_ismi;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox comboBox_il_sec;
        public System.Windows.Forms.ComboBox combo_ilce_sec;
        public System.Windows.Forms.Button btn_IlceEkle;
        public System.Windows.Forms.Button btn_semtEkle;
        public System.Windows.Forms.Button btn_kaydet;
    }
}