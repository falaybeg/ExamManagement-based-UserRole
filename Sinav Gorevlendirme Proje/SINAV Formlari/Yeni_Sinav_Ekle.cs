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
    public partial class Yeni_Sinav_Ekle : Form
    {
        public Yeni_Sinav_Ekle(int yetki,int il_id,int ilce_id,int semt_id, int gorevli_id)
        {
            InitializeComponent();
            kisayol.yetkim = yetki;
            kisayol.Il_Id = il_id;
            kisayol.ilce_ID = ilce_id;
            kisayol.semt_Id = semt_id;
            kisayol.Gorevli_ID = gorevli_id;
            MaximizeBox = false; 
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        KisaYollar kisayol = new KisaYollar();
        SqlConnection baglanti = new SqlConnection("Data Source=COMPUTER\\SQLEXPRESS;Initial Catalog=SinavGorevlendirme;Persist Security Info=True;User ID=sa;Password=1995;");
       public int il, ilce, semti, binaID,sorumluID;
       String isim, soyisim,il_adi,ilce_adi, semt_adi,bina_ad,sorumlu_ad;

        private void Yeni_Sinav_Ekle_Load(object sender, EventArgs e)
       {
          
           if(kisayol.yetkim == 1)
           {
               String iller = "Select il_ID,ilAdi from Iller_Tablosu Order by ilAdi ";
               combobox_veriler(combo_sinav_Iller,iller,"il_ID","ilAdi",il,il_adi);

           }
           else if(kisayol.yetkim == 2)
            {
                lbl_Il.Hide();
                combo_sinav_Iller.Hide();
                String ilceler = "select ilce_ID,ilceAdi from Ilceler_Tablosu where il_id = '"+kisayol.Il_Id+"'";
                combobox_veriler(comboBox_Sinav_Ilce, ilceler, "ilce_ID", "ilceAdi", ilce, ilce_adi);

            }
           if (kisayol.yetkim == 3)
           {
               lbl_Il.Hide();
               combo_sinav_Iller.Hide();
               String ilceler = "select ilce_ID,ilceAdi from Ilceler_Tablosu where il_id = '" + kisayol.Il_Id + "'";
               combobox_veriler(comboBox_Sinav_Ilce, ilceler, "ilce_ID", "ilceAdi", ilce, ilce_adi);
           }
           if (kisayol.yetkim == 4)
           {
               lbl_Il.Hide();
               combo_sinav_Iller.Hide();
               label8.Hide();
               comboBox_Sinav_Ilce.Hide();
               
               String sorgu = "select semt_ID,semtAdi from Semt_Tablo where ilce_ID = '" + kisayol.ilce_ID + "'";
               combobox_veriler(combo_sinavSemt, sorgu, "semt_ID", "semtAdi", semti, semt_adi);
           }
           if (kisayol.yetkim == 5)
           {
               lbl_Il.Hide();
               combo_sinav_Iller.Hide();
               label8.Hide();
               comboBox_Sinav_Ilce.Hide();
               label9.Hide();
               combo_sinavSemt.Hide();
               btn_Sinav_bina.Hide();
               String sorgu = "Select bina_ID,binaAdi from BinaBilgileri  Where gorevli_ID =  '" +  kisayol.Gorevli_ID+ "'";
               combobox_veriler(combo_sinavBina, sorgu, "bina_ID", "binaAdi", binaID, bina_ad);

           }
           if (kisayol.yetkim == 6)
           {
               lbl_Il.Hide();
               combo_sinav_Iller.Hide();
               label8.Hide();
               comboBox_Sinav_Ilce.Hide();
               label9.Hide();
               combo_sinavSemt.Hide();
               btn_Sinav_bina.Hide();

               String sorgu = "Select bina_ID,binaAdi from BinaBilgileri  Where gorevli_ID =  '" + kisayol.Gorevli_ID + "'";
               combobox_veriler(combo_sinavBina, sorgu, "bina_ID", "binaAdi", binaID, bina_ad);
           }
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            combo_sinav_Iller.Text = null;
            comboBox_Sinav_Ilce.Text = null;
            combo_sinavSemt.Text = null;
            txt_sinavAcikad.Text = null;
            txt_sinavDonem.Text = null;
            txt_sinavKisaAd.Text = null;
            txt_SinavSaati.Text = null;
            txt_SinavSuresi.Text = null;
            txt_sinavTarih.Text = null;
            combo_sinav_Iller.Text = null;
            comboBox_Sinav_Ilce.Text = null;
            combo_sinavSemt.Text = null;
            combo_sinavBina.Text = null;
            combo_Sinav_Sorumlu.Text = null;
        }

        private void btn_kaydetSinav_Click(object sender, EventArgs e)
        {
          
            if(txt_sinavAcikad.Text==String.Empty || txt_sinavDonem.Text==String.Empty || txt_sinavTarih.Text==String.Empty || txt_SinavSaati.Text==String.Empty || txt_SinavSuresi.Text==String.Empty)
            {
                kisayol.mesajBox_Butonlu("(*) Yıldızlı alanlar boş bırakılamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sorgu = "Insert into Sinav_Bilgileri(acikAdi,kisaAdi,Donemi,Tarihi,Saati,Suresi,il_ID,ilce_ID,semt_ID,gorevliID,bina_ID) values(@acikAd,@kisaAdi,@Donemi,@Tarihi,@Saati,@Suresi,@il,@ilce,@semt,@gorevli,@bina); update Kullanicilar set binaID = '" + binaID + "' Where gorevliID = '" + sorumluID + "';";

                if(kisayol.yetkim == 1)
                {

                    kaydet_sinav(sorgu,il,ilce,semti,sorumluID,binaID);

                }
                else if (kisayol.yetkim == 2 || kisayol.yetkim == 3)
                {
                    kaydet_sinav(sorgu, kisayol.Il_Id, ilce, semti, sorumluID, binaID);
                }
                else if (kisayol.yetkim == 4)
                {
                    kaydet_sinav(sorgu, kisayol.Il_Id, kisayol.ilce_ID, semti, sorumluID, binaID);
                }
                else if (kisayol.yetkim == 5 || kisayol.yetkim == 6)
                {
                    kaydet_sinav(sorgu, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id, sorumluID, binaID);

                }
                
                kisayol.mesajBox_Butonlu("Bilgiler başarıyla kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();                  

            }

        }

        private void btn_Sinav_bina_Click(object sender, EventArgs e)
        {
                Bina_Okul ekle = new Bina_Okul(kisayol.yetkim, kisayol.Il_Id, kisayol.ilce_ID);
                ekle.ShowDialog(this);
        }

        private void btn_yeni_BinaGorevli_Click(object sender, EventArgs e)
        {
            Gorevli_Ekle gorevliEkle = new Gorevli_Ekle(kisayol.yetkim, kisayol.secim_gorevli, kisayol.Il_Id, kisayol.ilce_ID,kisayol.semt_Id);
            gorevliEkle.tabControl_OkulBilgisi.Size = new System.Drawing.Size(530, 437);
            gorevliEkle.btn_BinaYeni.Hide();
            gorevliEkle.Size = new System.Drawing.Size(545, 557);
            gorevliEkle.ShowDialog(this);
        }

        private void btn_sinav_Sorumlu_Click(object sender, EventArgs e)
        {
            Gorevli_Ekle ekle = new Gorevli_Ekle(kisayol.yetkim, kisayol.secim_gorevli, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id);

            Yonetici_Secimi_Ekle secim = new Yonetici_Secimi_Ekle(kisayol.yetkim, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id);
            kisayol.combobox_Sil(secim.combo_secim, "Genel Yönetici");
            kisayol.combobox_Sil(secim.combo_secim, "İl Yöneticisi");
            kisayol.combobox_Sil(secim.combo_secim, "İl Yardımcısı");
            kisayol.combobox_Sil(secim.combo_secim, "İlçe Yöneticisi");
            kisayol.combobox_Sil(secim.combo_secim, "Bina Yöneticisi");
            kisayol.combobox_Sil(secim.combo_secim, "Bina Yardımcısı");
            secim.combo_secim.SelectedIndex = 0;

            secim.ShowDialog(this);

            if (ekle.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (kisayol.yetkim == 1)
                {
                    String sorgu = "Select gorevliID,Isim,Soyisim from Kullanicilar Where il_ID = '" + il + "' and Yetki_Gorevi = 7 and binaID is null";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    SqlDataReader veriler = komut.ExecuteReader();

                    combo_Sinav_Sorumlu.Items.Clear();
                    while (veriler.Read())
                    {
                        sorumluID = Convert.ToInt32(veriler["gorevliID"]);
                        String ad = Convert.ToString(veriler["Isim"]);
                        String soyad = Convert.ToString(veriler["Soyisim"]);

                        ComboboxItem item = new ComboboxItem();
                        item.Text = ad + " " + soyad;
                        item.Value = sorumluID;
                        combo_Sinav_Sorumlu.Items.Add(item);
                    }
                    veriler.Close();
                    baglanti.Close();
                }
                else if (kisayol.yetkim == 2 || kisayol.yetkim == 3)
                {
                    ekle.label15.Hide();
                    ekle.combobox_gorevli_il.Hide();

                    String sorgu = "Select gorevliID,Isim,Soyisim from Kullanicilar Where il_ID = '" + kisayol.Il_Id + "' and Yetki_Gorevi = 7 and binaID is null";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    SqlDataReader veriler = komut.ExecuteReader();

                    combo_Sinav_Sorumlu.Items.Clear();
                    while (veriler.Read())
                    {
                        sorumluID = Convert.ToInt32(veriler["gorevliID"]);
                        String ad = Convert.ToString(veriler["Isim"]);
                        String soyad = Convert.ToString(veriler["Soyisim"]);

                        ComboboxItem item = new ComboboxItem();
                        item.Text = ad + " " + soyad;
                        item.Value = sorumluID;
                        combo_Sinav_Sorumlu.Items.Add(item);
                    }
                    veriler.Close();
                    baglanti.Close();
                }
                else if (kisayol.yetkim == 4)
                {
                    ekle.label15.Hide();
                    ekle.combobox_gorevli_il.Hide();
                    ekle.label14.Hide();
                    ekle.combobox_gorevli_ilce.Hide();

                    String sorgu = "Select gorevliID,Isim,Soyisim from Kullanicilar Where il_ID = '" + kisayol.Il_Id + "' and Yetki_Gorevi = 7 and binaID is null";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    SqlDataReader veriler = komut.ExecuteReader();

                    combo_Sinav_Sorumlu.Items.Clear();
                    while (veriler.Read())
                    {
                        sorumluID = Convert.ToInt32(veriler["gorevliID"]);
                        String ad = Convert.ToString(veriler["Isim"]);
                        String soyad = Convert.ToString(veriler["Soyisim"]);

                        ComboboxItem item = new ComboboxItem();
                        item.Text = ad + " " + soyad;
                        item.Value = sorumluID;
                        combo_Sinav_Sorumlu.Items.Add(item);
                    }
                    veriler.Close();
                    baglanti.Close();
                }
                else if (kisayol.yetkim == 5 || kisayol.yetkim == 6)
                {

                    ekle.label15.Hide();
                    ekle.combobox_gorevli_il.Hide();
                    ekle.label14.Hide();
                    ekle.combobox_gorevli_ilce.Hide();
                    ekle.label16.Hide();
                    ekle.combo_gorevli_Semt.Hide();

                    String sorgu = "Select gorevliID,Isim,Soyisim from Kullanicilar Where ilce_JD = '" + kisayol.ilce_ID + "' and Yetki_Gorevi = 7 and binaID is null";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    SqlDataReader veriler = komut.ExecuteReader();

                    combo_Sinav_Sorumlu.Items.Clear();
                    while (veriler.Read())
                    {
                        sorumluID = Convert.ToInt32(veriler["gorevliID"]);
                        String ad = Convert.ToString(veriler["Isim"]);
                        String soyad = Convert.ToString(veriler["Soyisim"]);

                        ComboboxItem item = new ComboboxItem();
                        item.Text = ad + " " + soyad;
                        item.Value = sorumluID;
                        combo_Sinav_Sorumlu.Items.Add(item);
                    }
                    veriler.Close();
                    baglanti.Close();
                }
                this.Show();
            }
        }
        private void button_Temizle_Click_1(object sender, EventArgs e)
        {
            txt_sinavAcikad.Text = "";
            txt_sinavDonem.Text = "";
            txt_sinavKisaAd.Text = "";
            txt_SinavSaati.Text = "";
            txt_SinavSuresi.Text = "";
            txt_sinavTarih.Text = "";
        }

        private void combo_sinav_Iller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kisayol.yetkim == 1)
            {
                il = Convert.ToInt32((((Sinav_Gorevlendirme_Proje.Yeni_Sinav_Ekle.ComboboxItem)(combo_sinav_Iller.SelectedItem)).Value));

                String sorgu2 = "Select ilce_ID,ilceAdi from Ilceler_Tablosu Where il_id = '"+il+"' ";
                combobox_veriler(comboBox_Sinav_Ilce, sorgu2, "ilce_ID", "ilceAdi", ilce, ilce_adi);
            }
        }

        private void comboBox_Sinav_Ilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilce = Convert.ToInt32((((Sinav_Gorevlendirme_Proje.Yeni_Sinav_Ekle.ComboboxItem)(comboBox_Sinav_Ilce.SelectedItem)).Value));
            String sorgu = "Select semt_ID,semtAdi from Semt_Tablo Where ilce_ID = '" + ilce + "'";
            combobox_veriler(combo_sinavSemt, sorgu, "semt_ID", "semtAdi", semti, semt_adi);

        }
        private void combo_sinavSemt_SelectedIndexChanged(object sender, EventArgs e)
        {
            semti = Convert.ToInt32(((Sinav_Gorevlendirme_Proje.Yeni_Sinav_Ekle.ComboboxItem)(combo_sinavSemt.SelectedItem)).Value);
          
            String sorgu = "Select bina_ID,binaAdi from BinaBilgileri Where semt_ID = '"+semti+"'";
            combobox_veriler(combo_sinavBina,sorgu,"bina_ID","binaAdi",binaID,bina_ad);
        }

        private void combo_sinavBina_SelectedIndexChanged(object sender, EventArgs e)
        {
            binaID = Convert.ToInt32(((Sinav_Gorevlendirme_Proje.Yeni_Sinav_Ekle.ComboboxItem)(combo_sinavBina.SelectedItem)).Value);

            if (kisayol.yetkim == 1)
            {
                String sorgu = "Select gorevliID,Isim,Soyisim from Kullanicilar Where il_ID = '" + il + "' and Yetki_Gorevi = 7 and binaID is null";
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader veriler = komut.ExecuteReader();

                combo_Sinav_Sorumlu.Items.Clear();
                while (veriler.Read())
                {
                    sorumluID = Convert.ToInt32(veriler["gorevliID"]);
                    String ad = Convert.ToString(veriler["Isim"]);
                    String soyad = Convert.ToString(veriler["Soyisim"]);

                    ComboboxItem item = new ComboboxItem();
                    item.Text = ad + " " + soyad;
                    item.Value = sorumluID;
                    combo_Sinav_Sorumlu.Items.Add(item);
                }
                veriler.Close();
                baglanti.Close();
            }
            else if (kisayol.yetkim == 2 || kisayol.yetkim == 3)
            {
                String sorgu = "Select gorevliID,Isim,Soyisim from Kullanicilar Where il_ID = '" + kisayol.Il_Id + "' and Yetki_Gorevi = 7 and binaID is null";
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader veriler = komut.ExecuteReader();

                combo_Sinav_Sorumlu.Items.Clear();
                while (veriler.Read())
                {
                    sorumluID = Convert.ToInt32(veriler["gorevliID"]);
                    String ad = Convert.ToString(veriler["Isim"]);
                    String soyad = Convert.ToString(veriler["Soyisim"]);

                    ComboboxItem item = new ComboboxItem();
                    item.Text = ad + " " + soyad;
                    item.Value = sorumluID;
                    combo_Sinav_Sorumlu.Items.Add(item);
                }
                veriler.Close();
                baglanti.Close();
            }
            else if (kisayol.yetkim == 4)
            {
                String sorgu = "Select gorevliID,Isim,Soyisim from Kullanicilar Where il_ID = '" + kisayol.Il_Id + "' and Yetki_Gorevi = 7 and binaID is null";
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader veriler = komut.ExecuteReader();

                combo_Sinav_Sorumlu.Items.Clear();
                while (veriler.Read())
                {
                    sorumluID = Convert.ToInt32(veriler["gorevliID"]);
                    String ad = Convert.ToString(veriler["Isim"]);
                    String soyad = Convert.ToString(veriler["Soyisim"]);

                    ComboboxItem item = new ComboboxItem();
                    item.Text = ad + " " + soyad;
                    item.Value = sorumluID;
                    combo_Sinav_Sorumlu.Items.Add(item);
                }
                veriler.Close();
                baglanti.Close();
            }
            else if (kisayol.yetkim == 5 || kisayol.yetkim == 6)
            {
                String sorgu = "Select gorevliID,Isim,Soyisim from Kullanicilar Where ilce_JD = '" + kisayol.ilce_ID + "' and Yetki_Gorevi = 7 and binaID is null";
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataReader veriler = komut.ExecuteReader();

                combo_Sinav_Sorumlu.Items.Clear();
                while (veriler.Read())
                {
                    sorumluID = Convert.ToInt32(veriler["gorevliID"]);
                    String ad = Convert.ToString(veriler["Isim"]);
                    String soyad = Convert.ToString(veriler["Soyisim"]);

                    ComboboxItem item = new ComboboxItem();
                    item.Text = ad + " " + soyad;
                    item.Value = sorumluID;
                    combo_Sinav_Sorumlu.Items.Add(item);
                }
                veriler.Close();
                baglanti.Close();
            }

        }
        private void kaydet_sinav(String sorgu ,int il,int ilce,int semt, int sorumlu, int bina)
        {
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@acikAd", txt_sinavAcikad.Text);
            komut.Parameters.AddWithValue("@kisaAdi", txt_sinavKisaAd.Text);
            komut.Parameters.AddWithValue("@Donemi", txt_sinavDonem.Text);
            komut.Parameters.AddWithValue("@Tarihi", txt_sinavTarih.Text);
            komut.Parameters.AddWithValue("@Saati", txt_SinavSaati.Text);
            komut.Parameters.AddWithValue("@Suresi", txt_SinavSuresi.Text);

            komut.Parameters.AddWithValue("@il", il);
            komut.Parameters.AddWithValue("@ilce", ilce);
            komut.Parameters.AddWithValue("@semt", semt);
            komut.Parameters.AddWithValue("@bina", bina);
            komut.Parameters.AddWithValue("@gorevli", sorumlu);
       

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

       private void combobox_veriler(ComboBox combobox, String sorgu, String sutun1_id, String sutun2_Ad, int id, String yazi)
       {
           baglanti.Open();
           SqlCommand komut = new SqlCommand(sorgu, baglanti);
           SqlDataReader veriler = komut.ExecuteReader();

           combobox.Items.Clear();
           while (veriler.Read())
           {
               id = Convert.ToInt32(veriler[sutun1_id]);
               yazi = Convert.ToString(veriler[sutun2_Ad]);

               ComboboxItem item = new ComboboxItem();
               item.Text = yazi;
               item.Value = id;
               combobox.Items.Add(item);
           }
           veriler.Close();
           baglanti.Close();
       }
     
       private void combo_Sinav_Sorumlu_SelectedIndexChanged(object sender, EventArgs e)
       {
           sorumluID = Convert.ToInt32(((Sinav_Gorevlendirme_Proje.Yeni_Sinav_Ekle.ComboboxItem)(combo_Sinav_Sorumlu.SelectedItem)).Value);
       }

    }
}