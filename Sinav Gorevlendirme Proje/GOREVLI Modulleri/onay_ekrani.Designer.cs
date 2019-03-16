namespace Sinav_Gorevlendirme_Proje
{
    partial class onay_ekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(onay_ekrani));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reddet = new System.Windows.Forms.Button();
            this.iconlar = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOT:\r\n Görev almak isteyen Görevli hakkında onay veriniz :";
            // 
            // btn_reddet
            // 
            this.btn_reddet.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_reddet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_reddet.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reddet.ForeColor = System.Drawing.Color.Black;
            this.btn_reddet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reddet.ImageIndex = 1;
            this.btn_reddet.ImageList = this.iconlar;
            this.btn_reddet.Location = new System.Drawing.Point(256, 99);
            this.btn_reddet.Name = "btn_reddet";
            this.btn_reddet.Size = new System.Drawing.Size(148, 62);
            this.btn_reddet.TabIndex = 1;
            this.btn_reddet.Text = "     REDDET";
            this.btn_reddet.UseVisualStyleBackColor = false;
            this.btn_reddet.Click += new System.EventHandler(this.btn_reddet_Click);
            // 
            // iconlar
            // 
            this.iconlar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconlar.ImageStream")));
            this.iconlar.TransparentColor = System.Drawing.Color.Transparent;
            this.iconlar.Images.SetKeyName(0, "1466351955_sign-check.ico");
            this.iconlar.Images.SetKeyName(1, "1466351960_sign-error.ico");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.iconlar;
            this.button1.Location = new System.Drawing.Point(62, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 62);
            this.button1.TabIndex = 3;
            this.button1.Text = "     ONAYLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // onay_ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(458, 190);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_reddet);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "onay_ekrani";
            this.Load += new System.EventHandler(this.onay_ekrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reddet;
        private System.Windows.Forms.ImageList iconlar;
        private System.Windows.Forms.Button button1;
    }
}