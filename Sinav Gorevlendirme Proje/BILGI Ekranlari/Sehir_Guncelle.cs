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
    public partial class Sehir_Guncelle : Form
    {
        public Sehir_Guncelle(int il, int ilce)
        {
            InitializeComponent();
            il_IDsi  = il;
            ilce_IDsi = ilce;
        }

        SqlConnection baglanti = new SqlConnection("Data Source=COMPUTER\\MSSQLSERVERR;Initial Catalog=SinavGorevlendirme;Integrated Security=True");
        KisaYollar kisayol = new KisaYollar();
        bool kontrol;
        int il_IDsi, ilce_IDsi;
        private void Sehir_Guncelle_Load(object sender, EventArgs e)
        {

        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Sehirler_ekran sehir = new Sehirler_ekran(kisayol.yetkim, kisayol.Gorevli_ID, kisayol.Il_Id, kisayol.ilce_ID);

            String sorgu = "update Iller_Tablosu SET ilAdi = @yeni Where il_ID = '" + il_IDsi + "' ";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@yeni", textBox1.Text);
             
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Bilgiler Basariyla Guncellendi !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close(); 
        }

        private void btn_ilce_Click(object sender, EventArgs e)
        {
            Sehirler_ekran sehir = new Sehirler_ekran(kisayol.yetkim, kisayol.Gorevli_ID, kisayol.Il_Id, kisayol.ilce_ID);

            String sorgu = "update Ilceler_Tablosu SET ilceAdi = @yeni Where ilce_ID = '" + ilce_IDsi + "' ";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@yeni", textBox1.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Bilgiler Basariyla Guncellendi !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close(); 
        }
    }
}
