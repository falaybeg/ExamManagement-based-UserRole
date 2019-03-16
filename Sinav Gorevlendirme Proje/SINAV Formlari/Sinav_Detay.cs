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
    public partial class Sinav_Detay : Form
    {
        public Sinav_Detay(int id,int bina)
        {
            InitializeComponent();
            kisayol.Gorevli_ID = id;
            kisayol.bina_ID = bina;
          
        
        }

        KisaYollar kisayol = new KisaYollar();
        SqlConnection baglanti = new SqlConnection("Data Source=COMPUTER\\SQLEXPRESS; Initial Catalog=SinavGorevlendirme; User ID=sa; Password=1995;");
        String il, ilce,isim,soyisim;
        private void Sinav_Detay_Load(object sender, EventArgs e)
        {
            lbl_sorumlu.Hide();
            label11.Hide();

            String cumle = "Select sinav.acikAdi,sinav.kisaAdi,sinav.Donemi,sinav.Tarihi,sinav.Saati,sinav.Suresi,bina.binaAdi,il.ilAdi,ilce.ilceAdi ,k.Isim,k.Soyisim from Kullanicilar as k  join Sinav_Bilgileri as sinav on sinav.gorevliID = k.gorevliID Join BinaBilgileri as bina on bina.bina_ID = k.binaID JOIN Iller_Tablosu as il on il.il_ID = bina.il_ID Join Ilceler_Tablosu as ilce on ilce.ilce_ID = bina.ilce_ID where k.gorevliID = '" + kisayol.Gorevli_ID + "'";
            String yonetici = "select Isim,Soyisim from Kullanicilar where binaID = '" + kisayol.bina_ID + "' and Yetki_Gorevi=5";

            baglanti.Open();
            SqlCommand komut = new SqlCommand(cumle, baglanti);
            SqlDataReader veriler = komut.ExecuteReader();

            while (veriler.Read())
            {
                lbl_sinavAcik_adi.Text = Convert.ToString(veriler["acikAdi"]);
                lbl_sinavKisa_adi.Text = Convert.ToString(veriler["kisaAdi"]);
                lbl_SinavDonemi.Text = Convert.ToString(veriler["Donemi"]);
                lbl_sinavTarih.Text = Convert.ToString(veriler["Tarihi"]);
                lbl_sinavSaat.Text = Convert.ToString(veriler["Saati"]);
                lbl_SinavSure.Text = Convert.ToString(veriler["Suresi"]);
                il = Convert.ToString(veriler["ilAdi"]);
                ilce = Convert.ToString(veriler["ilceAdi"]);
                lbl_GorevYeri.Text = il + " / " + ilce;
                lbl_gorev_Bina.Text = Convert.ToString(veriler["binaAdi"]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand kom = new SqlCommand(yonetici, baglanti);
            SqlDataReader veri = kom.ExecuteReader();
            while (veri.Read())
            {
                isim = Convert.ToString(veri["Isim"]);
                soyisim = Convert.ToString(veri["Soyisim"]);
                lbl_Bina_Yoneticisi.Text = isim + " " + soyisim;
            }
            baglanti.Close();

        }
    }
}
