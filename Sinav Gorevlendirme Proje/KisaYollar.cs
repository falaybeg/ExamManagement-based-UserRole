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
    class KisaYollar
    {
        public String username, password, kullaniciAdi,kullaniciSoyadi;
        public String eskipass, yeniSifre;
        public int yetkim;
        public int  Gorevli_ID, Il_Id, ilce_ID,semt_Id, bina_ID, secim_gorevli;


        SqlConnection baglanti = new SqlConnection("Data Source=COMPUTER\\SQLEXPRESS;Initial Catalog=SinavGorevlendirme;User ID=sa;Password=1995");

        public void buton_FlatStyle(Button butonom)
        {
            butonom.BackColor = Color.DarkTurquoise;
            butonom.FlatStyle = FlatStyle.Flat;
            butonom.FlatAppearance.MouseDownBackColor = Color.Turquoise;
            butonom.FlatAppearance.MouseOverBackColor = Color.Turquoise;
        }
        public void buton_FlatStyle_DarkBlue(Button butonom)
        {
            butonom.BackColor = Color.DarkGray;
            butonom.FlatStyle = FlatStyle.Flat;
            butonom.FlatAppearance.MouseDownBackColor = Color.Gray;
            butonom.FlatAppearance.MouseOverBackColor = Color.Gray;
        }
        public void exit_Form()
        {
            Application.Exit();
        }

        public void mesajBox_Butonlu(String mesaj, String baslik, MessageBoxButtons buton, MessageBoxIcon iconom)
        {
            MessageBox.Show(mesaj, baslik, buton, iconom);
        }
        public void mesajBox_Basit(String mesaj)
        {
            MessageBox.Show(mesaj);
        }


        public void buton_FlatStyle2(Button butonom)
        {
            butonom.FlatStyle = FlatStyle.Flat;
            butonom.BackColor = Color.YellowGreen;
        }

        public void Transparent_PictureBox(PictureBox resim)
        {
            resim.BackColor = Color.Transparent;
        }
        public void Transparent_Buton(Button buton)
        {
            buton.BackColor = Color.Transparent;
        }
        public void Transparent_Label(Label label)
        {
            label.BackColor = Color.Transparent;
        }

        public void passwordChar_true(TextBox textbox)
        {

            textbox.UseSystemPasswordChar = true;
        }
        public void passwordChar_false(TextBox textbox)
        {
            textbox.UseSystemPasswordChar = false;
        }

        public void combobox_Sil(ComboBox combo, String veri)
        {
            combo.Items.Remove(veri);
        }

        public void Random_Uret(TextBox textbox)
        {
            Random uret = new Random();

            String harf = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String ureti = "";
            for (int i = 0; i < 5; i++)
            {
                ureti = ureti + harf[uret.Next(harf.Length)];
            }
            textbox.Text = ureti;
        }
        public void Veritabani_Standart(String sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public void sinav_Datagridview(String cumle, DataGridView datagrid)
        {
            baglanti.Open();
            SqlDataAdapter doldur = new SqlDataAdapter(cumle, baglanti);
            DataTable tablo = new DataTable();
            doldur.Fill(tablo);
            datagrid.DataSource = tablo;

            datagrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            datagrid.Columns[0].Width = 260;
            datagrid.Columns[1].Width = 120;
            datagrid.Columns[2].Width = 130;
            datagrid.Columns[3].Width = 150;
            datagrid.Columns[4].Width = 105;
            datagrid.Columns[5].Width = 100;
            datagrid.Columns[6].Width = 170;
            datagrid.Columns[7].Width = 170;
            datagrid.Columns[8].Width = 135;
            datagrid.Columns[9].Width = 135;

            doldur.Dispose();
            baglanti.Close();
        }

        public void Veritabani_Bina_Ekle(TextBox cadde, TextBox sokak, ComboBox sokakNO, TextBox binaAdi, TextBox Acikadres, TextBox telefon, TextBox cepNO, TextBox fax)
        {
            baglanti.Open();
            String sorgu = "INSERT INTO BinaBilgileri(Cadde,Sokak,sokakNO,binaAdi,AcikAdres,Telefon,CepNO,Fax) VALUES(@cadde,@sokak,@sokakNO,@binaAdi,@acikAdres,@telefon,@cepNO,@fax)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@cadde", cadde.Text);
            komut.Parameters.AddWithValue("@sokak", sokak.Text);
            komut.Parameters.AddWithValue("@sokakNO", sokakNO.Text);
            komut.Parameters.AddWithValue("@binaAdi", binaAdi.Text);
            komut.Parameters.AddWithValue("@acikAdres", Acikadres.Text);
            komut.Parameters.AddWithValue("@telefon", telefon.Text);
            komut.Parameters.AddWithValue("@cepNO", cepNO.Text);
            komut.Parameters.AddWithValue("@fax", fax.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
                    
        }
        
        public void Veritabani_Combobox_Veri(ComboBox combo, String sorgu, String sutun/*, String sutunID */)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader veriler = komut.ExecuteReader();

            combo.Items.Clear();
            while(veriler.Read())
            {
                //dictionary tanımla
                //iladı ve il idyi dictionary değişkenine ata
                combo.Items.Add(veriler[sutun].ToString());
                
            }

            baglanti.Close();            
        }
             
          public void datagridview_ColumnName(String sorgu, int sutun_sayisi, DataGridView datagridview)
        {
            baglanti.Open();
            SqlDataAdapter doldur = new SqlDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();

            doldur.Fill(tablo);
            datagridview.ColumnCount = sutun_sayisi;    

            datagridview.Columns[0].Name = "kimlikNO";
            datagridview.Columns[0].HeaderText = "Kimlik No";
            datagridview.Columns[0].DataPropertyName = "kimlikNO";
            datagridview.Columns[0].Width = 150;

            datagridview.Columns[1].Name = "Isim";
            datagridview.Columns[1].HeaderText = "Isim";
            datagridview.Columns[1].DataPropertyName = "Isim";
            datagridview.Columns[1].Width = 140;


            datagridview.Columns[2].Name = "Soyisim";
            datagridview.Columns[2].HeaderText = "Soyisim No";
            datagridview.Columns[2].DataPropertyName = "Soyisim";
            datagridview.Columns[2].Width = 140;


            datagridview.Columns[3].Name = "Unvan";
            datagridview.Columns[3].HeaderText = "Ünvan";
            datagridview.Columns[3].DataPropertyName = "Unvan";
            datagridview.Columns[3].Width = 190;


            datagridview.Columns[4].Name = "CepNo";
            datagridview.Columns[4].HeaderText = "Cep NO";
            datagridview.Columns[4].DataPropertyName = "CepNo";
            datagridview.Columns[4].Width = 150;


            datagridview.Columns[5].Name = "ePosta";
            datagridview.Columns[5].HeaderText = "e-Posta";
            datagridview.Columns[5].DataPropertyName = "ePosta";
            datagridview.Columns[5].Width = 170;


            datagridview.Columns[6].Name = "YasadigiIL";
            datagridview.Columns[6].HeaderText = "Yaşadığı İL";
            datagridview.Columns[6].DataPropertyName = "YasadigiIL";
            datagridview.Columns[5].Width = 120;

          
            

            datagridview.DataSource = tablo;

            baglanti.Close();
        }
     
    }
}
