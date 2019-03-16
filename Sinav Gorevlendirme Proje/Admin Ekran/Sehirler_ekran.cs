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
    public partial class Sehirler_ekran : Form 
    {
        public Sehirler_ekran(int yetki, int gorevID,int il_ID,int ilce_ID)
        {
            InitializeComponent();
            kisayol.yetkim = yetki;
            kisayol.Gorevli_ID = gorevID;
            kisayol.Il_Id = il_ID;
            kisayol.ilce_ID = ilce_ID;
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


        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=SinavGorevlendirme;Integrated Security=True");
        KisaYollar kisayol = new KisaYollar();
        String sorgu = "Select il_ID,ilAdi from Iller_Tablosu Order BY ilAdi asc";
        String ilad,ilcead,semtad;
        int il_ID, ilce_ID, semt_ID;
       private void Sehirler_ekran_Load(object sender, EventArgs e)
        {
            btn_ilce_guncelle.Hide();
            btn_il_guncelle.Hide();
           

            if (kisayol.yetkim == 1)
            {
                btn_ilce_guncelle.Show();
                btn_il_guncelle.Show();

                String iller = "Select il_ID,ilAdi from Iller_Tablosu Order by ilAdi ";
                combobox_veriler(combo_iller, iller, "il_ID", "ilAdi", il_ID, ilad);
            }
           if(kisayol.yetkim == 2)
           {
               TabControl_ILilce.TabPages.Remove(tab_il);
               this.Text = "İlçe Kaydı";

               String ilce_Sorgu = "Select ilce.ilceAdi from Iller_Tablosu as il JOIN Ilceler_Tablosu as ilce on il.il_ID = ilce.il_id Where il.il_ID = '" + kisayol.Il_Id + "'";
               kisayol.Veritabani_Combobox_Veri(comboBox_ilce, ilce_Sorgu, "ilceAdi");
           }
           else if (kisayol.yetkim == 3)
           {
               TabControl_ILilce.TabPages.Remove(tab_il);
               this.Text = "İlçe Kaydı";
               String ilce_Sorgu = "Select ilce.ilceAdi from Iller_Tablosu as il JOIN Ilceler_Tablosu as ilce on il.il_ID = ilce.il_id Where il.il_ID = '" + kisayol.Il_Id + "'";
               kisayol.Veritabani_Combobox_Veri(comboBox_ilce, ilce_Sorgu, "ilceAdi");

           }
           else
           {
               Sehirler_ekran sehirler = new Sehirler_ekran(kisayol.yetkim, kisayol.Gorevli_ID, kisayol.Il_Id, kisayol.ilce_ID);
               sehirler.Hide();
           }       
        }

        private void combo_iller_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (kisayol.yetkim == 1)
            {
                il_ID = Convert.ToInt32((((Sinav_Gorevlendirme_Proje.Sehirler_ekran.ComboboxItem)(combo_iller.SelectedItem)).Value));

                String sorgu2 = "Select ilce_ID,ilceAdi from Ilceler_Tablosu Where il_id = '" + il_ID + "' ";
                combobox_veriler(comboBox_ilce, sorgu2, "ilce_ID", "ilceAdi", ilce_ID, ilcead);
            }
            else if(kisayol.yetkim == 2)
            {
               
            }
        }

        private void comboBox_ilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kisayol.yetkim == 1)
            {
                ilce_ID = Convert.ToInt32((((Sinav_Gorevlendirme_Proje.Sehirler_ekran.ComboboxItem)(comboBox_ilce.SelectedItem)).Value));

                String sorgu = "Select semt_ID,semtAdi from Semt_Tablo Where ilce_ID = '" + ilce_ID + "'";
                combobox_veriler(comboBox_semt, sorgu, "semt_ID", "semtAdi", semt_ID, semtad);
            }
            else if (kisayol.yetkim == 2)
            {
                String sorgu = "Select semt_ID, semtAdi from Semt_Tablo as semt Join Ilceler_Tablosu as ilce on ilce.ilce_ID = semt.ilce_ID Where ilce.ilceAdi='" + comboBox_ilce.Text+"'";
                kisayol.Veritabani_Combobox_Veri(comboBox_semt, sorgu, "semtAdi");
            }
        }


       private void btn_ilYoneticiEkle_Click(object sender, EventArgs e)
       {
           Gorevli_Ekle gorevliEkle = new Gorevli_Ekle(kisayol.yetkim, kisayol.secim_gorevli, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id);
           gorevliEkle.tabControl_OkulBilgisi.TabPages.Remove(gorevliEkle.tabPage_BinaBilgiler);
           this.Hide();
           gorevliEkle.ShowDialog(this);
           this.Show();
       }

       private void btn_IlceYoneticiEkle_Click(object sender, EventArgs e)
       {
           Gorevli_Ekle gorevliEkle = new Gorevli_Ekle(kisayol.yetkim, kisayol.secim_gorevli, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id);
           gorevliEkle.tabControl_OkulBilgisi.TabPages.Remove(gorevliEkle.tabPage_BinaBilgiler);
           this.Hide();
           gorevliEkle.ShowDialog(this);
           this.Show();
       }

       private void btn_KaydetBilgi_Click(object sender, EventArgs e)
       {
           if (comboBox_ilce.Text == String.Empty)
           {
               kisayol.mesajBox_Basit("İlçe boş bırakılamaz. Lütfen bir ilçe seçiniz.");
           }
          
           else
           {
               kisayol.mesajBox_Basit("Bilgiler başarıyla kaydedildi. !!!");
           }
       }

       private void btn_kaydetBilgiler_Click(object sender, EventArgs e)
       {
           if (combo_iller.Text == String.Empty)
           {
               kisayol.mesajBox_Basit("İl boş bırakılamaz. Lütfen bir il seçiniz.");
           }         
           else
           {
               kisayol.mesajBox_Basit("Bilgiler başarıyla kaydedildi. !!!");
           }
       }

       private void btn_il_ekle_Click(object sender, EventArgs e)
       {
           Yeni_Sehir ilEkle = new Yeni_Sehir(kisayol.yetkim, kisayol.Il_Id);
           this.Hide();
           ilEkle.comboBox_il_sec.Hide();
           ilEkle.label2.Hide();
           ilEkle.label3.Hide();

           ilEkle.txt_ilce_ismi.Hide();
           ilEkle.txt_semt_ismi.Hide();
           ilEkle.combo_ilce_sec.Hide();
           ilEkle.btn_semtEkle.Hide();
           ilEkle.btn_IlceEkle.Hide();


           ilEkle.label1.Location = new Point(53, 96);
           ilEkle.txt_il_ismi.Location = new Point(200, 89);

           if (ilEkle.ShowDialog() == System.Windows.Forms.DialogResult.OK)
           {
                   kisayol.Veritabani_Combobox_Veri(combo_iller, sorgu, "ilAdi");
           }
           this.Show();
       }
       private void btn_ilce_Ekle_Click(object sender, EventArgs e)
       {
           Yeni_Sehir ilceEkle = new Yeni_Sehir(kisayol.yetkim, kisayol.Il_Id);
           this.Hide();
           ilceEkle.txt_il_ismi.Hide();
           ilceEkle.comboBox_il_sec.Location = new Point(200, 28);
           ilceEkle.combo_ilce_sec.Hide();
           ilceEkle.label3.Hide();
           ilceEkle.txt_semt_ismi.Hide();
           ilceEkle.btn_kaydet.Hide();
           ilceEkle.btn_semtEkle.Hide();
           ilceEkle.btn_IlceEkle.Location = new Point(280, 328);

           if (kisayol.yetkim == 1)
           {
               if (ilceEkle.ShowDialog() == System.Windows.Forms.DialogResult.OK)
               {
                   if (combo_iller.Text != String.Empty)
                   {
                       String sorgu = "Select il.il_ID,ilce_ID,ilceAdi from Ilceler_Tablosu as ilce Join Iller_Tablosu as il  on il.il_ID = ilce.il_id where il.ilAdi = '" + combo_iller.Text + "' Order BY ilceAdi asc";
                       kisayol.Veritabani_Combobox_Veri(comboBox_ilce, sorgu, "ilceAdi");
                   }
               }
               this.Show();
           }
           else if (kisayol.yetkim == 2)
           {
               if (ilceEkle.ShowDialog() == System.Windows.Forms.DialogResult.OK)
               {
                   if (combo_iller.Text != String.Empty)
                   {
                       String sorgu = "Select il.il_ID,ilce_ID,ilceAdi from Ilceler_Tablosu as ilce Join Iller_Tablosu as il  on il.il_ID = ilce.il_id where il.il_ID = '" + kisayol.Il_Id + "' Order BY ilceAdi asc";
                       kisayol.Veritabani_Combobox_Veri(comboBox_ilce, sorgu, "ilceAdi");
                   }
               }
               this.Show();
           }     
       }
       private void groupBox2_Enter(object sender, EventArgs e)
       {
       }
       private void btn_semt_ekle_Click_1(object sender, EventArgs e)
       {
           if (kisayol.yetkim == 1)
           {
               Yeni_Sehir semtEkle = new Yeni_Sehir(kisayol.yetkim, kisayol.Il_Id);
               this.Hide();

               semtEkle.txt_il_ismi.Hide();
               semtEkle.txt_ilce_ismi.Hide();
               semtEkle.comboBox_il_sec.Location = new Point(200, 28);
               semtEkle.combo_ilce_sec.Location = new Point(200, 89);
               semtEkle.btn_IlceEkle.Hide();
               semtEkle.btn_kaydet.Hide();
               semtEkle.btn_semtEkle.Location = new Point(280, 328);
               if (semtEkle.ShowDialog() == System.Windows.Forms.DialogResult.OK)
               {
                   if (comboBox_ilce.Text != String.Empty && combo_iller.Text != String.Empty)
                   {
                       String sorgu2 = "Select semt.semtAdi from Ilceler_Tablosu as ilce join Semt_Tablo AS semt on ilce.ilce_ID = semt.ilce_ID Where ilce.ilceAdi = '" + comboBox_ilce.Text + "' Order by semtAdi asc ";
                       kisayol.Veritabani_Combobox_Veri(comboBox_semt, sorgu, "semtAdi");
                   }
               }
               this.Show();
           }
           if (kisayol.yetkim == 2)
           {
               Yeni_Sehir semtEkle = new Yeni_Sehir(kisayol.yetkim, kisayol.Il_Id);
               this.Hide();

               semtEkle.txt_il_ismi.Hide();
               semtEkle.txt_ilce_ismi.Hide();
               semtEkle.comboBox_il_sec.Location = new Point(200, 28);
               semtEkle.combo_ilce_sec.Location = new Point(200, 89);
               semtEkle.btn_IlceEkle.Hide();
               semtEkle.btn_kaydet.Hide();
               semtEkle.btn_semtEkle.Location = new Point(280, 328);
               semtEkle.label1.Hide();
              semtEkle.comboBox_il_sec.Hide();
              semtEkle.txt_il_ismi.Hide();

              if (semtEkle.ShowDialog() == System.Windows.Forms.DialogResult.OK)
              {
                  if (comboBox_ilce.Text != String.Empty)
                  {
                      String sorgu2 = "Select semt.semtAdi from Ilceler_Tablosu as ilce join Semt_Tablo AS semt on ilce.ilce_ID = semt.ilce_ID Where ilce.ilceAdi = '" + comboBox_ilce.Text + "' Order by semtAdi asc ";
                      kisayol.Veritabani_Combobox_Veri(comboBox_semt, sorgu2, "semtAdi");
                  }            
              }
               this.Show();
           }
       }
       private void btn_kaydet_Click(object sender, EventArgs e)
       {
           Sehir_Guncelle guncelle = new Sehir_Guncelle(il_ID, ilce_ID);
           guncelle.btn_ilce.Hide();

           if (combo_iller.Text == "")
           {
               MessageBox.Show("Lutfen Guncellemek istediginiz IL'i seciniz..!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else
           {
               if (guncelle.ShowDialog() == System.Windows.Forms.DialogResult.OK)
               {
                  String iller = "Select il_ID,ilAdi from Iller_Tablosu Order by ilAdi ";
                combobox_veriler(combo_iller, iller, "il_ID", "ilAdi", il_ID, ilad);
               }
               this.Show();         
           }
       }

       private void btn_ilce_guncelle_Click(object sender, EventArgs e)
       {
           Sehir_Guncelle guncelle = new Sehir_Guncelle(il_ID,ilce_ID);
           guncelle.btn_kaydet.Hide();
           
           if ( comboBox_ilce.Text == "")
           {
               MessageBox.Show("Lutfen Guncellemek istediginiz ILCE'yi seciniz..!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else
           {
               guncelle.label1.Text = "Ilce Guncelle :";
               if (guncelle.ShowDialog() == System.Windows.Forms.DialogResult.OK)
               {
                   String sorgu2 = "Select ilce_ID,ilceAdi from Ilceler_Tablosu Where il_id = '" + il_ID + "' ";
                   combobox_veriler(comboBox_ilce, sorgu2, "ilce_ID", "ilceAdi", ilce_ID, ilcead);
               }
               this.Show();
           }
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

       private void comboBox_semt_SelectedIndexChanged(object sender, EventArgs e)
       {
           semt_ID = Convert.ToInt32((((Sinav_Gorevlendirme_Proje.Sehirler_ekran.ComboboxItem)(comboBox_semt.SelectedItem)).Value));
       }
    }
}
