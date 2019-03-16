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
    public partial class Sinav_Islemler : Form
    {
        public Sinav_Islemler(int yetki, int il_ID,int ilce_id,int semt_id, int gorevli_id, int binaID)
        {
            InitializeComponent();
            kisayol.yetkim = yetki;
            kisayol.Il_Id = il_ID;
            kisayol.ilce_ID = ilce_id;
            kisayol.semt_Id = semt_id;
            kisayol.Gorevli_ID = gorevli_id;
            kisayol.bina_ID = binaID;
            MaximizeBox = false;

        }
        KisaYollar kisayol = new KisaYollar();
        SqlConnection baglanti = new SqlConnection("Data Source=COMPUTER\\MSSQLSERVERR;Initial Catalog=SinavGorevlendirme;Integrated Security=True");
        public int secilen;
        private void Sinav_Islemler_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label6.Hide();
            textBox1.Hide();
            textBox2.Hide();
            groupBox_Sorumlu_Ara.Hide();
            datagridView_sinav_Sorumlular.Hide();
            btn_geriDon.Hide();

            datagridview_sinav();
        }
        

        private void datagridView_SinavListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            Sinav_Detay kimlik = new Sinav_Detay(kisayol.Gorevli_ID, kisayol.bina_ID);
            
            if(e.ColumnIndex == 0)
            {
                kimlik.ShowDialog();
                this.Visible = true;
            }
        }

        private void yeniSinavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yeni_Sinav_Ekle yeniSinav = new Yeni_Sinav_Ekle(kisayol.yetkim, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id,kisayol.Gorevli_ID);
            this.Hide();
            
            if(yeniSinav.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                datagridview_sinav();
            }
            this.Show();
        }

        private void yeniSınavSorumlusuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.groupBox_sinav_Ara.Hide();
            this.datagridView_SinavListesi.Hide();

            lbl_baslik.Text = "Sınav Sorumlu Bilgileri";
            groupBox_Sorumlu_Ara.Location = new Point(44, 54);
            groupBox_Sorumlu_Ara.Show();
            datagridView_sinav_Sorumlular.Size = new Size(1188, 348);
            datagridView_sinav_Sorumlular.Location = new Point(9, 230);
            datagridView_sinav_Sorumlular.Show();
            btn_geriDon.Show();

            if (kisayol.yetkim == 1)
            {
                baglanti.Open();
                String sorumlu = "select k.kimlikNO[Kimlik NO],k.Isim[İsim],k.Soyisim[Soysim],k.CepNO[Cep Numarası], k.eposta[e-Posta] ,bina.binaAdi[Bağlı olduğu Bina/Okul adı], bina.AcikAdres[Binanın Açık Adresi], il.ilAdi[Bağlı olduğu İl Adı],ilce.ilceAdi[Bağlı olduğu İlçe Adı] from Kullanicilar as k Join BinaBilgileri as bina    on bina.bina_ID = k.binaID  JOIN Iller_Tablosu as il  on il.il_ID = k.il_ID Join Ilceler_Tablosu as ilce on ilce.ilce_ID = k.ilce_JD ";
                SqlDataAdapter veriler = new SqlDataAdapter(sorumlu, baglanti);

                DataTable tablo = new DataTable();
                veriler.Fill(tablo);
                datagridView_sinav_Sorumlular.DataSource = tablo;
                veriler.Dispose();
                baglanti.Close();

                datagridView_sinav_Sorumlular.Columns[0].Width = 125;
                datagridView_sinav_Sorumlular.Columns[1].Width = 130;
                datagridView_sinav_Sorumlular.Columns[2].Width = 130;
                datagridView_sinav_Sorumlular.Columns[3].Width = 155;
                datagridView_sinav_Sorumlular.Columns[4].Width = 190;
                datagridView_sinav_Sorumlular.Columns[5].Width = 195;
                datagridView_sinav_Sorumlular.Columns[6].Width = 110;
                datagridView_sinav_Sorumlular.Columns[7].Width = 110;
                datagridView_sinav_Sorumlular.Columns[8].Width = 110;
                baglanti.Close();
            }
            else if (kisayol.yetkim == 2)
            {
                baglanti.Open();
                String sorumlu = "select k.kimlikNO[Kimlik NO],k.Isim[İsim],k.Soyisim[Soysim],k.CepNO[Cep Numarası], k.eposta[e-Posta] ,bina.binaAdi[Bağlı olduğu Bina/Okul adı], bina.AcikAdres[Binanın Açık Adresi], il.ilAdi[Bağlı olduğu İl Adı],ilce.ilceAdi[Bağlı olduğu İlçe Adı] from Kullanicilar as k Join BinaBilgileri as bina    on bina.bina_ID = k.binaID  JOIN Iller_Tablosu as il  on il.il_ID = k.il_ID Join Ilceler_Tablosu as ilce on ilce.ilce_ID = k.ilce_JD Where k.il_ID = '" + kisayol.Il_Id + "' AND k.Yetki_Gorevi = 7";
                SqlDataAdapter veriler = new SqlDataAdapter(sorumlu, baglanti);

                DataTable tablo = new DataTable();
                veriler.Fill(tablo);
                datagridView_sinav_Sorumlular.DataSource = tablo;
                veriler.Dispose();
                baglanti.Close();

                datagridView_sinav_Sorumlular.Columns[0].Width = 125;
                datagridView_sinav_Sorumlular.Columns[1].Width = 130;
                datagridView_sinav_Sorumlular.Columns[2].Width = 130;
                datagridView_sinav_Sorumlular.Columns[3].Width = 155;
                datagridView_sinav_Sorumlular.Columns[4].Width = 190;
                datagridView_sinav_Sorumlular.Columns[5].Width = 195;
                datagridView_sinav_Sorumlular.Columns[6].Width = 110;
                datagridView_sinav_Sorumlular.Columns[7].Width = 110;
            }
            else if (kisayol.yetkim == 3)
            {
                baglanti.Open();
                String sorumlu = "select k.kimlikNO[Kimlik NO],k.Isim[İsim],k.Soyisim[Soysim],k.CepNO[Cep Numarası], k.eposta[e-Posta] ,bina.binaAdi[Bağlı olduğu Bina/Okul adı], bina.AcikAdres[Binanın Açık Adresi], il.ilAdi[Bağlı olduğu İl Adı],ilce.ilceAdi[Bağlı olduğu İlçe Adı] from Kullanicilar as k Join BinaBilgileri as bina    on bina.bina_ID = k.binaID  JOIN Iller_Tablosu as il  on il.il_ID = k.il_ID Join Ilceler_Tablosu as ilce on ilce.ilce_ID = k.ilce_JD Where k.il_ID = '" + kisayol.Il_Id + "' AND k.Yetki_Gorevi = 7";
                SqlDataAdapter veriler = new SqlDataAdapter(sorumlu, baglanti);

                DataTable tablo = new DataTable();
                veriler.Fill(tablo);
                datagridView_sinav_Sorumlular.DataSource = tablo;
                veriler.Dispose();
                baglanti.Close();

            }
            else if (kisayol.yetkim == 4)
            {
                baglanti.Open();
                String cumle = "select k.kimlikNO[Kimlik NO],k.Isim[İsim],k.Soyisim[Soysim],k.CepNO[Cep Numarası], k.eposta[e-Posta] ,bina.binaAdi[Bağlı olduğu Bina/Okul adı], bina.AcikAdres[Binanın Açık Adresi], il.ilAdi[Bağlı olduğu İl Adı],ilce.ilceAdi[Bağlı olduğu İlçe Adı] from Kullanicilar as k Join BinaBilgileri as bina    on bina.bina_ID = k.binaID  JOIN Iller_Tablosu as il  on il.il_ID = k.il_ID Join Ilceler_Tablosu as ilce on ilce.ilce_ID = k.ilce_JD Where k.ilce_JD = '"+kisayol.ilce_ID+"' AND k.Yetki_Gorevi = 7";
                SqlDataAdapter veriler = new SqlDataAdapter(cumle, baglanti);

                DataTable tablo = new DataTable();
                veriler.Fill(tablo);
                datagridView_sinav_Sorumlular.DataSource = tablo;
                veriler.Dispose();
                baglanti.Close();

                datagridView_sinav_Sorumlular.Columns[0].Width = 145;
                datagridView_sinav_Sorumlular.Columns[1].Width = 150;
                datagridView_sinav_Sorumlular.Columns[2].Width = 150;
                datagridView_sinav_Sorumlular.Columns[3].Width = 155;
                datagridView_sinav_Sorumlular.Columns[4].Width = 210;
                datagridView_sinav_Sorumlular.Columns[5].Width = 225;
                datagridView_sinav_Sorumlular.Columns[6].Width = 110;
                baglanti.Close();
            }
            if (kisayol.yetkim == 5)
            {
                String cumle = " select k.Isim[İsim],k.Soyisim[Soyisim],k.Unvan[Ünvan],k.CepNO[Cep Numarası], k.eposta[E-Posta Adresi] ,bina.binaAdi[Bağlı olduğu Bina Adı] from BinaBilgileri as bina Join Sinav_Bilgileri as sinav on bina.bina_ID = sinav.bina_ID JOIN Kullanicilar as k on k.binaID = bina.bina_ID Where k.binaID = '" + kisayol.bina_ID + "'";

                baglanti.Open();

                SqlDataAdapter veriler = new SqlDataAdapter(cumle, baglanti);

                DataTable tablo = new DataTable();
                veriler.Fill(tablo);
                datagridView_sinav_Sorumlular.DataSource = tablo;
                veriler.Dispose();
                baglanti.Close();
               
                datagridView_sinav_Sorumlular.Columns[0].Width = 160;
                datagridView_sinav_Sorumlular.Columns[1].Width = 160;
                datagridView_sinav_Sorumlular.Columns[2].Width = 160;
                datagridView_sinav_Sorumlular.Columns[3].Width = 160;
                datagridView_sinav_Sorumlular.Columns[4].Width = 220;
                datagridView_sinav_Sorumlular.Columns[5].Width = 220;
              
            }
            if (kisayol.yetkim == 6)
            {
                String cumle = " select k.Isim[İsim],k.Soyisim[Soyisim],k.Unvan[Ünvan],k.CepNO[Cep Numarası], k.eposta[E-Posta Adresi] ,bina.binaAdi[Bağlı olduğu Bina Adı] from BinaBilgileri as bina Join Sinav_Bilgileri as sinav on bina.bina_ID = sinav.bina_ID JOIN Kullanicilar as k on k.binaID = bina.bina_ID Where k.binaID = '" + kisayol.bina_ID + "'";

                baglanti.Open();

                SqlDataAdapter veriler = new SqlDataAdapter(cumle, baglanti);

                DataTable tablo = new DataTable();
                veriler.Fill(tablo);
                datagridView_sinav_Sorumlular.DataSource = tablo;
                veriler.Dispose();
                baglanti.Close();
              
                datagridView_sinav_Sorumlular.Columns[0].Width = 160;
                datagridView_sinav_Sorumlular.Columns[1].Width = 160;
                datagridView_sinav_Sorumlular.Columns[2].Width = 160;
                datagridView_sinav_Sorumlular.Columns[3].Width = 160;
                datagridView_sinav_Sorumlular.Columns[4].Width = 220;
                datagridView_sinav_Sorumlular.Columns[5].Width = 220;
               
            }
        }
        private void yeniSorumluEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void btn_geriDon_Click(object sender, EventArgs e)
        {
            datagridView_sinav_Sorumlular.Hide();
            groupBox_Sorumlu_Ara.Hide();
            datagridView_SinavListesi.Show();
            groupBox_sinav_Ara.Show();
            lbl_baslik.Text = "Sınav Bilgileri";
            btn_geriDon.Hide();
        }

        private void txt_Gorevli_Ara_TextChanged(object sender, EventArgs e)
        {
            BindingSource veri = new BindingSource();
            veri.DataSource = datagridView_SinavListesi.DataSource;
            veri.Filter = "[Sinav Gorevlisi] LIKE '%" + txt_Gorevli_Ara.Text + "%'";
            datagridView_SinavListesi.DataSource = veri;
        }
        private void txt_Acikad_TextChanged(object sender, EventArgs e)
        {
            BindingSource veri = new BindingSource();
            veri.DataSource = datagridView_SinavListesi.DataSource;
            veri.Filter = "[Sınav Açık Adı] LIKE '%" + txt_Acikad.Text + "%'";
            
            datagridView_SinavListesi.DataSource = veri;
        }
        private void txt_kisaAd_ara_TextChanged(object sender, EventArgs e)
        {
            BindingSource veri = new BindingSource();
            veri.DataSource = datagridView_SinavListesi.DataSource;
            veri.Filter = "[Sınav Kısa Adı] LIKE '%" + txt_kisaAd_ara.Text + "%'";
            datagridView_SinavListesi.DataSource = veri;
        }

        private void datagridView_SinavListesi_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Sinav_Detay kimlik = new Sinav_Detay(kisayol.Gorevli_ID,kisayol.bina_ID);
            int secilen_Satir = e.RowIndex;
            DataGridViewRow satirim = datagridView_SinavListesi.Rows[secilen_Satir];

            kimlik.groupBox2.Hide();
            kimlik.groupBox1.Location = new Point(12, 144);
            kimlik.lbl_sinavAcik_adi.Text = satirim.Cells[0].Value.ToString();
            kimlik.lbl_sinavKisa_adi.Text  = satirim.Cells[1].Value.ToString();
            kimlik.lbl_SinavDonemi.Text  = satirim.Cells[2].Value.ToString();
            kimlik.lbl_sinavTarih.Text  = satirim.Cells[3].Value.ToString();
            kimlik.lbl_sinavSaat.Text = satirim.Cells[4].Value.ToString();
            kimlik.lbl_SinavSure.Text = satirim.Cells[5].Value.ToString() + " dk ";

            kimlik.ShowDialog();
        }
        private void sınavSorumluListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void txt_kimlikAra_TextChanged(object sender, EventArgs e)
        {
            BindingSource data = new BindingSource();
            data.DataSource = datagridView_sinav_Sorumlular.DataSource;
            data.Filter = "[Kimlik NO] LIKE '%" + txt_kimlikAra.Text + "%'";
            datagridView_sinav_Sorumlular.DataSource = data;
        }
         
        private void txt_isimAra_TextChanged(object sender, EventArgs e)
        {
            BindingSource data = new BindingSource();
            data.DataSource = datagridView_sinav_Sorumlular.DataSource;
            data.Filter = "[İsim] LIKE '%" + txt_isimAra.Text + "%'";
            datagridView_sinav_Sorumlular.DataSource = data;
        }

        private void txt_Il_ara_TextChanged(object sender, EventArgs e)
        {
            BindingSource data = new BindingSource();
            data.DataSource = datagridView_sinav_Sorumlular.DataSource;
            data.Filter = "[Soysim] LIKE '%" + txt_Il_ara.Text + "%'";
            datagridView_sinav_Sorumlular.DataSource = data;
        }
        private void datagridview_sinav()
        {
            if (kisayol.yetkim == 1)
            {
                String cumle = " Select sinav.acikAdi [Sınav Açık Adı],sinav.kisaAdi [Sınav Kısa Adı],sinav.Donemi [Sınav Dönemi],sinav.Tarihi [Sınav Tarihi],sinav.Saati[Sınav Saati],sinav.Suresi[Sinav Süresi (dakika)],bina.binaAdi [Binanin Adi],k.Isim+' '+k.Soyisim [Sinav Gorevlisi],il.ilAdi[Sınav İli],ilce.ilceAdi[Sınav İlçesi] from Sinav_Bilgileri as sinav JOIN BinaBilgileri as bina on bina.bina_ID = sinav.bina_ID Join Kullanicilar as k on k.gorevliID = sinav.gorevliID Join Iller_Tablosu as il on il.il_ID = sinav.il_ID Join Ilceler_Tablosu as ilce on ilce.ilce_ID = sinav.ilce_ID";
                kisayol.sinav_Datagridview(cumle, datagridView_SinavListesi);
            }
            else if (kisayol.yetkim == 2)
            {
                String cumle = " Select sinav.acikAdi [Sınav Açık Adı],sinav.kisaAdi [Sınav Kısa Adı],sinav.Donemi [Sınav Dönemi],sinav.Tarihi [Sınav Tarihi],sinav.Saati[Sınav Saati],sinav.Suresi[Sinav Süresi (dakika)],bina.binaAdi [Binanin Adi],k.Isim+' '+k.Soyisim [Sinav Gorevlisi],il.ilAdi[Sınav İli],ilce.ilceAdi[Sınav İlçesi] from Sinav_Bilgileri as sinav JOIN BinaBilgileri as bina on bina.bina_ID = sinav.bina_ID Join Kullanicilar as k on k.gorevliID = sinav.gorevliID Join Iller_Tablosu as il on il.il_ID = sinav.il_ID Join Ilceler_Tablosu as ilce on ilce.ilce_ID = sinav.ilce_ID Where il.il_ID = '" + kisayol.Il_Id + "'";
                kisayol.sinav_Datagridview(cumle, datagridView_SinavListesi);
            }
            else if (kisayol.yetkim == 3)
            {
                String cumle = " Select sinav.acikAdi [Sınav Açık Adı],sinav.kisaAdi [Sınav Kısa Adı],sinav.Donemi [Sınav Dönemi],sinav.Tarihi [Sınav Tarihi],sinav.Saati[Sınav Saati],sinav.Suresi[Sinav Süresi (dakika)],bina.binaAdi [Binanin Adi],k.Isim+' '+k.Soyisim [Sinav Gorevlisi],il.ilAdi[Sınav İli],ilce.ilceAdi[Sınav İlçesi] from Sinav_Bilgileri as sinav JOIN BinaBilgileri as bina on bina.bina_ID = sinav.bina_ID Join Kullanicilar as k on k.gorevliID = sinav.gorevliID Join Iller_Tablosu as il on il.il_ID = sinav.il_ID Join Ilceler_Tablosu as ilce on ilce.ilce_ID = sinav.ilce_ID Where il.il_ID = '" + kisayol.Il_Id + "'";
                kisayol.sinav_Datagridview(cumle, datagridView_SinavListesi);
            }
            else if (kisayol.yetkim == 4)
            {
                String cumle = "Select sinav.acikAdi [Sınav Açık Adı],sinav.kisaAdi [Sınav Kısa Adı],sinav.Donemi [Sınav Dönemi],sinav.Tarihi [Sınav Tarihi],sinav.Saati[Sınav Saati],sinav.Suresi[Sinav Süresi (dakika)],bina.binaAdi [Binanin Adi],k.Isim+' '+k.Soyisim [Sinav Gorevlisi],ilce.ilceAdi[Sınav İlçesi] from Sinav_Bilgileri as sinav JOIN BinaBilgileri as bina on bina.bina_ID = sinav.bina_ID Join Kullanicilar as k on k.gorevliID = sinav.gorevliID Join Iller_Tablosu as il on il.il_ID = sinav.il_ID Join Ilceler_Tablosu as ilce on ilce.ilce_ID = sinav.ilce_ID Where ilce.ilce_ID = '"+kisayol.ilce_ID+"'";
                baglanti.Open();

                SqlDataAdapter doldur = new SqlDataAdapter(cumle, baglanti);
                DataTable tablo = new DataTable();
                doldur.Fill(tablo);

                datagridView_SinavListesi.DataSource = tablo;
                datagridView_SinavListesi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagridView_SinavListesi.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagridView_SinavListesi.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagridView_SinavListesi.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                datagridView_SinavListesi.Columns[0].Width = 230;
                datagridView_SinavListesi.Columns[1].Width = 120;
                datagridView_SinavListesi.Columns[2].Width = 150;
                datagridView_SinavListesi.Columns[3].Width = 149;
                datagridView_SinavListesi.Columns[4].Width = 105;
                datagridView_SinavListesi.Columns[5].Width = 110;
                datagridView_SinavListesi.Columns[6].Width = 170;
                datagridView_SinavListesi.Columns[7].Width = 110;
                datagridView_SinavListesi.Columns[8].Width = 110;
                doldur.Dispose();
                baglanti.Close();

                lbl_ilceler.Text = "Ilce'ye Gore Ara :";
                lbl_ilceler.Location = new Point(58, 116);
            }
            else if (kisayol.yetkim == 5)
            {
                String cumle = "Select sinav.acikAdi [Sınav Açık Adı],sinav.kisaAdi [Sınav Kısa Adı],sinav.Donemi [Sınav Dönemi],sinav.Tarihi [Sınav Tarihi],sinav.Saati[Sınav Saati],sinav.Suresi[Sinav Süresi (dakika)],bina.binaAdi [Binanin Adi],k.Isim+' '+k.Soyisim [Sinav Gorevlisi],ilce.ilceAdi[Sınav İlçesi] from Sinav_Bilgileri as sinav JOIN BinaBilgileri as bina on bina.bina_ID = sinav.bina_ID Join Kullanicilar as k on k.gorevliID = sinav.gorevliID Join Iller_Tablosu as il on il.il_ID = sinav.il_ID Join Ilceler_Tablosu as ilce  on ilce.ilce_ID = sinav.ilce_ID  Where bina.bina_ID = '" + kisayol.bina_ID + "'";
                baglanti.Open();

                SqlDataAdapter doldur = new SqlDataAdapter(cumle, baglanti);
                DataTable tablo = new DataTable();

                doldur.Fill(tablo);
                datagridView_SinavListesi.DataSource = tablo;
                datagridView_SinavListesi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagridView_SinavListesi.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagridView_SinavListesi.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagridView_SinavListesi.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                doldur.Dispose();
                baglanti.Close();

                datagridView_SinavListesi.Columns[0].Width = 230;
                datagridView_SinavListesi.Columns[1].Width = 120;
                datagridView_SinavListesi.Columns[2].Width = 150;
                datagridView_SinavListesi.Columns[3].Width = 149;
                datagridView_SinavListesi.Columns[4].Width = 105;
                datagridView_SinavListesi.Columns[5].Width = 110;
                datagridView_SinavListesi.Columns[6].Width = 170;
                datagridView_SinavListesi.Columns[7].Width = 170;
                datagridView_SinavListesi.Columns[8].Width = 120;

            }
            else if (kisayol.yetkim == 6)
            {

                String cumle = "Select sinav.acikAdi [Sınav Açık Adı],sinav.kisaAdi [Sınav Kısa Adı],sinav.Donemi [Sınav Dönemi],sinav.Tarihi [Sınav Tarihi],sinav.Saati[Sınav Saati],sinav.Suresi[Sinav Süresi (dakika)],bina.binaAdi [Binanin Adi],k.Isim+' '+k.Soyisim [Sinav Gorevlisi],ilce.ilceAdi[Sınav İlçesi] from Sinav_Bilgileri as sinav JOIN BinaBilgileri as bina on bina.bina_ID = sinav.bina_ID Join Kullanicilar as k on k.gorevliID = sinav.gorevliID Join Iller_Tablosu as il on il.il_ID = sinav.il_ID Join Ilceler_Tablosu as ilce  on ilce.ilce_ID = sinav.ilce_ID  Where bina.bina_ID = '" + kisayol.bina_ID + "'";
                baglanti.Open();

                SqlDataAdapter doldur = new SqlDataAdapter(cumle, baglanti);
                DataTable tablo = new DataTable();

                doldur.Fill(tablo);
                datagridView_SinavListesi.DataSource = tablo;
                datagridView_SinavListesi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagridView_SinavListesi.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagridView_SinavListesi.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                datagridView_SinavListesi.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                doldur.Dispose();
                baglanti.Close();

                datagridView_SinavListesi.Columns[0].Width = 230;
                datagridView_SinavListesi.Columns[1].Width = 120;
                datagridView_SinavListesi.Columns[2].Width = 150;
                datagridView_SinavListesi.Columns[3].Width = 149;
                datagridView_SinavListesi.Columns[4].Width = 105;
                datagridView_SinavListesi.Columns[5].Width = 110;
                datagridView_SinavListesi.Columns[6].Width = 170;
                datagridView_SinavListesi.Columns[7].Width = 170;
                datagridView_SinavListesi.Columns[8].Width = 120;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            BindingSource data = new BindingSource();
            data.DataSource = datagridView_sinav_Sorumlular.DataSource;
            data.Filter = "[Cep Numarası] LIKE '%" + textBox3.Text + "%'";
            datagridView_sinav_Sorumlular.DataSource = data;
        }
    }
}
