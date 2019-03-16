namespace Sinav_Gorevlendirme_Proje
{
    partial class Sehir_Guncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sehir_Guncelle));
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ilce = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_kaydet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kaydet.ImageIndex = 0;
            this.btn_kaydet.ImageList = this.imageList1;
            this.btn_kaydet.Location = new System.Drawing.Point(246, 121);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(121, 41);
            this.btn_kaydet.TabIndex = 4;
            this.btn_kaydet.Text = "       GÜNCELLE";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "update.ico");
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(152, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 33);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Il Güncelle :";
            // 
            // btn_ilce
            // 
            this.btn_ilce.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_ilce.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ilce.ForeColor = System.Drawing.Color.White;
            this.btn_ilce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ilce.ImageIndex = 0;
            this.btn_ilce.ImageList = this.imageList1;
            this.btn_ilce.Location = new System.Drawing.Point(246, 168);
            this.btn_ilce.Name = "btn_ilce";
            this.btn_ilce.Size = new System.Drawing.Size(121, 41);
            this.btn_ilce.TabIndex = 7;
            this.btn_ilce.Text = "       GÜNCELLE";
            this.btn_ilce.UseVisualStyleBackColor = false;
            this.btn_ilce.Click += new System.EventHandler(this.btn_ilce_Click);
            // 
            // Sehir_Guncelle
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(379, 221);
            this.Controls.Add(this.btn_ilce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_kaydet);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sehir_Guncelle";
            this.Text = "Sehir Güncelle";
            this.Load += new System.EventHandler(this.Sehir_Guncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_ilce;
    }
}