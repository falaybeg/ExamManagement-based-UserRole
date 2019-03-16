namespace Sinav_Gorevlendirme_Proje
{
    partial class Sinavda_Sorumlular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sinavda_Sorumlular));
            this.tab_onayBekleyenler = new System.Windows.Forms.TabPage();
            this.datagridView_sinav_Sorumlular = new System.Windows.Forms.DataGridView();
            this.Column_tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Soyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Cepno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_okulBina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_okulBinaAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Il = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_Sorumlu_Ara = new System.Windows.Forms.GroupBox();
            this.lbl_ilceler = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_isimAra = new System.Windows.Forms.Label();
            this.txt_isimAra = new System.Windows.Forms.TextBox();
            this.lbl_kimlikNOara = new System.Windows.Forms.Label();
            this.txt_kimlikNO = new System.Windows.Forms.TextBox();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tab_onayBekleyenler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridView_sinav_Sorumlular)).BeginInit();
            this.groupBox_Sorumlu_Ara.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_onayBekleyenler
            // 
            this.tab_onayBekleyenler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tab_onayBekleyenler.Controls.Add(this.datagridView_sinav_Sorumlular);
            this.tab_onayBekleyenler.Controls.Add(this.groupBox_Sorumlu_Ara);
            this.tab_onayBekleyenler.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_onayBekleyenler.Location = new System.Drawing.Point(4, 44);
            this.tab_onayBekleyenler.Name = "tab_onayBekleyenler";
            this.tab_onayBekleyenler.Padding = new System.Windows.Forms.Padding(3);
            this.tab_onayBekleyenler.Size = new System.Drawing.Size(1201, 538);
            this.tab_onayBekleyenler.TabIndex = 1;
            this.tab_onayBekleyenler.Text = "Sınav Sorumluları";
            // 
            // datagridView_sinav_Sorumlular
            // 
            this.datagridView_sinav_Sorumlular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridView_sinav_Sorumlular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_tc,
            this.Column_Isim,
            this.Column_Soyisim,
            this.Column_Cepno,
            this.Column_okulBina,
            this.Column_okulBinaAdress,
            this.Column_Il});
            this.datagridView_sinav_Sorumlular.Location = new System.Drawing.Point(7, 193);
            this.datagridView_sinav_Sorumlular.Name = "datagridView_sinav_Sorumlular";
            this.datagridView_sinav_Sorumlular.Size = new System.Drawing.Size(1187, 337);
            this.datagridView_sinav_Sorumlular.TabIndex = 33;
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
            // Column_Il
            // 
            this.Column_Il.HeaderText = "İL";
            this.Column_Il.Name = "Column_Il";
            this.Column_Il.ReadOnly = true;
            this.Column_Il.Width = 150;
            // 
            // groupBox_Sorumlu_Ara
            // 
            this.groupBox_Sorumlu_Ara.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Sorumlu_Ara.Controls.Add(this.lbl_ilceler);
            this.groupBox_Sorumlu_Ara.Controls.Add(this.textBox1);
            this.groupBox_Sorumlu_Ara.Controls.Add(this.lbl_isimAra);
            this.groupBox_Sorumlu_Ara.Controls.Add(this.txt_isimAra);
            this.groupBox_Sorumlu_Ara.Controls.Add(this.lbl_kimlikNOara);
            this.groupBox_Sorumlu_Ara.Controls.Add(this.txt_kimlikNO);
            this.groupBox_Sorumlu_Ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Sorumlu_Ara.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox_Sorumlu_Ara.Location = new System.Drawing.Point(328, 11);
            this.groupBox_Sorumlu_Ara.Name = "groupBox_Sorumlu_Ara";
            this.groupBox_Sorumlu_Ara.Size = new System.Drawing.Size(549, 160);
            this.groupBox_Sorumlu_Ara.TabIndex = 32;
            this.groupBox_Sorumlu_Ara.TabStop = false;
            this.groupBox_Sorumlu_Ara.Text = "Arama";
            // 
            // lbl_ilceler
            // 
            this.lbl_ilceler.AutoSize = true;
            this.lbl_ilceler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ilceler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_ilceler.Location = new System.Drawing.Point(122, 121);
            this.lbl_ilceler.Name = "lbl_ilceler";
            this.lbl_ilceler.Size = new System.Drawing.Size(84, 20);
            this.lbl_ilceler.TabIndex = 5;
            this.lbl_ilceler.Text = "İl\'e göre :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 110);
            this.textBox1.MaxLength = 20;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 31);
            this.textBox1.TabIndex = 4;
            // 
            // lbl_isimAra
            // 
            this.lbl_isimAra.AutoSize = true;
            this.lbl_isimAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_isimAra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_isimAra.Location = new System.Drawing.Point(148, 69);
            this.lbl_isimAra.Name = "lbl_isimAra";
            this.lbl_isimAra.Size = new System.Drawing.Size(52, 20);
            this.lbl_isimAra.TabIndex = 3;
            this.lbl_isimAra.Text = "Isim :";
            // 
            // txt_isimAra
            // 
            this.txt_isimAra.Location = new System.Drawing.Point(224, 66);
            this.txt_isimAra.MaxLength = 15;
            this.txt_isimAra.Multiline = true;
            this.txt_isimAra.Name = "txt_isimAra";
            this.txt_isimAra.Size = new System.Drawing.Size(215, 31);
            this.txt_isimAra.TabIndex = 2;
            // 
            // lbl_kimlikNOara
            // 
            this.lbl_kimlikNOara.AutoSize = true;
            this.lbl_kimlikNOara.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_kimlikNOara.Location = new System.Drawing.Point(112, 27);
            this.lbl_kimlikNOara.Name = "lbl_kimlikNOara";
            this.lbl_kimlikNOara.Size = new System.Drawing.Size(94, 18);
            this.lbl_kimlikNOara.TabIndex = 1;
            this.lbl_kimlikNOara.Text = "Kimlik NO :";
            // 
            // txt_kimlikNO
            // 
            this.txt_kimlikNO.Location = new System.Drawing.Point(224, 22);
            this.txt_kimlikNO.MaxLength = 11;
            this.txt_kimlikNO.Multiline = true;
            this.txt_kimlikNO.Name = "txt_kimlikNO";
            this.txt_kimlikNO.Size = new System.Drawing.Size(215, 31);
            this.txt_kimlikNO.TabIndex = 0;
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tab_onayBekleyenler);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(2, 3);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(1209, 586);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 31;
            // 
            // Sinavda_Sorumlular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 589);
            this.Controls.Add(this.flatTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sinavda_Sorumlular";
            this.Text = "Sinavda Sorumlular";
            this.Load += new System.EventHandler(this.Sinavda_Sorumlular_Load);
            this.tab_onayBekleyenler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridView_sinav_Sorumlular)).EndInit();
            this.groupBox_Sorumlu_Ara.ResumeLayout(false);
            this.groupBox_Sorumlu_Ara.PerformLayout();
            this.flatTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_onayBekleyenler;
        private System.Windows.Forms.Label lbl_isimAra;
        private System.Windows.Forms.TextBox txt_isimAra;
        private System.Windows.Forms.Label lbl_kimlikNOara;
        private System.Windows.Forms.TextBox txt_kimlikNO;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.Label lbl_ilceler;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Soyisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Cepno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_okulBina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_okulBinaAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Il;
        public System.Windows.Forms.DataGridView datagridView_sinav_Sorumlular;
        public System.Windows.Forms.GroupBox groupBox_Sorumlu_Ara;
    }
}