namespace Sinav_Gorevlendirme_Proje
{
    partial class Gorevli_Onay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gorevli_Onay));
            this.lbl_gorevliOnay = new System.Windows.Forms.Label();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tab_onayBekleyenler = new System.Windows.Forms.TabPage();
            this.lbl_not = new System.Windows.Forms.Label();
            this.datagridView_OnayListesi = new System.Windows.Forms.DataGridView();
            this.Column_tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Soyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Cepno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_okulBina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_okulBinaAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_isimAra = new System.Windows.Forms.Label();
            this.txt_isimAra = new System.Windows.Forms.TextBox();
            this.lbl_kimlikNOara = new System.Windows.Forms.Label();
            this.txt_kimlikNO = new System.Windows.Forms.TextBox();
            this.tab_Onaylananlar = new System.Windows.Forms.TabPage();
            this.lbl_notdurum = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.flatTabControl1.SuspendLayout();
            this.tab_onayBekleyenler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridView_OnayListesi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tab_Onaylananlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_gorevliOnay
            // 
            this.lbl_gorevliOnay.AutoSize = true;
            this.lbl_gorevliOnay.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gorevliOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gorevliOnay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_gorevliOnay.Location = new System.Drawing.Point(45, 11);
            this.lbl_gorevliOnay.Name = "lbl_gorevliOnay";
            this.lbl_gorevliOnay.Size = new System.Drawing.Size(225, 25);
            this.lbl_gorevliOnay.TabIndex = 27;
            this.lbl_gorevliOnay.Text = "Görevli Onay Listesi";
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tab_onayBekleyenler);
            this.flatTabControl1.Controls.Add(this.tab_Onaylananlar);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(-2, 46);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(1061, 580);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 28;
            // 
            // tab_onayBekleyenler
            // 
            this.tab_onayBekleyenler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tab_onayBekleyenler.Controls.Add(this.lbl_not);
            this.tab_onayBekleyenler.Controls.Add(this.datagridView_OnayListesi);
            this.tab_onayBekleyenler.Controls.Add(this.groupBox1);
            this.tab_onayBekleyenler.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_onayBekleyenler.Location = new System.Drawing.Point(4, 44);
            this.tab_onayBekleyenler.Name = "tab_onayBekleyenler";
            this.tab_onayBekleyenler.Padding = new System.Windows.Forms.Padding(3);
            this.tab_onayBekleyenler.Size = new System.Drawing.Size(1053, 532);
            this.tab_onayBekleyenler.TabIndex = 1;
            this.tab_onayBekleyenler.Text = "Onay Bekleyenler ";
            // 
            // lbl_not
            // 
            this.lbl_not.AutoSize = true;
            this.lbl_not.BackColor = System.Drawing.Color.Transparent;
            this.lbl_not.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_not.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_not.Location = new System.Drawing.Point(642, 55);
            this.lbl_not.Name = "lbl_not";
            this.lbl_not.Size = new System.Drawing.Size(398, 50);
            this.lbl_not.TabIndex = 33;
            this.lbl_not.Text = "NOT:\r\n Onaylamak için kişinin üzerine tıklayınız";
            // 
            // datagridView_OnayListesi
            // 
            this.datagridView_OnayListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridView_OnayListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_tc,
            this.Column_Isim,
            this.Column_Soyisim,
            this.Column_Cepno,
            this.Column_okulBina,
            this.Column_okulBinaAdress});
            this.datagridView_OnayListesi.Location = new System.Drawing.Point(8, 145);
            this.datagridView_OnayListesi.Name = "datagridView_OnayListesi";
            this.datagridView_OnayListesi.Size = new System.Drawing.Size(1038, 381);
            this.datagridView_OnayListesi.TabIndex = 31;
            this.datagridView_OnayListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridView_OnayListesi_CellClick);
            // 
            // Column_tc
            // 
            this.Column_tc.HeaderText = "TC NO";
            this.Column_tc.MaxInputLength = 12;
            this.Column_tc.MinimumWidth = 10;
            this.Column_tc.Name = "Column_tc";
            this.Column_tc.ReadOnly = true;
            this.Column_tc.Width = 145;
            // 
            // Column_Isim
            // 
            this.Column_Isim.HeaderText = "Isim";
            this.Column_Isim.Name = "Column_Isim";
            this.Column_Isim.ReadOnly = true;
            this.Column_Isim.Width = 145;
            // 
            // Column_Soyisim
            // 
            this.Column_Soyisim.HeaderText = "Soyisim";
            this.Column_Soyisim.Name = "Column_Soyisim";
            this.Column_Soyisim.ReadOnly = true;
            this.Column_Soyisim.Width = 145;
            // 
            // Column_Cepno
            // 
            this.Column_Cepno.HeaderText = "Cep Telefon";
            this.Column_Cepno.Name = "Column_Cepno";
            this.Column_Cepno.ReadOnly = true;
            this.Column_Cepno.Width = 145;
            // 
            // Column_okulBina
            // 
            this.Column_okulBina.HeaderText = "Bağlı olduğı Okul/Bina";
            this.Column_okulBina.Name = "Column_okulBina";
            this.Column_okulBina.ReadOnly = true;
            this.Column_okulBina.Width = 207;
            // 
            // Column_okulBinaAdress
            // 
            this.Column_okulBinaAdress.HeaderText = "Okul/Bina Adresi";
            this.Column_okulBinaAdress.Name = "Column_okulBinaAdress";
            this.Column_okulBinaAdress.ReadOnly = true;
            this.Column_okulBinaAdress.Width = 207;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_isimAra);
            this.groupBox1.Controls.Add(this.txt_isimAra);
            this.groupBox1.Controls.Add(this.lbl_kimlikNOara);
            this.groupBox1.Controls.Add(this.txt_kimlikNO);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 124);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // lbl_isimAra
            // 
            this.lbl_isimAra.AutoSize = true;
            this.lbl_isimAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_isimAra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_isimAra.Location = new System.Drawing.Point(55, 77);
            this.lbl_isimAra.Name = "lbl_isimAra";
            this.lbl_isimAra.Size = new System.Drawing.Size(52, 20);
            this.lbl_isimAra.TabIndex = 3;
            this.lbl_isimAra.Text = "Isim :";
            // 
            // txt_isimAra
            // 
            this.txt_isimAra.Location = new System.Drawing.Point(131, 74);
            this.txt_isimAra.MaxLength = 15;
            this.txt_isimAra.Multiline = true;
            this.txt_isimAra.Name = "txt_isimAra";
            this.txt_isimAra.Size = new System.Drawing.Size(195, 31);
            this.txt_isimAra.TabIndex = 2;
            // 
            // lbl_kimlikNOara
            // 
            this.lbl_kimlikNOara.AutoSize = true;
            this.lbl_kimlikNOara.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_kimlikNOara.Location = new System.Drawing.Point(19, 32);
            this.lbl_kimlikNOara.Name = "lbl_kimlikNOara";
            this.lbl_kimlikNOara.Size = new System.Drawing.Size(94, 18);
            this.lbl_kimlikNOara.TabIndex = 1;
            this.lbl_kimlikNOara.Text = "Kimlik NO :";
            // 
            // txt_kimlikNO
            // 
            this.txt_kimlikNO.Location = new System.Drawing.Point(131, 27);
            this.txt_kimlikNO.MaxLength = 11;
            this.txt_kimlikNO.Multiline = true;
            this.txt_kimlikNO.Name = "txt_kimlikNO";
            this.txt_kimlikNO.Size = new System.Drawing.Size(195, 31);
            this.txt_kimlikNO.TabIndex = 0;
            // 
            // tab_Onaylananlar
            // 
            this.tab_Onaylananlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tab_Onaylananlar.Controls.Add(this.lbl_notdurum);
            this.tab_Onaylananlar.Controls.Add(this.dataGridView1);
            this.tab_Onaylananlar.Controls.Add(this.groupBox2);
            this.tab_Onaylananlar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Onaylananlar.Location = new System.Drawing.Point(4, 44);
            this.tab_Onaylananlar.Name = "tab_Onaylananlar";
            this.tab_Onaylananlar.Size = new System.Drawing.Size(1053, 532);
            this.tab_Onaylananlar.TabIndex = 2;
            this.tab_Onaylananlar.Text = "Onaylananlar";
            // 
            // lbl_notdurum
            // 
            this.lbl_notdurum.AutoSize = true;
            this.lbl_notdurum.BackColor = System.Drawing.Color.Transparent;
            this.lbl_notdurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_notdurum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_notdurum.Location = new System.Drawing.Point(637, 55);
            this.lbl_notdurum.Name = "lbl_notdurum";
            this.lbl_notdurum.Size = new System.Drawing.Size(408, 75);
            this.lbl_notdurum.TabIndex = 36;
            this.lbl_notdurum.Text = "NOT:\r\n Görevli bilgilerini görmek için üzerine tıklayınız\r\n\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.Location = new System.Drawing.Point(7, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1038, 381);
            this.dataGridView1.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "TC NO";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 12;
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 145;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Isim";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 145;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Soyisim";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 145;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cep Telefon";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 145;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Bağlı olduğı Okul/Bina";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 207;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Okul/Bina Adresi";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 207;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(9, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 124);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(55, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Isim :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 74);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 31);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kimlik NO :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 31);
            this.textBox2.TabIndex = 0;
            // 
            // Gorevli_Onay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 624);
            this.Controls.Add(this.flatTabControl1);
            this.Controls.Add(this.lbl_gorevliOnay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gorevli_Onay";
            this.Text = "Görevli Onay Ekrani";
            this.Load += new System.EventHandler(this.Gorevli_Onay_Load);
            this.flatTabControl1.ResumeLayout(false);
            this.tab_onayBekleyenler.ResumeLayout(false);
            this.tab_onayBekleyenler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridView_OnayListesi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_Onaylananlar.ResumeLayout(false);
            this.tab_Onaylananlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_gorevliOnay;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tab_onayBekleyenler;
        private System.Windows.Forms.Label lbl_not;
        private System.Windows.Forms.DataGridView datagridView_OnayListesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Soyisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Cepno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_okulBina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_okulBinaAdress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_kimlikNOara;
        private System.Windows.Forms.TextBox txt_kimlikNO;
        private System.Windows.Forms.Label lbl_isimAra;
        private System.Windows.Forms.TextBox txt_isimAra;
        private System.Windows.Forms.TabPage tab_Onaylananlar;
        private System.Windows.Forms.Label lbl_notdurum;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}