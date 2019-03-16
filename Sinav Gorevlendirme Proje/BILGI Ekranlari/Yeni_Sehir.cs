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
    public partial class Yeni_Sehir : Form
    {
        public Yeni_Sehir(int yetki,int il_ID)
        {
            InitializeComponent();
            kisayol.yetkim = yetki;
            kisayol.Il_Id = il_ID;
        }
        KisaYollar kisayol = new KisaYollar();
        SqlConnection baglanti = new SqlConnection("Data Source=COMPUTER\\MSSQLSERVERR;Initial Catalog=SinavGorevlendirme;Integrated Security=True");


        private void Yeni_Sehir_Load(object sender, EventArgs e)
        {

            if (kisayol.yetkim == 1)
            {
                String sorgu = "Select distinct il_ID, ilAdi from Iller_Tablosu ORDER BY ilAdi asc";
                kisayol.Veritabani_Combobox_Veri(comboBox_il_sec, sorgu, "ilAdi");

                String sorgum = "Select distinct ilce_ID, ilceAdi from Ilceler_Tablosu ORDER BY ilceAdi asc";
                kisayol.Veritabani_Combobox_Veri(combo_ilce_sec, sorgum, "ilceAdi");
            }
            else if (kisayol.yetkim ==2)
            {
                String sorgum = "Select ilce.ilce_ID,ilce.ilceAdi from Iller_Tablosu as il JOIN Ilceler_Tablosu as ilce on il.il_ID = ilce.il_id Where il.il_ID = '"+kisayol.Il_Id+"'";
                kisayol.Veritabani_Combobox_Veri(combo_ilce_sec, sorgum, "ilceAdi");
            }
            
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_il_ismi.Text = "";
            txt_ilce_ismi.Text = "";
            txt_semt_ismi.Text = "";
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Sehirler_ekran sehir = new Sehirler_ekran(kisayol.yetkim, kisayol.Gorevli_ID, kisayol.Il_Id, kisayol.ilce_ID);
            if (kisayol.yetkim == 1)
            {
                if (txt_il_ismi.Text == String.Empty)
                {
                    kisayol.mesajBox_Basit("(*) Yildizli Alanlari Bos birakmayiniz.");
                }
                else
                {
                        baglanti.Open();
                        String sorgu = " Insert into Iller_Tablosu (ilAdi) Values (@il)";
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);
                        komut.Parameters.AddWithValue("@il", txt_il_ismi.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                     
                        kisayol.mesajBox_Butonlu("Yeni Il kaydi basariyla tamamlandi !!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();                  
                }
            }
                 else if (kisayol.yetkim == 2)
                {
                if ( txt_ilce_ismi.Text == String.Empty)
                {
                    kisayol.mesajBox_Basit("(*) Yildizli Alanlari Bos birakmayiniz.");
                }
                else
                {
                    baglanti.Open();
                    String sorgu = "INSERT INTO Iller_Tablosu (ilAdi) VALUES (@il); INSERT INTO Ilceler_Tablosu(il_id) Select TOP 1 il_ID from Iller_Tablosu ORDER BY il_ID DESC";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@il", txt_il_ismi.Text);
                    komut.ExecuteNonQuery();

                    sehir.combo_iller.Items.Add(txt_il_ismi.Text);
                    baglanti.Close();

                    kisayol.mesajBox_Butonlu("Yeni Ilce kaydi basariyla tamamlandi !!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();                
                }
            }
        }

        private void comboBox_il_sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kisayol.yetkim == 1)
            {
                String ilce = "Select distinct ilce.ilce_ID, ilce.ilceAdi from dbo.Iller_Tablosu as il Join dbo.Ilceler_Tablosu as ilce ON il.il_ID = ilce.il_ID Where il.ilAdi = '" + comboBox_il_sec.Text + "' ORDER BY ilce.ilceAdi ASC";
                kisayol.Veritabani_Combobox_Veri(combo_ilce_sec, ilce, "ilceAdi");
            }
          
        }

        private void btn_IlceEkle_Click(object sender, EventArgs e)
        {
            Sehirler_ekran sehir = new Sehirler_ekran(kisayol.yetkim, kisayol.Gorevli_ID, kisayol.Il_Id, kisayol.ilce_ID);
            btn_IlceEkle.TabIndex = 3;
            if (kisayol.yetkim == 1)
            {
                int il_id;
                if (txt_ilce_ismi.Text == String.Empty)
                {
                    kisayol.mesajBox_Basit("(*) Yildizli Alanlari Bos birakmayiniz.");
                }
                else
                {                  
                    String sorgu1 = "select il_ID from Iller_Tablosu where ilAdi = '"+comboBox_il_sec.Text+"'";
                    SqlCommand komut_idcek = new SqlCommand(sorgu1, baglanti);
                    baglanti.Open();
                    object il_ID = komut_idcek.ExecuteScalar();
                    il_id = Convert.ToInt32(il_ID);
                    baglanti.Close();

                    String sorgu = " Insert into Ilceler_Tablosu (ilceAdi,il_id) Values (@ilce, @ID)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    baglanti.Open();
                    komut.Parameters.AddWithValue("@ilce", txt_ilce_ismi.Text);
                    komut.Parameters.AddWithValue("@ID", il_ID);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
            else if (kisayol.yetkim == 2)
            {
                if (txt_ilce_ismi.Text == String.Empty)
                {
                    kisayol.mesajBox_Basit("(*) Yildizli Alanlari Bos birakmayiniz.");
                }
                else
                {
                    String sorgu = " Insert into Ilceler_Tablosu (ilceAdi,il_id) Values (@ilce, @ID)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    baglanti.Open();
                    komut.Parameters.AddWithValue("@ilce", txt_ilce_ismi.Text);
                    komut.Parameters.AddWithValue("@ID", kisayol.Il_Id);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
            kisayol.mesajBox_Butonlu("Yeni Ilce kaydi basariyla tamamlandi !!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btn_semtEkle_Click(object sender, EventArgs e)
        {
            btn_semtEkle.TabIndex = 3;
            Sehirler_ekran sehir = new Sehirler_ekran(kisayol.yetkim, kisayol.Gorevli_ID, kisayol.Il_Id, kisayol.ilce_ID);
            if (kisayol.yetkim == 1)
            {
                int ilce_idsi;
                if (txt_semt_ismi.Text == String.Empty)
                {
                    kisayol.mesajBox_Basit("(*) Yildizli Alanlari Bos birakmayiniz.");
                }
                else
                {
                        String sorgu1 = "select ilce_ID,ilceAdi from Ilceler_Tablosu where ilceAdi ='" + combo_ilce_sec.Text + "'";
                        SqlCommand komut_idcek = new SqlCommand(sorgu1, baglanti);
                        baglanti.Open();
                        object ilce_ID = komut_idcek.ExecuteScalar();
                        ilce_idsi = Convert.ToInt32(ilce_ID);
                        baglanti.Close();
                        
                        String sorgu = " Insert into Semt_Tablo (semtAdi,ilce_ID) Values (@semt, @ID)";
                        SqlCommand komut = new SqlCommand(sorgu, baglanti);
                        baglanti.Open();
                        komut.Parameters.AddWithValue("@semt", txt_semt_ismi.Text);
                        komut.Parameters.AddWithValue("@ID", ilce_idsi);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                }       
            }
            else if (kisayol.yetkim == 2)
            {
                if (txt_semt_ismi.Text == String.Empty)
                {
                    kisayol.mesajBox_Basit("(*) Yildizli Alanlari Bos birakmayiniz.");
                }
                else
                {
                    String sorgu1 = "select ilce_ID,ilceAdi from Ilceler_Tablosu where ilceAdi ='" + combo_ilce_sec.Text + "'";
                    SqlCommand komut_idcek = new SqlCommand(sorgu1, baglanti);
                    baglanti.Open();
                    object ilce_ID = komut_idcek.ExecuteScalar();
                    baglanti.Close();

                    baglanti.Open();
                    String sorgu = "insert into Semt_Tablo(semtAdi,ilce_ID) Values (@semt,@id)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@semt", txt_semt_ismi.Text);
                    komut.Parameters.AddWithValue("@id", ilce_ID);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
            kisayol.mesajBox_Butonlu("Yeni Semt kaydi basariyla tamamlandi !!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();

        }

        private void combo_ilce_sec_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
