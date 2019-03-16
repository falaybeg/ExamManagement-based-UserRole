using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinav_Gorevlendirme_Proje
{
    public partial class Admin_Ekran : Form
    {
        public Admin_Ekran(String kullaniciAdi, String saat)
        {
            InitializeComponent();
            lbl_kullanici.Text ="Yönetici: " + kullaniciAdi;
            lbl_saatim.Text = saat;

         

        }
        KisaYollar kisayol = new KisaYollar();
        
        private void Admin_Ekran_Load(object sender, EventArgs e)
        {
            kisayol.buton_FlatStyle(btn_sehirler);
            kisayol.buton_FlatStyle(btn_binaOkul);
            kisayol.buton_FlatStyle(btn_sinavIslem);
            kisayol.buton_FlatStyle(btn_kullaniciIslemler);
            kisayol.buton_FlatStyle(btn_gorevliOnay);

            this.Opacity = 0.05;
            timer_effekt.Start();
           
        }

        private void btn_kullaniciIslemler_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_logOUT_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            //if (secenek == DialogResult.Yes)
            //{
            //    this.Hide();
            //    giris.ShowDialog();
            //    this.Close();
            //}
            if(secenek == DialogResult.Yes)
            {           
                Form1 login_ekran = new Form1();
                this.Hide();
                login_ekran.ShowDialog();
                this.Close();
            }
        }

        private void btn_sehirler_Click(object sender, EventArgs e)
        {
           // Sehirler_ekran sehirler = new Sehirler_ekran();
// sehirler.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_saatim.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void btn_gorevliOnay_Click(object sender, EventArgs e)
        {
            //Gorevli_Onay onayEkran = new Gorevli_Onay();
            //onayEkran.ShowDialog();
        }

        private void btn_binaOkul_Click(object sender, EventArgs e)
        {
            //Bina_Okul bilgiler = new Bina_Okul(kisayol.yetkim,kisayol.Il_Id,kisayol.ilce_ID);
            //bilgiler.ShowDialog();
        }

        private void newTextDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void timer_effekt_Tick(object sender, EventArgs e)
        {

            if (this.Opacity <= 1)
            {
                this.Opacity += 0.15;

            }
            else
            {
                timer_effekt.Stop();
            }    
        }

        private void hesapAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_sinavIslem_Click(object sender, EventArgs e)
        {
        //    Sinav_Islemler sinavlar = new Sinav_Islemler(kisayol.yetkim);
        //    sinavlar.ShowDialog(this);
        }

        private void şifreGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hesap_Ayarlari sifre = new Hesap_Ayarlari(kisayol.Login_ID);
            //sifre.ShowDialog();
        }

        private void yeniKullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
           // Kimlik_Karti_Bilgileri kimlik = new Kimlik_Karti_Bilgileri(kisayol.username);
           // this.Hide();
           // kimlik.ShowDialog();
           // this.Show();
        }

        private void hakkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //String hakkinda = "Bu program Sınav işlemlerimizi elektronik ortamda daha kolay yapıp yönetebileceğimiz bir yazılımdır.";
            //kisayol.mesajBox_Butonlu(hakkinda,"Hakkında",MessageBoxButtons.OK,MessageBoxIcon.None);
        }

    }
}
