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
using FlatUI;
using System.Windows.Documents;


namespace Sinav_Gorevlendirme_Proje
{
    public partial class Bina_Okul : Form
    {
        public Bina_Okul(int yetki, int il_ID, int ilce_ID)
        {
            InitializeComponent();
            kisayol.yetkim = yetki;
            kisayol.Il_Id = il_ID;
            kisayol.ilce_ID = ilce_ID;


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

        int il, ilce, semtim, binaID, yoneticiID, yardimciID;
        KisaYollar kisayol = new KisaYollar();
        SqlConnection baglanti = new SqlConnection("Data Source=COMPUTER\\MSSQLSERVERR;Initial Catalog=SinavGorevlendirme;Integrated Security=True");
        DialogResult secenek;
        String isim, soyisim, isim2, soyisim2, birlestir;
        private void Bina_Okul_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;

            if (kisayol.yetkim == 1)
            {
                String iller = "Select il_ID,ilAdi from Iller_Tablosu Order by ilAdi ";
                baglanti.Open();
                SqlCommand komm = new SqlCommand(iller, baglanti);
                SqlDataReader okuma = komm.ExecuteReader();
                combo_bina_il.Items.Clear();
                while (okuma.Read())
                {
                    combo_bina_il.Items.Add(okuma["ilAdi"]);
                }
                okuma.Close();
                baglanti.Close();
            }

            else if (kisayol.yetkim == 2)
            {
                lbl_il.Hide();
                combo_bina_il.Hide();
                groupBox_Adres.Location = new Point(14, 6);

                String ilceler = "Select ilce_ID,ilceAdi from Ilceler_Tablosu Where il_id = '" + kisayol.Il_Id + "' ORDER BY ilceAdi ";
                baglanti.Open();
                SqlCommand komm = new SqlCommand(ilceler, baglanti);
                SqlDataReader okuma = komm.ExecuteReader();
                combo_bina_ilce.Items.Clear();
                while (okuma.Read())
                {
                    combo_bina_ilce.Items.Add(okuma["ilceAdi"]);
                }
                okuma.Close();
                baglanti.Close();
            }
            else if (kisayol.yetkim == 3)
            {
                lbl_il.Hide();
                combo_bina_il.Hide();

                lbl_ilce.Location = new Point(26, 46);
                combo_bina_ilce.Location = new Point(134, 42);
                lbl_semt.Location = new Point(26, 90);
                lbl_cadde.Location = new Point(26, 137);
                lbl_sokak.Location = new Point(26, 182);
                lbl_sokak_no.Location = new Point(394, 185);
                lbl_binaAdi.Location = new Point(26, 229);
                lbl_bina_AcikAdres.Location = new Point(26, 323);
                combo_bina_semt.Location = new Point(134, 87);
                txt_bina_cadde.Location = new Point(134, 134);
                txt_bina_sokak.Location = new Point(134, 178);
                combo_sokak_no.Location = new Point(470, 178);
                txt_okulBina_Acik_Adres.Location = new Point(232, 268);
                txt_BinaAdi.Location = new Point(134, 226);

                String ilceler = "Select ilce_ID,ilceAdi from Ilceler_Tablosu Where il_id = '" + kisayol.Il_Id + "' ORDER BY ilceAdi ";
                baglanti.Open();
                SqlCommand komm = new SqlCommand(ilceler, baglanti);
                SqlDataReader okuma = komm.ExecuteReader();
                combo_bina_ilce.Items.Clear();
                while (okuma.Read())
                {
                    combo_bina_ilce.Items.Add(okuma["ilceAdi"]);
                }
                okuma.Close();
                baglanti.Close();
            }
            else if (kisayol.yetkim == 4)
            {
                lbl_il.Hide();
                combo_bina_il.Hide();
                lbl_ilce.Hide();
                combo_bina_ilce.Hide();

                lbl_semt.Location = new Point(26, 90);
                lbl_cadde.Location = new Point(26, 137);
                lbl_sokak.Location = new Point(26, 182);
                lbl_sokak_no.Location = new Point(394, 185);
                lbl_binaAdi.Location = new Point(26, 229);
                lbl_bina_AcikAdres.Location = new Point(26, 323);
                combo_bina_semt.Location = new Point(134, 87);
                txt_bina_cadde.Location = new Point(134, 134);
                txt_bina_sokak.Location = new Point(134, 178);
                combo_sokak_no.Location = new Point(470, 178);
                txt_okulBina_Acik_Adres.Location = new Point(232, 268);
                txt_BinaAdi.Location = new Point(134, 226);

                String ilceler = "Select semtAdi from Semt_Tablo where ilce_ID = '" + kisayol.ilce_ID + "'  ";
                baglanti.Open();
                SqlCommand komm = new SqlCommand(ilceler, baglanti);
                SqlDataReader okuma = komm.ExecuteReader();
                combo_bina_semt.Items.Clear();
                while (okuma.Read())
                {
                    combo_bina_semt.Items.Add(okuma["semtAdi"]);
                }
                okuma.Close();
                baglanti.Close();
            }


        }

        private void btn_kaydetBinaBilgiler_Click(object sender, EventArgs e)
        {

            if (txt_okulBina_Acik_Adres.Text == String.Empty || txt_bina_Telefon.Text == String.Empty)
            {
                kisayol.mesajBox_Butonlu("(*) Yıldızlı alanlar boş bırakılamaz !!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (kisayol.yetkim == 1)
                {
                    String sorgu1 = "select il.il_ID,ilce.ilce_ID from Iller_Tablosu as il join Ilceler_Tablosu as ilce on il.il_ID = ilce.il_id Where il.ilAdi = '" + combo_bina_il.Text + "' And ilce.ilceAdi = '" + combo_bina_ilce.Text + "'";
                    SqlCommand komut_idcek = new SqlCommand(sorgu1, baglanti);
                    baglanti.Open();
                    SqlDataReader veriler = komut_idcek.ExecuteReader();
                    while (veriler.Read())
                    {
                        il = Convert.ToInt32(veriler["il_ID"]);
                        ilce = Convert.ToInt32(veriler["ilce_ID"]);
                    }
                    veriler.Close();
                    baglanti.Close();
                    ////------- Kaydet ------
                    Kayit_Bina_Bilgi(il, ilce, semtim);
                    MessageBox.Show("Bilgiler başarıyla kaydedildi. !!!\n\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    binaAdi_Combobox(il);
                }
                else if (kisayol.yetkim == 2)
                {
                    Kayit_Bina_Bilgi(kisayol.Il_Id, ilce, semtim);
                    MessageBox.Show("Bilgiler başarıyla kaydedildi. !!!\n\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    binaAdi_Combobox(kisayol.Il_Id);
                }
                else if (kisayol.yetkim == 3)
                {
                    Kayit_Bina_Bilgi(kisayol.Il_Id, ilce, semtim);
                    MessageBox.Show("Bilgiler başarıyla kaydedildi. !!!\n\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    binaAdi_Combobox(kisayol.Il_Id);
                }
                else if (kisayol.yetkim == 4)
                {
                    Kayit_Bina_Bilgi(kisayol.Il_Id, kisayol.ilce_ID, semtim);
                    MessageBox.Show("Bilgiler başarıyla kaydedildi. !!!\n\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    binaAdi_Combobox(kisayol.ilce_ID);
                }




            }
        }
        private void btn_bina_Yonetici_kaydi_Click(object sender, EventArgs e)
        {
            if (combobox_OkulBina_KatSayi.Text == String.Empty)
            {
                kisayol.mesajBox_Butonlu("(*) Yıldızlı alanlar boş bırakılamaz !!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                String kaydet = "Insert into KatBilgileri(Kat_Sayisi,sinif_Sayisi,bina_ID) Values ('" + combobox_OkulBina_KatSayi.Text + "', '" + txt_sinif_Sayisi.Text + "','" + binaID + "'); Update BinaBilgileri Set gorevli_ID = '" + yoneticiID + "' Where bina_ID = '" + binaID + "'; Update Kullanicilar Set binaID = '" + binaID + "' where gorevliID in ('" + yoneticiID + "','" + yardimciID + "');";
                kisayol.Veritabani_Standart(kaydet);
                
                kisayol.mesajBox_Butonlu("Bilgiler başarıyla kaydedildi. !!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Bina_Yonetici_ekle_Click(object sender, EventArgs e)
        {
            Yonetici_Secimi_Ekle secim = new Yonetici_Secimi_Ekle(kisayol.yetkim, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id);
            secim.combo_secim.SelectedIndex = 4;
            kisayol.combobox_Sil(secim.combo_secim, "Genel Yönetici");
            kisayol.combobox_Sil(secim.combo_secim, "İl Yöneticisi");
            kisayol.combobox_Sil(secim.combo_secim, "İl Yardımcısı");
            kisayol.combobox_Sil(secim.combo_secim, "İlçe Yöneticisi");
            kisayol.combobox_Sil(secim.combo_secim, "Sınav Sorumlusu");
          

            if (secim.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                ///--- Il'e Gore Yonetici
                String sorgu = "Select Isim,Soyisim from Kullanicilar where il_ID = '" + il + "' and Yetki_Gorevi = 5 and binaID is null ";
                baglanti.Open();
                SqlCommand kommi = new SqlCommand(sorgu, baglanti);
                SqlDataReader okumaa = kommi.ExecuteReader();
                combobox_Bina_Yoneticisi.Items.Clear();
                while (okumaa.Read())
                {
                    isim = Convert.ToString(okumaa["Isim"]);

                    soyisim = Convert.ToString(okumaa["Soyisim"]);
                    combobox_Bina_Yoneticisi.Items.Add(isim + soyisim);
                }
                okumaa.Close();
                baglanti.Close();

                ///--- Il'e Gore Yardimcisi
                String yard = "Select Isim,Soyisim from Kullanicilar where il_ID = '" + il + "' and Yetki_Gorevi = 6 and binaID is null ";
                SqlCommand yardimc = new SqlCommand(yard, baglanti);
                baglanti.Open();
                SqlDataReader yardim_oku = yardimc.ExecuteReader();
                combobox_Bina_Yonetici_Yardimcisi.Items.Clear();
                while (yardim_oku.Read())
                {
                    isim2 = Convert.ToString(yardim_oku["Isim"]);
                    soyisim2 = Convert.ToString(yardim_oku["Soyisim"]);
                    combobox_Bina_Yonetici_Yardimcisi.Items.Add(isim2 + " " + soyisim2);
                }
                yardim_oku.Close();
                baglanti.Close();
            }
            this.Show();
        }

        private void combo_bina_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kisayol.yetkim == 1)
            {
                /// ---- IL aliyoruz----
                String sorgu1 = "select il_ID from Iller_Tablosu where ilAdi = '" + combo_bina_il.Text + "'";
                SqlCommand komut_idcek = new SqlCommand(sorgu1, baglanti);
                baglanti.Open();
                il = Convert.ToInt32(komut_idcek.ExecuteScalar());
                baglanti.Close();

                /// ---- Ilce Siraliyoruz----
                String sorgu2 = "Select distinct ilce.ilce_ID, ilce.ilceAdi from Iller_Tablosu as il Join Ilceler_Tablosu as ilce ON il.il_ID = ilce.il_ID Where il.il_ID = '" + il + "'";
                kisayol.Veritabani_Combobox_Veri(combo_bina_ilce, sorgu2, "ilceAdi");

                // ---- Il'e gore Bina siraliyoruz...----
                binaAdi_Combobox(il);

            }
            else if (kisayol.yetkim == 2)
            {
                String sorgu2 = "Select ilce_ID,ilceAdi from Ilceler_Tablosu Where il_id = '" + kisayol.Il_Id + "'";
                kisayol.Veritabani_Combobox_Veri(combo_bina_ilce, sorgu2, "ilceAdi");
                binaAdi_Combobox(kisayol.Il_Id);

            }
            else if (kisayol.yetkim == 3)
            {
                String sorgu2 = "Select ilce_ID,ilceAdi from Ilceler_Tablosu Where il_id = '" + kisayol.Il_Id + "'";
                kisayol.Veritabani_Combobox_Veri(combo_bina_ilce, sorgu2, "ilceAdi");
                binaAdi_Combobox(kisayol.Il_Id);
            }
        }

        private void combo_bina_ilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kisayol.yetkim == 1)
            {
                String sorgu_semt = "Select semt_ID, semtAdi from Semt_Tablo as semt Join Ilceler_Tablosu as ilce on ilce.ilce_ID = semt.ilce_ID Where ilceAdi = '" + combo_bina_ilce.Text + "'";
                kisayol.Veritabani_Combobox_Veri(combo_bina_semt, sorgu_semt, "semtAdi");
            }
            else if (kisayol.yetkim == 2)
            {
                String sorgu1 = "select ilce_ID from Ilceler_Tablosu where ilceAdi = '" + combo_bina_ilce.Text + "' ";
                SqlCommand komut_idcek = new SqlCommand(sorgu1, baglanti);
                baglanti.Open();
                ilce = Convert.ToInt32(komut_idcek.ExecuteScalar());
                baglanti.Close();

                String sorgu_semt = "Select semt_ID, semtAdi from Semt_Tablo as semt Join Ilceler_Tablosu as ilce on ilce.ilce_ID = semt.ilce_ID Where ilce.ilce_ID  = '" + ilce + "'";
                kisayol.Veritabani_Combobox_Veri(combo_bina_semt, sorgu_semt, "semtAdi");

                binaAdi_Combobox(kisayol.Il_Id);
            }
            else if (kisayol.yetkim == 3)
            {
                String sorgu1 = "select ilce_ID from Ilceler_Tablosu where ilceAdi = '" + combo_bina_ilce.Text + "' ";
                SqlCommand komut_idcek = new SqlCommand(sorgu1, baglanti);
                baglanti.Open();
                ilce = Convert.ToInt32(komut_idcek.ExecuteScalar());
                baglanti.Close();

                String sorgu_semt = "Select semt_ID, semtAdi from Semt_Tablo as semt Join Ilceler_Tablosu as ilce on ilce.ilce_ID = semt.ilce_ID Where ilce.ilce_ID  = '" + ilce + "'";
                kisayol.Veritabani_Combobox_Veri(combo_bina_semt, sorgu_semt, "semtAdi");

                binaAdi_Combobox_Ilce(ilce);
            }

        }

        private void combo_bina_semt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kisayol.yetkim == 1)
            {
                String sorgu1 = "select semt_ID from Semt_Tablo Where semtAdi = '" + combo_bina_semt.Text + " '";
                SqlCommand komke = new SqlCommand(sorgu1, baglanti);
                baglanti.Open();
                semtim = Convert.ToInt32(komke.ExecuteScalar());
                baglanti.Close();
            }
            else if (kisayol.yetkim == 2)
            {
                String sorgu1 = "select semt_ID from Semt_Tablo Where semtAdi = '" + combo_bina_semt.Text + " '";
                SqlCommand komke = new SqlCommand(sorgu1, baglanti);
                baglanti.Open();
                semtim = Convert.ToInt32(komke.ExecuteScalar());
                baglanti.Close();
            }
            else if (kisayol.yetkim == 3)
            {
                String sorgu1 = "select semt_ID from Semt_Tablo Where semtAdi = '" + combo_bina_semt.Text + " '";
                SqlCommand komke = new SqlCommand(sorgu1, baglanti);
                baglanti.Open();
                semtim = Convert.ToInt32(komke.ExecuteScalar());
                baglanti.Close();
            }
            else if (kisayol.yetkim == 4)
            {
                String sorgu1 = "select semt_ID from Semt_Tablo Where semtAdi = '" + combo_bina_semt.Text + " '";
                SqlCommand komke = new SqlCommand(sorgu1, baglanti);
                baglanti.Open();
                semtim = Convert.ToInt32(komke.ExecuteScalar());
                baglanti.Close();

                binaAdi_Combobox_Semt(semtim);
            }
        }

        private void combobox_binaAdi_Sec_SelectedIndexChanged(object sender, EventArgs e)
        {

            String sorgu1 = "select bina_ID from BinaBilgileri where binaAdi = '" + combobox_binaAdi_Sec.Text + "'";
            SqlCommand komut = new SqlCommand(sorgu1, baglanti);
            baglanti.Open();
            binaID = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();

            if (kisayol.yetkim == 1)
            {
                ///  Il'e gore Yonetici
                String sorgu = "Select gorevliID,Isim,Soyisim from Kullanicilar where il_ID = '" + il + "' and Yetki_Gorevi = 5 and binaID is null ";
                baglanti.Open();
                SqlCommand kommi = new SqlCommand(sorgu, baglanti);
                SqlDataReader okumaa = kommi.ExecuteReader();
                combobox_Bina_Yoneticisi.Items.Clear();

                while (okumaa.Read())
                {
                    yoneticiID = Convert.ToInt32(okumaa["gorevliID"]);
                    isim = Convert.ToString(okumaa["Isim"]);
                    soyisim = Convert.ToString(okumaa["Soyisim"]);
                   
                    ComboboxItem item = new ComboboxItem();
                    item.Text = isim + " " + soyisim;
                    item.Value = yoneticiID;
                    combobox_Bina_Yoneticisi.Items.Add(item);
                }
                okumaa.Close();
                baglanti.Close();

                ///--- Il'e Gore Yardimcisi
                String yard = "Select gorevliID,Isim,Soyisim from Kullanicilar where il_ID = '" + il + "' and Yetki_Gorevi = 6 and binaID is null ";
                SqlCommand yardimc = new SqlCommand(yard, baglanti);
                baglanti.Open();
                SqlDataReader yardim_oku = yardimc.ExecuteReader();
                combobox_Bina_Yonetici_Yardimcisi.Items.Clear();
                while (yardim_oku.Read())
                {
                    yardimciID = Convert.ToInt32(yardim_oku["gorevliID"]);
                    isim2 = Convert.ToString(yardim_oku["Isim"]);
                    soyisim2 = Convert.ToString(yardim_oku["Soyisim"]);
                    
                    ComboboxItem item2 = new ComboboxItem();
                    item2.Text = isim2 + " " + soyisim2;
                    item2.Value = yardimciID;
                    combobox_Bina_Yonetici_Yardimcisi.Items.Add(item2);
                   
                }
                yardim_oku.Close();
                baglanti.Close();
            }
            else if (kisayol.yetkim == 2)
            {
                ///  Il'e gore Yonetici
                String sorgu = "select gorevliID,Isim,Soyisim from Kullanicilar as k join Iller_Tablosu as il on il.il_ID = k.il_ID Where il.il_ID = @il and k.Yetki_Gorevi = 5 and k.binaID is null";
                baglanti.Open();
                SqlCommand kommi = new SqlCommand(sorgu, baglanti);
                kommi.Parameters.AddWithValue("@il", kisayol.Il_Id);
                SqlDataReader okumaa = kommi.ExecuteReader();
                combobox_Bina_Yoneticisi.Items.Clear();
                while (okumaa.Read())
                {
                    yoneticiID = Convert.ToInt32(okumaa["gorevliID"]);
                    isim = Convert.ToString(okumaa["Isim"]);
                    soyisim = Convert.ToString(okumaa["Soyisim"]);


                    ComboboxItem item = new ComboboxItem();
                    item.Text = isim + " " + soyisim;
                    item.Value = yoneticiID;
                    combobox_Bina_Yoneticisi.Items.Add(item);

                }
                okumaa.Close();
                baglanti.Close();

                ///--- Il'e Gore Yardimcisi
                String yard = "select gorevliID,Isim,Soyisim from Kullanicilar as k join Iller_Tablosu as il on il.il_ID = k.il_ID Where il.il_ID = @il and k.Yetki_Gorevi = 6  and k.binaID is null";
                SqlCommand yardimc = new SqlCommand(yard, baglanti);
                yardimc.Parameters.AddWithValue("@il", kisayol.Il_Id);
                baglanti.Open();
                SqlDataReader yardim_oku = yardimc.ExecuteReader();
                combobox_Bina_Yonetici_Yardimcisi.Items.Clear();
                while (yardim_oku.Read())
                {
                    yardimciID = Convert.ToInt32(yardim_oku["gorevliID"]);
                    isim2 = Convert.ToString(yardim_oku["Isim"]);
                    soyisim2 = Convert.ToString(yardim_oku["Soyisim"]);

                    ComboboxItem item2 = new ComboboxItem();
                    item2.Text = isim2 + " " + soyisim2;
                    item2.Value = yardimciID;
                    combobox_Bina_Yonetici_Yardimcisi.Items.Add(item2);
                }
                yardim_oku.Close();
                baglanti.Close();
            }
            else if (kisayol.yetkim == 3)
            {
                ///  Il'e gore Yonetici
                String sorgu = "Select gorevliID,Isim,Soyisim from Kullanicilar where il_ID = '" + il + "' and Yetki_Gorevi = 5 and binaID is null ";
                baglanti.Open();
                SqlCommand kommi = new SqlCommand(sorgu, baglanti);
                SqlDataReader okumaa = kommi.ExecuteReader();
                combobox_Bina_Yoneticisi.Items.Clear();

                while (okumaa.Read())
                {
                    yoneticiID = Convert.ToInt32(okumaa["gorevliID"]);
                    isim = Convert.ToString(okumaa["Isim"]);
                    soyisim = Convert.ToString(okumaa["Soyisim"]);

                    ComboboxItem item = new ComboboxItem();
                    item.Text = isim + " " + soyisim;
                    item.Value = yoneticiID;
                    combobox_Bina_Yoneticisi.Items.Add(item);
                }
                okumaa.Close();
                baglanti.Close();

                ///--- Il'e Gore Yardimcisi
                String yard = "Select Isim,Soyisim from Kullanicilar where il_ID = '" + il + "' and Yetki_Gorevi = 6 and binaID is null ";
                SqlCommand yardimc = new SqlCommand(yard, baglanti);
                baglanti.Open();
                SqlDataReader yardim_oku = yardimc.ExecuteReader();
                combobox_Bina_Yonetici_Yardimcisi.Items.Clear();
                while (yardim_oku.Read())
                {
                    yardimciID = Convert.ToInt32(yardim_oku["gorevliID"]);
                    isim2 = Convert.ToString(yardim_oku["Isim"]);
                    soyisim2 = Convert.ToString(yardim_oku["Soyisim"]);

                    ComboboxItem item2 = new ComboboxItem();
                    item2.Text = isim2 + " " + soyisim2;
                    item2.Value = yardimciID;
                    combobox_Bina_Yonetici_Yardimcisi.Items.Add(item2);
                }
                yardim_oku.Close();
                baglanti.Close();
            }
            else if (kisayol.yetkim == 4)
            {
                ///  Il'e gore Yonetici
                String sorgu = "Select gorevliID,Isim,Soyisim from Kullanicilar where il_ID = '" + il + "' and Yetki_Gorevi = 5 and binaID is null ";
                baglanti.Open();
                SqlCommand kommi = new SqlCommand(sorgu, baglanti);
                SqlDataReader okumaa = kommi.ExecuteReader();
                combobox_Bina_Yoneticisi.Items.Clear();

                while (okumaa.Read())
                {
                    yoneticiID = Convert.ToInt32(okumaa["gorevliID"]);
                    isim = Convert.ToString(okumaa["Isim"]);
                    soyisim = Convert.ToString(okumaa["Soyisim"]);

                    ComboboxItem item = new ComboboxItem();
                    item.Text = isim + " " + soyisim;
                    item.Value = yoneticiID;
                    combobox_Bina_Yoneticisi.Items.Add(item);
                }
                okumaa.Close();
                baglanti.Close();

                ///--- Il'e Gore Yardimcisi
                String yard = "Select gorevliID,Isim,Soyisim from Kullanicilar where il_ID = '" + il + "' and Yetki_Gorevi = 6 and binaID is null ";
                SqlCommand yardimc = new SqlCommand(yard, baglanti);
                baglanti.Open();
                SqlDataReader yardim_oku = yardimc.ExecuteReader();
                combobox_Bina_Yonetici_Yardimcisi.Items.Clear();
                while (yardim_oku.Read())
                {
                    yardimciID = Convert.ToInt32(yardim_oku["gorevliID"]);
                    isim2 = Convert.ToString(yardim_oku["Isim"]);
                    soyisim2 = Convert.ToString(yardim_oku["Soyisim"]);

                    ComboboxItem item = new ComboboxItem();
                    item.Text = isim2 + " " + soyisim2;
                    item.Value = yoneticiID;
                    combobox_Bina_Yoneticisi.Items.Add(item);
                }
                yardim_oku.Close();
                baglanti.Close();
            }
        }

        private void combobox_Bina_Yoneticisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            yoneticiID = Convert.ToInt32(((Sinav_Gorevlendirme_Proje.Bina_Okul.ComboboxItem)(combobox_Bina_Yoneticisi.SelectedItem)).Value);
        }

        private void combobox_Bina_Yonetici_Yardimcisi_SelectedIndexChanged(object sender, EventArgs e)
        {
                yardimciID = Convert.ToInt32( (((Sinav_Gorevlendirme_Proje.Bina_Okul.ComboboxItem)(combobox_Bina_Yonetici_Yardimcisi.SelectedItem)).Value));
        }

        private void combobox_OkulBina_KatSayi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_sinif_Sayisi_Click(object sender, EventArgs e)
        {
            txt_sinif_Sayisi.Text = "";
            txt_sinif_Sayisi.ForeColor = Color.Black;
            txt_sinif_Sayisi.Font = new Font(txt_sinif_Sayisi.Font.FontFamily, 12, FontStyle.Bold);
        }
        private void Kayit_Bina_Bilgi(int il, int ilce, int semt)
        {
            baglanti.Open();
            String sorgu = "INSERT INTO BinaBilgileri(Cadde,Sokak,sokakNO,binaAdi,AcikAdres,Telefon,CepNO,Fax,il_ID,ilce_ID,semt_ID) VALUES(@cadde,@sokak,@sokakNO,@binaAdi,@acikAdres,@telefon,@cepNO,@fax,@il,@ilce,@semt)";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@cadde", txt_bina_cadde.Text);
            komut.Parameters.AddWithValue("@sokak", txt_bina_sokak.Text);
            komut.Parameters.AddWithValue("@sokakNO", combo_sokak_no.Text);
            komut.Parameters.AddWithValue("@binaAdi", txt_BinaAdi.Text);
            komut.Parameters.AddWithValue("@acikAdres", txt_okulBina_Acik_Adres.Text);
            komut.Parameters.AddWithValue("@telefon", txt_bina_Telefon.Text);
            komut.Parameters.AddWithValue("@cepNO", txt_bina_CepNO.Text);
            komut.Parameters.AddWithValue("@fax", txt_bina_FaxNo.Text);
            komut.Parameters.AddWithValue("@il", il);
            komut.Parameters.AddWithValue("@ilce", ilce);
            komut.Parameters.AddWithValue("@semt", semt);

            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void binaAdi_Combobox(int il_idsi)
        {
            String binaCombo = "Select bina_ID,binaAdi from BinaBilgileri as bina JOIN Iller_Tablosu as il on il.il_ID = bina.il_ID Where gorevli_ID is null and il.il_ID = '" + il_idsi + "'";
            baglanti.Open();
            SqlCommand komm = new SqlCommand(binaCombo, baglanti);
            SqlDataReader okuma = komm.ExecuteReader();
            combobox_binaAdi_Sec.Items.Clear();
            while (okuma.Read())
            {
                combobox_binaAdi_Sec.Items.Add(okuma["binaAdi"]);
            }
            okuma.Close();
            baglanti.Close();
        }
        private void binaAdi_Combobox_Ilce(int ilce)
        {
            String binaCombo = "Select bina_ID,binaAdi from BinaBilgileri as bina JOIN Ilceler_Tablosu as ilce on ilce.ilce_ID = bina.ilce_ID Where gorevli_ID is null and ilce.ilce_ID =  '" + ilce + "'";
            baglanti.Open();
            SqlCommand komm = new SqlCommand(binaCombo, baglanti);
            SqlDataReader okuma = komm.ExecuteReader();
            combobox_binaAdi_Sec.Items.Clear();
            while (okuma.Read())
            {
                combobox_binaAdi_Sec.Items.Add(okuma["binaAdi"]);
            }
            okuma.Close();
            baglanti.Close();
        }
        private void binaAdi_Combobox_Semt(int semtimID)
        {

            String binaCombo = "Select bina_ID,binaAdi from BinaBilgileri as bina JOIN Semt_Tablo as semt on semt.semt_ID = bina.semt_ID Where gorevli_ID is null and semt.semt_ID = '" + semtimID + "'";
            baglanti.Open();
            SqlCommand komm = new SqlCommand(binaCombo, baglanti);
            SqlDataReader okuma = komm.ExecuteReader();
            combobox_binaAdi_Sec.Items.Clear();
            while (okuma.Read())
            {
                combobox_binaAdi_Sec.Items.Add(okuma["binaAdi"]);
            }
            okuma.Close();
            baglanti.Close();

        }
    }
}
