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
    public partial class Gorevli_Ekle : Form
    {
        public Gorevli_Ekle(int yetki,int secim, int il_ID,int ilce_ID, int semt_id)
        {
            InitializeComponent();
            kisayol.yetkim = yetki;
            kisayol.secim_gorevli = secim;
            kisayol.Il_Id = il_ID;
            kisayol.ilce_ID = ilce_ID;
            kisayol.semt_Id = semt_id;

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
        SqlConnection baglanti = new SqlConnection("Data Source=COMPUTER\\MSSQLSERVERR;Initial Catalog=SinavGorevlendirme;Integrated Security=True");
        public int il, ilce, semt;
        int il_ID, ilce_ID, semt_ID;
        String il_adi, ilce_adi, semt_adi;


        private void Gorevli_Ekle_Load(object sender, EventArgs e)
        {
            if (kisayol.yetkim == 1)
            {
                String iller = "Select il_ID,ilAdi from Iller_Tablosu Order by ilAdi ";
                combobox_veriler(combobox_gorevli_il, iller, "il_ID", "ilAdi", il, il_adi);
            }
            else  if (kisayol.yetkim == 2)
            {
                label15.Hide();
                combobox_gorevli_il.Hide();
                String ilceler = "select ilce_ID,ilceAdi from Ilceler_Tablosu where il_id = '" + kisayol.Il_Id + "'";
                combobox_veriler(combobox_gorevli_ilce, ilceler, "ilce_ID", "ilceAdi", ilce_ID, ilce_adi);
            }

            else if (kisayol.yetkim == 3)
            {
                label15.Hide();
                combobox_gorevli_il.Hide();
                String ilceler = "select ilce_ID,ilceAdi from Ilceler_Tablosu where il_id = '" + kisayol.Il_Id + "'";
                combobox_veriler(combobox_gorevli_ilce, ilceler, "ilce_ID", "ilceAdi", ilce_ID, ilce_adi);

            }
            else if (kisayol.yetkim == 4)
            {
                label15.Hide();
                combobox_gorevli_il.Hide();
                label14.Hide();
                combobox_gorevli_ilce.Hide();
                String sorgu = "select semt_ID,semtAdi from Semt_Tablo where ilce_ID = '" + kisayol.ilce_ID + "'";
                combobox_veriler(combo_gorevli_Semt, sorgu, "semt_ID", "semtAdi", semt_ID, semt_adi);
     
            }
            else
            {
                groupBox2.Hide();
            }   
        }

        private void btn_kaydetSinav_Click(object sender, EventArgs e)
        {
            Yonetici_Secimi_Ekle secim = new Yonetici_Secimi_Ekle(kisayol.yetkim, kisayol.Il_Id,kisayol.ilce_ID,kisayol.semt_Id);
            if (kisayol.yetkim == 1)
            {
                baglanti.Open();
                String ekleme = "INSERT INTO Kullanicilar(kimlikNO,Isim,Soyisim,Unvan,CepNO,eposta,Adress,username,password,Yetki_Gorevi,il_ID,ilce_JD,semt_ID) Values (@kimlik,@isim,@soyisim,@unvan,@cepno,@eposta,@adres,@username,@password,@yetkisi,@ilNO,@ilceNO,@semtNO);";
                SqlCommand komut = new SqlCommand(ekleme, baglanti);

                komut.Parameters.AddWithValue("@kimlik", txt_gorevliTC.Text);
                komut.Parameters.AddWithValue("@isim", txt_gorevliAd.Text);
                komut.Parameters.AddWithValue("@soyisim", txt_gorevliSoyad.Text);
                komut.Parameters.AddWithValue("@unvan", txt_gorevliUnvan.Text);
                komut.Parameters.AddWithValue("@cepno", txt_gorevliCepNO.Text);
                komut.Parameters.AddWithValue("@eposta", txt_gorevliEposta.Text);
                komut.Parameters.AddWithValue("@adres", txt_gorevliAdress.Text);
                komut.Parameters.AddWithValue("@username", txt_gorevliUsername.Text);
                komut.Parameters.AddWithValue("@password", txt_gorevliSifre.Text);
                komut.Parameters.AddWithValue("@yetkisi", kisayol.secim_gorevli);

                komut.Parameters.AddWithValue("@ilNO", il_ID);
                komut.Parameters.AddWithValue("@ilceNO", ilce_ID);
                komut.Parameters.AddWithValue("@semtNO", semt_ID);

                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (kisayol.yetkim == 2)
            {
                baglanti.Open();
                String ekleme = "INSERT INTO Kullanicilar(kimlikNO,Isim,Soyisim,Unvan,CepNO,eposta,Adress,username,password,Yetki_Gorevi,il_ID,ilce_JD,semt_ID) Values (@kimlik,@isim,@soyisim,@unvan,@cepno,@eposta,@adres,@username,@password,@yetkisi,@ilNO,@ilceNO,@semtNO);";
                SqlCommand komut = new SqlCommand(ekleme, baglanti);
                komut.Parameters.AddWithValue("@kimlik", txt_gorevliTC.Text);
                komut.Parameters.AddWithValue("@isim", txt_gorevliAd.Text);
                komut.Parameters.AddWithValue("@soyisim", txt_gorevliSoyad.Text);
                komut.Parameters.AddWithValue("@unvan", txt_gorevliUnvan.Text);
                komut.Parameters.AddWithValue("@cepno", txt_gorevliCepNO.Text);
                komut.Parameters.AddWithValue("@eposta", txt_gorevliEposta.Text);
                komut.Parameters.AddWithValue("@adres", txt_gorevliAdress.Text);
                komut.Parameters.AddWithValue("@username", txt_gorevliUsername.Text);
                komut.Parameters.AddWithValue("@password", txt_gorevliSifre.Text);
                komut.Parameters.AddWithValue("@yetkisi", kisayol.secim_gorevli);

                komut.Parameters.AddWithValue("@ilNO", kisayol.Il_Id);
                komut.Parameters.AddWithValue("@ilceNO", ilce_ID);
                komut.Parameters.AddWithValue("@semtNO", semt_ID);

                komut.ExecuteNonQuery();
                baglanti.Close();

            }
            else if (kisayol.yetkim == 3)
            {
                baglanti.Open();
                String ekleme = "INSERT INTO Kullanicilar(kimlikNO,Isim,Soyisim,Unvan,CepNO,eposta,Adress,username,password,Yetki_Gorevi,il_ID,ilce_JD,semt_ID) Values (@kimlik,@isim,@soyisim,@unvan,@cepno,@eposta,@adres,@username,@password,@yetkisi,@ilNO,@ilceNO,@semtNO);";
                SqlCommand komut = new SqlCommand(ekleme, baglanti);
                komut.Parameters.AddWithValue("@kimlik", txt_gorevliTC.Text);
                komut.Parameters.AddWithValue("@isim", txt_gorevliAd.Text);
                komut.Parameters.AddWithValue("@soyisim", txt_gorevliSoyad.Text);
                komut.Parameters.AddWithValue("@unvan", txt_gorevliUnvan.Text);
                komut.Parameters.AddWithValue("@cepno", txt_gorevliCepNO.Text);
                komut.Parameters.AddWithValue("@eposta", txt_gorevliEposta.Text);
                komut.Parameters.AddWithValue("@adres", txt_gorevliAdress.Text);
                komut.Parameters.AddWithValue("@username", txt_gorevliUsername.Text);
                komut.Parameters.AddWithValue("@password", txt_gorevliSifre.Text);
                komut.Parameters.AddWithValue("@yetkisi", kisayol.secim_gorevli);

                komut.Parameters.AddWithValue("@ilNO", kisayol.Il_Id);
                komut.Parameters.AddWithValue("@ilceNO", ilce_ID);
                komut.Parameters.AddWithValue("@semtNO", semt_ID);


                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (kisayol.yetkim == 4)
            {
                baglanti.Open();
                String ekleme = "INSERT INTO Kullanicilar(kimlikNO,Isim,Soyisim,Unvan,CepNO,eposta,Adress,username,password,Yetki_Gorevi,il_ID,ilce_JD,semt_ID) Values (@kimlik,@isim,@soyisim,@unvan,@cepno,@eposta,@adres,@username,@password,@yetkisi,@ilNO,@ilceNO,@semtNO);";
                SqlCommand komut = new SqlCommand(ekleme, baglanti);
                komut.Parameters.AddWithValue("@kimlik", txt_gorevliTC.Text);
                komut.Parameters.AddWithValue("@isim", txt_gorevliAd.Text);
                komut.Parameters.AddWithValue("@soyisim", txt_gorevliSoyad.Text);
                komut.Parameters.AddWithValue("@unvan", txt_gorevliUnvan.Text);
                komut.Parameters.AddWithValue("@cepno", txt_gorevliCepNO.Text);
                komut.Parameters.AddWithValue("@eposta", txt_gorevliEposta.Text);
                komut.Parameters.AddWithValue("@adres", txt_gorevliAdress.Text);
                komut.Parameters.AddWithValue("@username", txt_gorevliUsername.Text);
                komut.Parameters.AddWithValue("@password", txt_gorevliSifre.Text);
                komut.Parameters.AddWithValue("@yetkisi", kisayol.secim_gorevli);

                komut.Parameters.AddWithValue("@ilNO", kisayol.Il_Id);
                komut.Parameters.AddWithValue("@ilceNO", kisayol.ilce_ID);
                komut.Parameters.AddWithValue("@semtNO", semt_ID);

                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (kisayol.yetkim == 5)
            {
                baglanti.Open();
                String ekleme = "INSERT INTO Kullanicilar(kimlikNO,Isim,Soyisim,Unvan,CepNO,eposta,Adress,username,password,Yetki_Gorevi,il_ID,ilce_JD,semt_ID) Values (@kimlik,@isim,@soyisim,@unvan,@cepno,@eposta,@adres,@username,@password,@yetkisi,@ilNO,@ilceNO,@semtNO);";
                SqlCommand komut = new SqlCommand(ekleme, baglanti);
                komut.Parameters.AddWithValue("@kimlik", txt_gorevliTC.Text);
                komut.Parameters.AddWithValue("@isim", txt_gorevliAd.Text);
                komut.Parameters.AddWithValue("@soyisim", txt_gorevliSoyad.Text);
                komut.Parameters.AddWithValue("@unvan", txt_gorevliUnvan.Text);
                komut.Parameters.AddWithValue("@cepno", txt_gorevliCepNO.Text);
                komut.Parameters.AddWithValue("@eposta", txt_gorevliEposta.Text);
                komut.Parameters.AddWithValue("@adres", txt_gorevliAdress.Text);
                komut.Parameters.AddWithValue("@username", txt_gorevliUsername.Text);
                komut.Parameters.AddWithValue("@password", txt_gorevliSifre.Text);
                komut.Parameters.AddWithValue("@yetkisi", kisayol.secim_gorevli);

                komut.Parameters.AddWithValue("@ilNO", kisayol.Il_Id);
                komut.Parameters.AddWithValue("@ilceNO", kisayol.ilce_ID);
                komut.Parameters.AddWithValue("@semtNO", kisayol.semt_Id);


                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (kisayol.yetkim == 6)
            {
                baglanti.Open();
                String ekleme = "INSERT INTO Kullanicilar(kimlikNO,Isim,Soyisim,Unvan,CepNO,eposta,Adress,username,password,Yetki_Gorevi) Values (@kimlik,@isim,@soyisim,@unvan,@cepno,@eposta,@adres,@username,@password,@yetkisi);";
                SqlCommand komut = new SqlCommand(ekleme, baglanti);
                komut.Parameters.AddWithValue("@kimlik", txt_gorevliTC.Text);
                komut.Parameters.AddWithValue("@isim", txt_gorevliAd.Text);
                komut.Parameters.AddWithValue("@soyisim", txt_gorevliSoyad.Text);
                komut.Parameters.AddWithValue("@unvan", txt_gorevliUnvan.Text);
                komut.Parameters.AddWithValue("@cepno", txt_gorevliCepNO.Text);
                komut.Parameters.AddWithValue("@eposta", txt_gorevliEposta.Text);
                komut.Parameters.AddWithValue("@adres", txt_gorevliAdress.Text);
                komut.Parameters.AddWithValue("@username", txt_gorevliUsername.Text);
                komut.Parameters.AddWithValue("@password", txt_gorevliSifre.Text);
                komut.Parameters.AddWithValue("@yetkisi", kisayol.secim_gorevli);

                komut.ExecuteNonQuery();
                baglanti.Close();
            }


            kisayol.mesajBox_Basit("Bilgiler başarıyla kaydedildi. !!!");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            
        }

        private void btn_BinaYeni_Click(object sender, EventArgs e)
        {
            Bina_Okul binaEkle = new Bina_Okul(kisayol.yetkim, kisayol.Il_Id, kisayol.ilce_ID);
            this.Hide();
            binaEkle.Show();
            this.Show();
                
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            txt_gorevliTC.Text = "";
            txt_gorevliAd.Text = "";
            txt_gorevliSoyad.Text = "";
            txt_gorevliCepNO.Text = "";
            txt_gorevliEposta.Text = "";
            txt_gorevliSifre.Text = "";
                txt_gorevliUnvan.Text = "";
            txt_gorevliUsername.Text = "";
            txt_gorevliAdress.Text = "";
        }

        private void combobox_gorevli_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kisayol.yetkim == 1)
            {
                il_ID = Convert.ToInt32((((Sinav_Gorevlendirme_Proje.Gorevli_Ekle.ComboboxItem)(combobox_gorevli_il.SelectedItem)).Value));
                String sorgu2 = "Select ilce_ID,ilceAdi from Ilceler_Tablosu Where il_id = '" + il_ID + "' ";
                combobox_veriler(combobox_gorevli_ilce, sorgu2, "ilce_ID", "ilceAdi", ilce_ID, ilce_adi);
            }
            else if (kisayol.yetkim == 2)
            {
                String sorgu2 = "Select ilce_ID,ilceAdi from Ilceler_Tablosu Where il_id = '" + kisayol.Il_Id + "' ";
                combobox_veriler(combobox_gorevli_ilce, sorgu2, "ilce_ID", "ilceAdi", ilce_ID, ilce_adi);
            }
            else if (kisayol.yetkim == 3)
            {
                String sorgu2 = "Select ilce_ID,ilceAdi from Ilceler_Tablosu Where il_id = '" + kisayol.Il_Id + "' ";
                combobox_veriler(combobox_gorevli_ilce, sorgu2, "ilce_ID", "ilceAdi", ilce_ID, ilce_adi);
            }
        }

        private void combobox_gorevli_ilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilce_ID = Convert.ToInt32((((Sinav_Gorevlendirme_Proje.Gorevli_Ekle.ComboboxItem)(combobox_gorevli_ilce.SelectedItem)).Value));
               
            if (kisayol.yetkim == 1)
            {
                String sorgu = "Select semt_ID,semtAdi from Semt_Tablo Where ilce_ID = '" + ilce_ID + "'";
                combobox_veriler(combo_gorevli_Semt, sorgu, "semt_ID", "semtAdi", semt_ID, semt_adi);
            }
            else if(kisayol.yetkim == 2)
            {

                String sorgu = "Select semt_ID,semtAdi from Semt_Tablo Where ilce_ID = '" + ilce_ID + "'";
                combobox_veriler(combo_gorevli_Semt, sorgu, "semt_ID", "semtAdi", semt_ID, semt_adi);
            }
            else if (kisayol.yetkim == 3)
            {
                String sorgu = "Select semt_ID,semtAdi from Semt_Tablo Where ilce_ID = '" + ilce_ID + "'";
                combobox_veriler(combo_gorevli_Semt, sorgu, "semt_ID", "semtAdi", semt_ID, semt_adi);
            }  
        }
        private void combo_gorevli_Semt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            semt_ID = ilce_ID = Convert.ToInt32((((Sinav_Gorevlendirme_Proje.Gorevli_Ekle.ComboboxItem)(combo_gorevli_Semt.SelectedItem)).Value));
        }

        private void combo_binaIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
        private void txt_gorevliUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_gorevliTC_TextChanged(object sender, EventArgs e)
        {
            txt_gorevliUsername.Text = txt_gorevliTC.Text;
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {

            String guncelle = "Update Kullanicilar Set kimlikNO = @kimlik, Isim = @isim, Soyisim = @soyisim ,Unvan = @unvan ,CepNO=@cep, eposta=@posta, Adress =@adres Where kimlikNO = '" + txt_gorevliTC.Text + "'";
            SqlCommand komut = new SqlCommand(guncelle, baglanti);
            komut.Parameters.AddWithValue("@kimlik",txt_gorevliTC.Text );
            komut.Parameters.AddWithValue("@isim",txt_gorevliAd.Text);
            komut.Parameters.AddWithValue("@soyisim",txt_gorevliSoyad.Text);
            komut.Parameters.AddWithValue("@unvan",txt_gorevliUnvan.Text);
            komut.Parameters.AddWithValue("@cep",txt_gorevliCepNO.Text);
            komut.Parameters.AddWithValue("@posta",txt_gorevliEposta.Text);
            komut.Parameters.AddWithValue("@adres",txt_gorevliAdress.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            kisayol.mesajBox_Butonlu("Bilgiler basariyla guncellendi","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String guncelle = "Delete from Kullanicilar Where kimlikNO = @kimlik";
            SqlCommand komut = new SqlCommand(guncelle, baglanti);
            komut.Parameters.AddWithValue("@kimlik", txt_gorevliTC.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            kisayol.mesajBox_Butonlu("Kayit basariyla silindi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();  
        }
    }
}
