using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sinav_Gorevlendirme_Proje
{
    public partial class kullanici_Ekran : Form
    {    
        KisaYollar kisayol = new KisaYollar();
    

    
        public kullanici_Ekran(String kullaniciAdi, int yetki, int ID, int il_Id,int ilce_Id,int semt_id, int binaID)
        {
            InitializeComponent();

            lbl_kullanici.Text = "Kullanıcı: \n"+ kullaniciAdi;
            kisayol.yetkim = yetki;
            kisayol.Gorevli_ID = ID;
            kisayol.Il_Id = il_Id;
            kisayol.ilce_ID = ilce_Id;
            kisayol.semt_Id = semt_id;
            kisayol.bina_ID = binaID;
            MaximizeBox = false;
        }
       

        private void kullanici_Ekran_Load(object sender, EventArgs e)
        {
            btn_gorevliOnay.Visible = false;
            timer1.Start();
            this.Opacity = 1;
            timer_effekt.Start();
            kisayol.buton_FlatStyle_DarkBlue(btn_sehirler);
            kisayol.buton_FlatStyle_DarkBlue(btn_binaOkul);
            kisayol.buton_FlatStyle_DarkBlue(btn_gorevliOnay);
            kisayol.buton_FlatStyle_DarkBlue(btn_kullaniciIslemler);
            kisayol.buton_FlatStyle_DarkBlue(btn_sinavIslem);
            kisayol.buton_FlatStyle_DarkBlue(btn_sinavDetay);
            btn_sehirler.FlatAppearance.BorderColor = Color.White;
            btn_binaOkul.FlatAppearance.BorderColor = Color.White;
            
        }
        

        private void timer_acilis_Tick(object sender, EventArgs e)
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


        private void panel_Personel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox_logOUT_Click_1(object sender, EventArgs e)
        {

            DialogResult secenek = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(secenek == DialogResult.Yes)
            {
                Form1 login = new Form1();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }

        }
        private void btn_sehirler_Click(object sender, EventArgs e)
        {
            Sehirler_ekran sehir_ekle = new Sehirler_ekran(kisayol.yetkim, kisayol.Gorevli_ID, kisayol.Il_Id, kisayol.ilce_ID);
           sehir_ekle.ShowDialog(this);
        }
        private void btn_binaOkul_Click(object sender, EventArgs e)
        {
            Bina_Okul bina_ekle = new Bina_Okul(kisayol.yetkim, kisayol.Il_Id, kisayol.ilce_ID);
            bina_ekle.ShowDialog(this);
        }
        private void btn_sinavIslem_Click_1(object sender, EventArgs e)
        {
            Sinav_Islemler sinavlar = new Sinav_Islemler(kisayol.yetkim, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id, kisayol.Gorevli_ID, kisayol.bina_ID);
            sinavlar.ShowDialog(this);
        }
        private void btn_kullaniciIslemler_Click(object sender, EventArgs e)
        {

        }
        private void btn_gorevliOnay_Click(object sender, EventArgs e)
        {
            Gorevli_Onay onaylama = new Gorevli_Onay();
            onaylama.ShowDialog(this);
        }

        private void şifreGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hesap_Ayarlari bilgier = new Hesap_Ayarlari(kisayol.Gorevli_ID);
            bilgier.ShowDialog();
        }

        private void hesapBilgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kimlik_Karti_Bilgileri bigliler = new Kimlik_Karti_Bilgileri(kisayol.Gorevli_ID);
            this.Hide();
            bigliler.ShowDialog();
            bigliler.StartPosition = FormStartPosition.CenterScreen;
            this.Show();
        }

        private void btn_kullaniciIslemler_Click_1(object sender, EventArgs e)
        {
            String islem = "Select k.kimlikNO, k.Isim, k.Soyisim, k.Unvan, k.CepNO, k.eposta, k.Adress from Kullanicilar as k JOIN Login_Tablo as lg on k.login_ID = lg.Login_ID Where lg.username='" + kisayol.username + "'";

            Kullanici_Islemler_Ekrani islemler = new Kullanici_Islemler_Ekrani(kisayol.yetkim, kisayol.Gorevli_ID,kisayol.Il_Id,kisayol.ilce_ID);
            islemler.ShowDialog();
        }

        private void btn_sinavDetay_Click(object sender, EventArgs e)
        {
            Sinav_Detay sinavBilgi = new Sinav_Detay(kisayol.Gorevli_ID, kisayol.bina_ID);
            sinavBilgi.ShowDialog(this);
        }

        private void newTextDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
         System.Diagnostics.Process.Start("notepad.exe");
        }

        private void lbl_saatim_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbl_saatim.Text = datetime.ToString("HH:mm:ss");

        }

        private void microsoftOfficeWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WINWORD.EXE");
        }

        private void microsoftExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXCEL.EXE");
        }
  
    }
}
