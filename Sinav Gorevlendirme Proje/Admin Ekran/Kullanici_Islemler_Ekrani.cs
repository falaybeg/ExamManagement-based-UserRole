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
    public partial class Kullanici_Islemler_Ekrani : Form
    {
        public Kullanici_Islemler_Ekrani(int yetki, int ID, int il_ID, int ilce)
        {
            InitializeComponent();
            kisayol.yetkim = yetki;
            kisayol.Gorevli_ID = ID;
            kisayol.Il_Id = il_ID;
            kisayol.ilce_ID = ilce;
            MaximizeBox = false;

        }
        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
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
        SqlCommand komut = new SqlCommand();
        int secilen_satir;
        private void Kullanici_Islemler_Ekrani_Load(object sender, EventArgs e)
        {
            label_g.Hide();
            //Yukle_combo();
            comboBox_poziyon.Hide();
            label6.Hide();
            btn_yeniKullanici_Ekle.BackColor = Color.Transparent;
            btn_yeniKullanici_Ekle.FlatAppearance.MouseDownBackColor = Color.DarkBlue;
            btn_yeniKullanici_Ekle.FlatAppearance.MouseOverBackColor = Color.DarkBlue;
            DataTable tablo = new DataTable();

            if (kisayol.yetkim == 1)
            {
                label_g.Show();
                label6.Show();
                comboBox_poziyon.Show();

                comboBox_poziyon.Items.Add(new Item("Genel Yönetici", 1));
                comboBox_poziyon.Items.Add(new Item("İl Yöneticisi", 2));
                comboBox_poziyon.Items.Add(new Item("İl Yardımcısı", 3));
                comboBox_poziyon.Items.Add(new Item("İlçe Yöneticisi", 4));
                comboBox_poziyon.Items.Add(new Item("Bina Yöneticisi", 5));
                comboBox_poziyon.Items.Add(new Item("Bina Yardımcısı", 6));
                comboBox_poziyon.Items.Add(new Item("Sınav Sorumlusu", 7));

                String cumle = "Select k.kimlikNO as [Kimlik NO],k.Isim [Isim],k.Soyisim [Soyisim],k.Unvan [Ünvanı],k.CepNO [Cep Numarası],k.eposta [e-Posta Adresi], k.Adress [Adresi], il.ilAdi [İl Adı] from Kullanicilar as k JOIN Iller_Tablosu as il on k.il_ID = il.il_ID Where gorevliID != '" + kisayol.Gorevli_ID + "'";

                SqlDataAdapter doldur = new SqlDataAdapter(cumle, baglanti);

                baglanti.Open();
                doldur.Fill(tablo);
                datagridView_kullanicilar.DataSource = tablo;
                doldur.Dispose();
                baglanti.Close();

                datagridView_kullanicilar.Columns[0].Width = 150;
                datagridView_kullanicilar.Columns[1].Width = 130;
                datagridView_kullanicilar.Columns[2].Width = 130;
                datagridView_kullanicilar.Columns[3].Width = 180;
                datagridView_kullanicilar.Columns[4].Width = 150;
                datagridView_kullanicilar.Columns[5].Width = 200;
                datagridView_kullanicilar.Columns[6].Width = 110;

            }
            else if (kisayol.yetkim == 2)
            {
                comboBox_poziyon.Items.Add(new Item("İl Yöneticisi", 2));
                comboBox_poziyon.Items.Add(new Item("İl Yardımcısı", 3));
                comboBox_poziyon.Items.Add(new Item("İlçe Yöneticisi", 4));
                comboBox_poziyon.Items.Add(new Item("Bina Yöneticisi", 5));
                comboBox_poziyon.Items.Add(new Item("Bina Yardımcısı", 6));
                comboBox_poziyon.Items.Add(new Item("Sınav Sorumlusu", 7));

                String cumle = " Select k.kimlikNO as [Kimlik NO],k.Isim [Isim],k.Soyisim [Soyisim],k.Unvan [Ünvanı],k.CepNO [Cep Numarası],k.eposta [e-Posta Adresi], il.ilAdi [İl Adı], ilce.ilceAdi [İlçe Adi]  from Kullanicilar as k join Iller_Tablosu as il on il.il_ID = k.il_ID Join Ilceler_Tablosu as ilce on  ilce.ilce_ID = k.ilce_JD Where gorevliID != '" + kisayol.Gorevli_ID + "' and k.il_ID = '" + kisayol.Il_Id + "' and k.Yetki_Gorevi > 1";
                SqlDataAdapter doldur = new SqlDataAdapter(cumle, baglanti);

                baglanti.Open();

                doldur.Fill(tablo);
                datagridView_kullanicilar.DataSource = tablo;

                doldur.Dispose();
                baglanti.Close();

                datagridView_kullanicilar.Columns[0].Width = 150;
                datagridView_kullanicilar.Columns[1].Width = 130;
                datagridView_kullanicilar.Columns[2].Width = 130;
                datagridView_kullanicilar.Columns[3].Width = 180;
                datagridView_kullanicilar.Columns[4].Width = 150;
                datagridView_kullanicilar.Columns[5].Width = 200;
                datagridView_kullanicilar.Columns[6].Width = 105;
                datagridView_kullanicilar.Columns[7].Width = 105;
            }
            else if (kisayol.yetkim == 3)
            {
                String cumle = " Select k.kimlikNO as [Kimlik NO],k.Isim [Isim],k.Soyisim [Soyisim],k.Unvan [Ünvanı],k.CepNO [Cep Numarası],k.eposta [e-Posta Adresi], il.ilAdi [İl Adı], ilce.ilceAdi [İlçe Adi]  from Kullanicilar as k join Iller_Tablosu as il on il.il_ID = k.il_ID Join Ilceler_Tablosu as ilce on  ilce.ilce_ID = k.ilce_JD Where gorevliID != '" + kisayol.Gorevli_ID + "' and k.il_ID = '" + kisayol.Il_Id + "' and k.Yetki_Gorevi > 2";
                SqlDataAdapter doldur = new SqlDataAdapter(cumle, baglanti);

                comboBox_poziyon.Items.Add(new Item("İl Yöneticisi", 2));
                comboBox_poziyon.Items.Add(new Item("İl Yardımcısı", 3));
                comboBox_poziyon.Items.Add(new Item("İlçe Yöneticisi", 4));
                comboBox_poziyon.Items.Add(new Item("Bina Yöneticisi", 5));
                comboBox_poziyon.Items.Add(new Item("Bina Yardımcısı", 6));
                comboBox_poziyon.Items.Add(new Item("Sınav Sorumlusu", 7));

                baglanti.Open();
                doldur.Fill(tablo);
                datagridView_kullanicilar.DataSource = tablo;
                doldur.Dispose();
                baglanti.Close();

                datagridView_kullanicilar.Columns[0].Width = 150;
                datagridView_kullanicilar.Columns[1].Width = 130;
                datagridView_kullanicilar.Columns[2].Width = 130;
                datagridView_kullanicilar.Columns[3].Width = 180;
                datagridView_kullanicilar.Columns[4].Width = 150;
                datagridView_kullanicilar.Columns[5].Width = 200;
                datagridView_kullanicilar.Columns[6].Width = 105;
                datagridView_kullanicilar.Columns[7].Width = 105;
            }
            else if (kisayol.yetkim == 4)
            {
                comboBox_poziyon.Items.Add(new Item("İlçe Yöneticisi", 4));
                comboBox_poziyon.Items.Add(new Item("Bina Yöneticisi", 5));
                comboBox_poziyon.Items.Add(new Item("Bina Yardımcısı", 6));
                comboBox_poziyon.Items.Add(new Item("Sınav Sorumlusu", 7));

                String cumle = "Select k.kimlikNO as [Kimlik NO],k.Isim [Isim],k.Soyisim [Soyisim],k.Unvan [Ünvanı],k.CepNO [Cep Numarası],k.eposta [e-Posta Adresi], il.ilAdi [İl Adı], ilce.ilceAdi [İlçe Adi] from Kullanicilar as k JOIN Iller_Tablosu as il on k.il_ID = il.il_ID JOIN Ilceler_Tablosu as ilce on k.ilce_JD = ilce.ilce_ID Where gorevliID != '"+kisayol.Gorevli_ID+"' and k.ilce_JD = '"+kisayol.ilce_ID+"' and k.Yetki_Gorevi > 3";
                SqlDataAdapter doldur = new SqlDataAdapter(cumle, baglanti);

                baglanti.Open();
                doldur.Fill(tablo);
                datagridView_kullanicilar.DataSource = tablo;
          
                baglanti.Close();

                datagridView_kullanicilar.Columns[0].Width = 150;
                datagridView_kullanicilar.Columns[1].Width = 130;
                datagridView_kullanicilar.Columns[2].Width = 130;
                datagridView_kullanicilar.Columns[3].Width = 180;
                datagridView_kullanicilar.Columns[4].Width = 150;
                datagridView_kullanicilar.Columns[5].Width = 200;
                datagridView_kullanicilar.Columns[6].Width = 105;
                datagridView_kullanicilar.Columns[7].Width = 105;
            }

            else if (kisayol.yetkim == 5)
            {

                comboBox_poziyon.Hide();
                label6.Hide();
               
                String cumle = "Select k.kimlikNO as [Kimlik NO],k.Isim [Isim],k.Soyisim [Soyisim],k.Unvan [Ünvanı],k.CepNO [Cep Numarası],k.eposta [e-Posta Adresi], il.ilAdi [İl Adı], ilce.ilceAdi [İlçe Adi]  from Kullanicilar as k join Iller_Tablosu as il on il.il_ID = k.il_ID Join Ilceler_Tablosu as ilce on  ilce.ilce_ID = k.ilce_JD Where k.binaID = '" + kisayol.bina_ID + "'";
                SqlDataAdapter doldur = new SqlDataAdapter(cumle, baglanti);
                
                baglanti.Open();
                doldur.Fill(tablo);
                datagridView_kullanicilar.DataSource = tablo;
                doldur.Dispose();
                baglanti.Close();

                datagridView_kullanicilar.Columns[0].Width = 150;
                datagridView_kullanicilar.Columns[1].Width = 130;
                datagridView_kullanicilar.Columns[2].Width = 130;
                datagridView_kullanicilar.Columns[3].Width = 180;
                datagridView_kullanicilar.Columns[4].Width = 150;
                datagridView_kullanicilar.Columns[5].Width = 200;
                datagridView_kullanicilar.Columns[6].Width = 105;
                datagridView_kullanicilar.Columns[7].Width = 105;
            }
            else if (kisayol.yetkim == 6)
            {
                comboBox_poziyon.Hide();
                label6.Hide();


                String cumle = "Select k.kimlikNO as [Kimlik NO],k.Isim [Isim],k.Soyisim [Soyisim],k.Unvan [Ünvanı],k.CepNO [Cep Numarası],k.eposta [e-Posta Adresi], il.ilAdi [İl Adı], ilce.ilceAdi [İlçe Adi]  from Kullanicilar as k join Iller_Tablosu as il on il.il_ID = k.il_ID Join Ilceler_Tablosu as ilce on  ilce.ilce_ID = k.ilce_JD Where k.binaID = '" + kisayol.bina_ID + "'";
                SqlDataAdapter doldur = new SqlDataAdapter(cumle, baglanti);

                baglanti.Open();
                doldur.Fill(tablo);
                datagridView_kullanicilar.DataSource = tablo;
                doldur.Dispose();
                baglanti.Close();

                datagridView_kullanicilar.Columns[0].Width = 150;
                datagridView_kullanicilar.Columns[1].Width = 130;
                datagridView_kullanicilar.Columns[2].Width = 130;
                datagridView_kullanicilar.Columns[3].Width = 180;
                datagridView_kullanicilar.Columns[4].Width = 150;
                datagridView_kullanicilar.Columns[5].Width = 200;
                datagridView_kullanicilar.Columns[6].Width = 105;
                datagridView_kullanicilar.Columns[7].Width = 105;
            }
        }

        private void datagridView_SinavListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                Gorevli_Ekle guncelleme = new Gorevli_Ekle(kisayol.yetkim, kisayol.secim_gorevli, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id);
                this.Hide();
                guncelleme.ShowDialog(this);
                this.Show();
            }
        }


        private void btn_yeniKullanici_Ekle_Click(object sender, EventArgs e)
        {
            Yonetici_Secimi_Ekle secim = new Yonetici_Secimi_Ekle(kisayol.yetkim, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id);
            this.Hide();
            secim.ShowDialog(this);
            this.Show();
        }

        private void txt_kimlikNO_ara_TextChanged(object sender, EventArgs e)
        {
            BindingSource veri = new BindingSource();
            veri.DataSource = datagridView_kullanicilar.DataSource;
            veri.Filter = "[Kimlik NO] LIKE '%" + txt_kimlikNO_ara.Text + "%'";
            datagridView_kullanicilar.DataSource = veri;
        }

        private void txt_adaGore_ara_TextChanged(object sender, EventArgs e)
        {
            BindingSource veri = new BindingSource();
            veri.DataSource = datagridView_kullanicilar.DataSource;
            veri.Filter = "[Isim] LIKE '%" + txt_adaGore_ara.Text + "%'";
            datagridView_kullanicilar.DataSource = veri;
        }

        private void txt_ileGore_Ara_TextChanged(object sender, EventArgs e)
        {
            BindingSource veri = new BindingSource();
            veri.DataSource = datagridView_kullanicilar.DataSource;
            veri.Filter = "[İl Adı] LIKE '%" + txt_ileGore_Ara.Text + "%'";
            datagridView_kullanicilar.DataSource = veri;
        }

        private void txt_ara_ilceye_gore_TextChanged(object sender, EventArgs e)
        {
            BindingSource veri = new BindingSource();
            veri.DataSource = datagridView_kullanicilar.DataSource;
            veri.Filter = "[İlçe Adi] LIKE '%" + txt_ara_ilceye_gore.Text + "%'";
            datagridView_kullanicilar.DataSource = veri;
        }

        private void txt_ara_soyisim_TextChanged(object sender, EventArgs e)
        {
            BindingSource veri = new BindingSource();
            veri.DataSource = datagridView_kullanicilar.DataSource;
            veri.Filter = "[Soyisim] LIKE '%" + txt_ara_soyisim.Text + "%'";
            datagridView_kullanicilar.DataSource = veri;
        }

        private void comboBox_poziyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = (Item)comboBox_poziyon.SelectedItem;
            int gorev = item.Value;
            if (kisayol.yetkim == 1)
            {
                Datagridview_Filtreleme(gorev);
            }
            else if (kisayol.yetkim == 2 || kisayol.yetkim == 3)
            {
                Datagridview_Filtreleme(gorev);
            }
            else if (kisayol.yetkim == 4 )
            {
                Datagridview_Filtreleme(gorev);
            }
        }

        private void Yukle_combo()
        {
            ComboboxItem item = new ComboboxItem();
            item.Text = "Genel Yönetici";
            item.Value = 1;
            ComboboxItem itemm = new ComboboxItem();
             itemm.Text = "İl Yöneticisi";
            itemm.Value = 2;
             item.Text = "İl Yardımcısı";
            item.Value = 3;
             item.Text = "İlçe Yöneticisi";
            item.Value = 4;
             item.Text = "Bina Yöneticisi";
            item.Value = 5;
             item.Text = "Bina Yardımcısı";
            item.Value = 6;
            
            comboBox_poziyon.Items.Add(item);
        }

        private void Datagridview_Filtreleme(int gorev)
        {
            DataTable tablo = new DataTable();

            String cumle = "Select k.kimlikNO as [Kimlik NO],k.Isim [Isim],k.Soyisim [Soyisim],k.Unvan [Ünvanı],k.CepNO [Cep Numarası],k.eposta [e-Posta Adresi], il.ilAdi [İl Adı], ilce.ilceAdi [İlçe Adi] from Kullanicilar as k JOIN Iller_Tablosu as il on k.il_ID = il.il_ID JOIN Ilceler_Tablosu as ilce on k.ilce_JD = ilce.ilce_ID Where gorevliID != '" + kisayol.Gorevli_ID + "' and Yetki_Gorevi= '" + gorev + "'";
            SqlCommand komut = new SqlCommand(cumle, baglanti);
            SqlDataAdapter doldur = new SqlDataAdapter(cumle, baglanti);

            baglanti.Open();
            doldur.Fill(tablo);
            datagridView_kullanicilar.DataSource = tablo;
            doldur.Dispose();
            baglanti.Close();

            datagridView_kullanicilar.Columns[0].Width = 150;
            datagridView_kullanicilar.Columns[1].Width = 130;
            datagridView_kullanicilar.Columns[2].Width = 130;
            datagridView_kullanicilar.Columns[3].Width = 180;
            datagridView_kullanicilar.Columns[4].Width = 150;
            datagridView_kullanicilar.Columns[5].Width = 200;
            datagridView_kullanicilar.Columns[6].Width = 117;
            datagridView_kullanicilar.Columns[7].Width = 117;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox_poziyon.ResetText();
        }

        private void datagridView_kullanicilar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (kisayol.yetkim == 1)
            {
                secilen_satir = e.RowIndex;
                Gorevli_Ekle guncelle = new Gorevli_Ekle(kisayol.yetkim, kisayol.secim_gorevli, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id);
                DataGridViewRow satirlar = datagridView_kullanicilar.Rows[secilen_satir];

                guncelle.txt_gorevliTC.ReadOnly = true;
                guncelle.btn_guncelle.Visible = true;
                guncelle.button1.Visible = true;
                guncelle.btn_kaydetSinav.Hide();
                guncelle.button_Temizle.Hide();
                guncelle.tabControl_OkulBilgisi.TabPages.Remove(guncelle.tabPage_BinaBilgiler);
                guncelle.tabControl_OkulBilgisi.TabPages.Remove(guncelle.tabPage_girisBilgi);

                guncelle.txt_gorevliTC.Text = this.datagridView_kullanicilar.CurrentRow.Cells[0].Value.ToString();
                guncelle.txt_gorevliAd.Text = this.datagridView_kullanicilar.CurrentRow.Cells[1].Value.ToString();
                guncelle.txt_gorevliSoyad.Text = this.datagridView_kullanicilar.CurrentRow.Cells[2].Value.ToString();
                guncelle.txt_gorevliUnvan.Text = this.datagridView_kullanicilar.CurrentRow.Cells[3].Value.ToString();
                guncelle.txt_gorevliCepNO.Text = this.datagridView_kullanicilar.CurrentRow.Cells[4].Value.ToString();
                guncelle.txt_gorevliEposta.Text = this.datagridView_kullanicilar.CurrentRow.Cells[5].Value.ToString();
                guncelle.txt_gorevliAdress.Text = this.datagridView_kullanicilar.CurrentRow.Cells[6].Value.ToString();

               
                if (guncelle.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    String cumle = "Select k.kimlikNO as [Kimlik NO],k.Isim [Isim],k.Soyisim [Soyisim],k.Unvan [Ünvanı],k.CepNO [Cep Numarası],k.eposta [e-Posta Adresi], k.Adress [Adresi], il.ilAdi [İl Adı] from Kullanicilar as k JOIN Iller_Tablosu as il on k.il_ID = il.il_ID Where gorevliID != '" + kisayol.Gorevli_ID + "'";

                    SqlDataAdapter doldur = new SqlDataAdapter(cumle, baglanti);
                    DataTable tablo = new DataTable();
                    baglanti.Open();
                    doldur.Fill(tablo);
                    datagridView_kullanicilar.DataSource = tablo;
                    doldur.Dispose();
                    baglanti.Close();

                    datagridView_kullanicilar.Columns[0].Width = 150;
                    datagridView_kullanicilar.Columns[1].Width = 130;
                    datagridView_kullanicilar.Columns[2].Width = 130;
                    datagridView_kullanicilar.Columns[3].Width = 180;
                    datagridView_kullanicilar.Columns[4].Width = 150;
                    datagridView_kullanicilar.Columns[5].Width = 200;
                    datagridView_kullanicilar.Columns[6].Width = 110;
                }
                this.Show();
            }
        }
    }
}
