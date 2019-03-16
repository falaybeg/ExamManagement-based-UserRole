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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        int hareket, x, y;
        String birlestir;
        KisaYollar kisayol = new KisaYollar();


        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=SinavGorevlendirme;Integrated Security=True");



        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_saat.BackColor = Color.Transparent;
            lbl_tarih.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            minimize.BackColor = Color.Transparent;
            close.BackColor = Color.Transparent;
            passTXT.Text = "";
            groupBox1.BackColor = Color.Transparent;
            txt_sifreUret.ReadOnly = true;
            kisayol.Random_Uret(txt_sifreUret);

            // gUVENLIK kODU
           // txt_sifreUret.Text = txt_guvenlikKodu.Text;

         
        }

        private void Giris_button_Click(object sender, EventArgs e)
        {

            kisayol.username = userTXT.Text;
            kisayol.password = passTXT.Text;
            String cumle = "SELECT gorevliID,il_ID,ilce_JD,semt_ID,Yetki_Gorevi,Isim,Soyisim,username,password,binaID FROM Kullanicilar  Where username = '" + kisayol.username + "' and password = '" + kisayol.password + "'";
            try
            {

                SqlCommand komut = new SqlCommand(cumle, baglanti);

                if (userTXT.Text == String.Empty && passTXT.Text == String.Empty)
                {
                    kisayol.mesajBox_Butonlu("Alanlar Bos birakilamaz !!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    baglanti.Close();
                }

                else
                {

                    baglanti.Open();
                    SqlDataReader veriler = komut.ExecuteReader();

                    if (veriler.HasRows == false)
                    {
                        MessageBox.Show("Yanlis Sifre Girdiniz !!");
                        passTXT.Text = "";
                    }
                    else
                    {
                        while (veriler.Read())
                        {

                            kisayol.Gorevli_ID = Convert.ToInt32(veriler["gorevliID"]);
                            kisayol.Il_Id = Convert.ToInt32(veriler["il_ID"]);
                            kisayol.ilce_ID = Convert.ToInt32(veriler["ilce_JD"]);
                            kisayol.semt_Id = Convert.ToInt32(veriler["semt_ID"]);

                            kisayol.yetkim = Convert.ToInt32(veriler["Yetki_Gorevi"]);
                            kisayol.kullaniciAdi = Convert.ToString(veriler["Isim"]);
                            kisayol.kullaniciSoyadi = Convert.ToString(veriler["Soyisim"]);

                            birlestir = kisayol.kullaniciAdi + " " + kisayol.kullaniciSoyadi;

                            kisayol.username = Convert.ToString(veriler["username"]);
                            kisayol.password = Convert.ToString(veriler["password"]);


                            if (!String.IsNullOrEmpty(veriler["binaID"].ToString()))
                                kisayol.bina_ID = Convert.ToInt32(veriler["binaID"]);
                            else
                                kisayol.bina_ID = 0;


                            if (txt_sifreUret.Text == txt_guvenlikKodu.Text)
                            {

                                if (kisayol.yetkim == 1)
                                {
                                    kullanici_Ekran genelAdmin = new kullanici_Ekran(birlestir, kisayol.yetkim, kisayol.Gorevli_ID, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id, kisayol.bina_ID);
                                    this.Hide();
                                    kisayol.mesajBox_Basit("Genel admin !!!!");
                                    genelAdmin.btn_sinavDetay.Hide();

                                    genelAdmin.ShowDialog();

                                    this.Close();
                                    veriler.Close();

                                }
                                else if (kisayol.yetkim == 2)
                                {
                                    this.Hide();
                                    kullanici_Ekran ilYonetici = new kullanici_Ekran(birlestir, kisayol.yetkim, kisayol.Gorevli_ID, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id, kisayol.bina_ID);
                                    kisayol.mesajBox_Basit("Il yoneticisi  !!!");
                                    ilYonetici.btn_sehirler.Text = "İlçe Kaydı";
                                    ilYonetici.btn_sehirler.TextAlign = ContentAlignment.MiddleRight;
                                    ilYonetici.btn_sinavDetay.Hide();

                                    ilYonetici.ShowDialog();

                                    this.Close();

                                }
                                else if (kisayol.yetkim == 3)
                                {
                                    this.Hide();
                                    kullanici_Ekran ilYardimcisi = new kullanici_Ekran(birlestir, kisayol.yetkim, kisayol.Gorevli_ID, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id, kisayol.bina_ID);
                                    kisayol.mesajBox_Basit("Il Yardimcisi  !!!");
                                    ilYardimcisi.btn_sehirler.Hide();
                                    ilYardimcisi.btn_gorevliOnay.Hide();
                                    ilYardimcisi.btn_sinavDetay.Hide();
                                    ilYardimcisi.btn_binaOkul.Location = new Point(-1, -1);
                                    ilYardimcisi.btn_sinavIslem.Location = new Point(-2, 74);
                                    ilYardimcisi.btn_kullaniciIslemler.Location = new Point(-3, 149);

                                    ilYardimcisi.ShowDialog();
                                    this.Close();
                                }
                                else if (kisayol.yetkim == 4)
                                {
                                    this.Hide();
                                    kullanici_Ekran IlceYoneticisi = new kullanici_Ekran(birlestir, kisayol.yetkim, kisayol.Gorevli_ID, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id, kisayol.bina_ID);
                                    kisayol.mesajBox_Basit("Ilce Yoneticiiii  !!!");
                                    IlceYoneticisi.btn_sehirler.Hide();
                                    IlceYoneticisi.btn_gorevliOnay.Hide();
                                    IlceYoneticisi.btn_sinavDetay.Hide();
                                    IlceYoneticisi.btn_binaOkul.Location = new Point(-1, -1);
                                    IlceYoneticisi.btn_sinavIslem.Location = new Point(-2, 74);
                                    IlceYoneticisi.btn_kullaniciIslemler.Location = new Point(-3, 149);

                                    IlceYoneticisi.ShowDialog();
                                    this.Close();

                                }
                                else if (kisayol.yetkim == 5)
                                {
                                    this.Hide();
                                    kullanici_Ekran BinaYonetici = new kullanici_Ekran(birlestir, kisayol.yetkim, kisayol.Gorevli_ID, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id, kisayol.bina_ID);
                                    kisayol.mesajBox_Basit("Bina Yoneticiii !!");
                                    BinaYonetici.btn_sinavDetay.Hide();
                                    BinaYonetici.btn_sehirler.Hide();
                                    BinaYonetici.btn_gorevliOnay.Hide();
                                    BinaYonetici.btn_binaOkul.Hide();
                                    BinaYonetici.btn_kullaniciIslemler.Location = new Point(-1, -1);
                                    BinaYonetici.btn_sinavIslem.Location = new Point(-2, 74);


                                    BinaYonetici.ShowDialog();
                                    this.Close();
                                }

                                else if (kisayol.yetkim == 6)
                                {
                                    this.Hide();
                                    kullanici_Ekran BinaYardimcisi = new kullanici_Ekran(birlestir, kisayol.yetkim, kisayol.Gorevli_ID, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id, kisayol.bina_ID);
                                    kisayol.mesajBox_Basit("Bina Yardimcisi  !!!");

                                    BinaYardimcisi.btn_sehirler.Hide();
                                    BinaYardimcisi.btn_binaOkul.Hide();
                                    BinaYardimcisi.btn_gorevliOnay.Hide();
                                    BinaYardimcisi.btn_sinavDetay.Hide();
                                    BinaYardimcisi.btn_sinavIslem.Location = new Point(-1, -1);
                                    BinaYardimcisi.btn_kullaniciIslemler.Location = new Point(-2, 74);

                                    BinaYardimcisi.ShowDialog();
                                    this.Close();

                                }
                                else if (kisayol.yetkim == 7)
                                {
                                    this.Hide();
                                    kullanici_Ekran SinavSorumlusu = new kullanici_Ekran(birlestir, kisayol.yetkim, kisayol.Gorevli_ID, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id, kisayol.bina_ID);

                                    kisayol.mesajBox_Basit("Sinav Sorumlusu  !!!");
                                    SinavSorumlusu.btn_sehirler.Hide();
                                    SinavSorumlusu.btn_binaOkul.Hide();
                                    SinavSorumlusu.btn_kullaniciIslemler.Hide();
                                    SinavSorumlusu.btn_sinavIslem.Hide();
                                    SinavSorumlusu.btn_gorevliOnay.Hide();

                                    SinavSorumlusu.btn_sinavIslem.Location = new Point(-1, -1);
                                    SinavSorumlusu.btn_kullaniciIslemler.Location = new Point(-2, 74);

                                    SinavSorumlusu.btn_sinavDetay.Size = new Size(175, 75);
                                    SinavSorumlusu.btn_sinavDetay.Location = new Point(-1, -1);
                                    SinavSorumlusu.pictureBox_logOUT.Location = new Point(48, 356);
                                    SinavSorumlusu.lbl_cikis.Location = new Point(59, 417);
                                    SinavSorumlusu.lbl_kullanici.Location = new Point(2, 465);

                                    SinavSorumlusu.ShowDialog();
                                    this.Close();
                                }

                            }
                            else
                            {

                                kisayol.mesajBox_Butonlu("Lütfen Güvenlik Kodunu doğru giriniz !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        veriler.Close();
                        baglanti.Close();

                    }
                }
            }
        
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                kisayol.mesajBox_Butonlu("Lutfen Baglantinizi kontrol edin", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            kisayol.exit_Form();

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            kisayol.exit_Form();
        }

        private void timer_saat_Tick(object sender, EventArgs e)
        {
            DateTime localTime = DateTime.Now;
            timer_saat.Start();
            lbl_saat.Text = localTime.ToString("HH:mm:ss");
            lbl_tarih.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            hareket = 0;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            hareket = 1;
            x = e.X;
            y = e.Y;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (hareket == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }
        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            hareket = 1;
            x = e.X;
            y = e.Y;
        }
        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            hareket = 0;
        }
        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (hareket == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void check_sifreGoste_CheckedChanged(object sender, EventArgs e)
        {
            if(check_sifreGoste.Checked)
            {
                passTXT.UseSystemPasswordChar = false;
            }
            else
            {
                passTXT.UseSystemPasswordChar = true;
            }
        }
        private void btn_yenile_Click(object sender, EventArgs e)
        {
            kisayol.Random_Uret(txt_sifreUret);
        }
    }
}
