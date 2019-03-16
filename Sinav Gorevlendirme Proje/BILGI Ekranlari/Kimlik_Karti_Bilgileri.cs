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
    public partial class Kimlik_Karti_Bilgileri : Form
    {
        public Kimlik_Karti_Bilgileri(int ID)
        {
            InitializeComponent();
            kisayol.Gorevli_ID = ID;
        }
        Form1 login = new Form1();
        KisaYollar kisayol = new KisaYollar();
        SqlConnection baglanti = new SqlConnection("Data Source=COMPUTER\\MSSQLSERVERR;Initial Catalog=SinavGorevlendirme;Integrated Security=True");

        private void Kimlik_Karti_Bilgileri_Load(object sender, EventArgs e)
        {
            String islem = "Select k.kimlikNO, k.Isim, k.Soyisim, k.Unvan, k.CepNO, k.eposta, k.Adress,il.ilAdi,k.Yetki_Gorevi from Kullanicilar as k Join Iller_Tablosu as il  on il.il_ID = k.il_ID Where k.gorevliID = '" + kisayol.Gorevli_ID + "'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(islem, baglanti);
            SqlDataReader veriler = komut.ExecuteReader();
            int yetki;

            while (veriler.Read())
            {
                lbl_KimlikNo.Text  = Convert.ToString(veriler["kimlikNO"]);
                lbl_Isim.Text = Convert.ToString(veriler["Isim"]);
                lbl_Soyisim.Text = Convert.ToString(veriler["Soyisim"]);
                lbl_Unvan.Text = Convert.ToString(veriler["Unvan"]);
                lbl_CepNO.Text = Convert.ToString(veriler["CepNO"]);
                lbl_Eposta.Text = Convert.ToString(veriler["eposta"]);
                lbl_Adress.Text = Convert.ToString(veriler["Adress"]);
                lbl_il_adi.Text = Convert.ToString(veriler["ilAdi"]);
                yetki = Convert.ToInt32(veriler["Yetki_Gorevi"]);

                if(yetki == 1)
                {
                    lbl_gorevi.Text = "Genel Admin";
                }
                else if (yetki == 2)
                {
                    lbl_gorevi.Text = "İl Yöneticisi";
                }
                else if (yetki == 3)
                {
                    lbl_gorevi.Text = "İl Yardımcısı";
                }
                else if (yetki == 4)
                {
                    lbl_gorevi.Text = "İlçe Yöneticisi";
                }
                else if (yetki == 5)
                {
                    lbl_gorevi.Text = "Bina Yöneticisi";
                }
                else if (yetki == 6)
                {
                    lbl_gorevi.Text = "Bina Yardımcısı";
                }
                else
                {
                    lbl_gorevi.Text = "Sınav Sorumlusu";
                }
            }
            baglanti.Close();
        }
    }
}
