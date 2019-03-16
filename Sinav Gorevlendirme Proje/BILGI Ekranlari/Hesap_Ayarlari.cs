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
    public partial class Hesap_Ayarlari : Form
    {
        public Hesap_Ayarlari(int ID)
        {
            InitializeComponent();
            kisayol.Gorevli_ID = ID;
        }
        KisaYollar kisayol = new KisaYollar();
        SqlConnection baglanti = new SqlConnection("Data Source=COMPUTER\\MSSQLSERVERR;Initial Catalog=SinavGorevlendirme;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        
        private void Hesap_Ayarlari_Load(object sender, EventArgs e)
        {
            txt_eskiSifre.MaxLength = 20;
            txt_yeniSifre.MaxLength = 20;
            txt_yeniSifre2.MaxLength = 20;
        }
        private void check_sifreGoste_CheckedChanged(object sender, EventArgs e)
        {
            if (check_sifreGoste.Checked)
            {
                kisayol.passwordChar_true(txt_eskiSifre);
                kisayol.passwordChar_true(txt_yeniSifre);
                kisayol.passwordChar_true(txt_yeniSifre2);
            }
            else
            {

                kisayol.passwordChar_false(txt_eskiSifre);
                kisayol.passwordChar_false(txt_yeniSifre);
                kisayol.passwordChar_false(txt_yeniSifre2);
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_eskiSifre.Text = "";
            txt_yeniSifre.Text = "";
            txt_yeniSifre2.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            kisayol.password = txt_eskiSifre.Text;
            kisayol.yeniSifre = txt_yeniSifre.Text;
            SqlCommand komut = new SqlCommand("select * from Kullanicilar Where gorevliID = @gorevli", baglanti);
            komut.Parameters.AddWithValue("@gorevli", kisayol.Gorevli_ID);
            SqlDataReader veriler = komut.ExecuteReader();
            try
            {           
                if (txt_eskiSifre.Text == String.Empty )
                {
                    kisayol.mesajBox_Basit("Lutfen Eski Sifrenizi Giriniz!!");
                }
                else if (txt_yeniSifre.Text == String.Empty && txt_yeniSifre2.Text == String.Empty)
                {
                    kisayol.mesajBox_Basit("Lutfen Yeni Sifrenizi Giriniz ..!!");

                }
                else if (kisayol.yeniSifre != txt_yeniSifre2.Text)
                {
                    kisayol.mesajBox_Basit("Yeni sifreler birbiriyle uyusmuyor !!");
                }
                else if(veriler.HasRows == false)
                {
                    kisayol.mesajBox_Butonlu("Eski şifrenizi yanlış girdiniz\nLütfen tekrar Denyenizi !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    while (veriler.Read())
                    {
                        kisayol.eskipass = Convert.ToString(veriler["password"]);

                        if (txt_eskiSifre.Text != kisayol.eskipass)
                        {
                            kisayol.mesajBox_Basit("**Eski Sifrenizi yanlis giridniz\nLutfen tekrar kontrol edin. !! ");
                            break;
                        }

                        else
                        {
                            veriler.Close();
                            SqlCommand komutt = new SqlCommand("Update Kullanicilar set password = @yenisifre Where gorevliID = @gorevli ", baglanti);
                            komutt.Parameters.AddWithValue("@yenisifre", kisayol.yeniSifre);
                            komutt.Parameters.AddWithValue("@gorevli", kisayol.Gorevli_ID);
                            komutt.ExecuteNonQuery();
                            kisayol.mesajBox_Butonlu("Şifreniz başarıyla güncellendi ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }}}
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                kisayol.mesajBox_Butonlu("Lutfen Baglantinizi kontrol edin", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }         
        }
    }
}
