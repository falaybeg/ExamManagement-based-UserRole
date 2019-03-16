using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinav_Gorevlendirme_Proje
{
    public partial class Yonetici_Secimi_Ekle : Form
    {
        public Yonetici_Secimi_Ekle(int yetki,int ilId,int ilce, int semt)
        {
            InitializeComponent();
            kisayol.yetkim = yetki;
            kisayol.Il_Id = ilId;
            kisayol.ilce_ID = ilce;
            kisayol.semt_Id = semt;
        }
        KisaYollar kisayol = new KisaYollar();

        private void Yonetici_Secimi_Ekle_Load(object sender, EventArgs e)
        {
            if (kisayol.yetkim == 1)
            { }
            else if (kisayol.yetkim == 2)
            {
                kisayol.combobox_Sil(combo_secim, "Genel Yönetici");
                kisayol.combobox_Sil(combo_secim, "İl Yöneticisi");
            }
            else if (kisayol.yetkim == 3)
            {
                kisayol.combobox_Sil(combo_secim, "Genel Yönetici");
                kisayol.combobox_Sil(combo_secim, "İl Yöneticisi");
                kisayol.combobox_Sil(combo_secim, "İl Yardımcısı");

            }
            else if (kisayol.yetkim == 4)
            {
                kisayol.combobox_Sil(combo_secim, "Genel Yönetici");
                kisayol.combobox_Sil(combo_secim, "İl Yöneticisi");
                kisayol.combobox_Sil(combo_secim, "İl Yardımcısı");
                kisayol.combobox_Sil(combo_secim, "İlçe Yöneticisi");

            }
            else if (kisayol.yetkim == 5)
            {
                kisayol.combobox_Sil(combo_secim, "Genel Yönetici");
                kisayol.combobox_Sil(combo_secim, "İl Yöneticisi");
                kisayol.combobox_Sil(combo_secim, "İl Yardımcısı");
                kisayol.combobox_Sil(combo_secim, "İlçe Yöneticisi");
                kisayol.combobox_Sil(combo_secim, "Bina Yöneticisi");

            }
            else if (kisayol.yetkim == 6)
            {
                kisayol.combobox_Sil(combo_secim, "Genel Yönetici");
                kisayol.combobox_Sil(combo_secim, "İl Yöneticisi");
                kisayol.combobox_Sil(combo_secim, "İl Yardımcısı");
                kisayol.combobox_Sil(combo_secim, "İlçe Yöneticisi");
                kisayol.combobox_Sil(combo_secim, "Bina Yöneticisi");
                kisayol.combobox_Sil(combo_secim, "Bina Yardımcısı");
            }
        }
        private void btn_devam_Click(object sender, EventArgs e)
        {
            if (combo_secim.Text == String.Empty)
            {
                kisayol.mesajBox_Butonlu("Lütfen Yönetici Seçimini yapınız !!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (combo_secim.Text == "Genel Yönetici")
            {
                kisayol.secim_gorevli = 1;
                Gorevli_Ekle yoneticiEkle = new Gorevli_Ekle(kisayol.yetkim, kisayol.secim_gorevli, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id);
                this.Hide();
                yoneticiEkle.tabControl_OkulBilgisi.TabPages.Remove(yoneticiEkle.tabPage_BinaBilgiler);
                yoneticiEkle.ShowDialog(this);
                this.Close();
            }
            else if (combo_secim.Text == "İl Yöneticisi")
            {
                kisayol.secim_gorevli = 2;
                Gorevli_Ekle yoneticiEkle = new Gorevli_Ekle(kisayol.yetkim, kisayol.secim_gorevli, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id);
                this.Hide();
                yoneticiEkle.tabControl_OkulBilgisi.TabPages.Remove(yoneticiEkle.tabPage_BinaBilgiler);
                yoneticiEkle.ShowDialog(this);
                this.Close();
            }
            else if (combo_secim.Text == "İl Yardımcısı")
            {
                kisayol.secim_gorevli = 3;
                Gorevli_Ekle yoneticiEkle = new Gorevli_Ekle(kisayol.yetkim, kisayol.secim_gorevli, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id);
                this.Hide();
                yoneticiEkle.tabControl_OkulBilgisi.TabPages.Remove(yoneticiEkle.tabPage_BinaBilgiler);
                yoneticiEkle.ShowDialog(this);
                this.Close();
            }
            else if (combo_secim.Text == "İlçe Yöneticisi")
            {
                kisayol.secim_gorevli = 4;
                Gorevli_Ekle yoneticiEkle = new Gorevli_Ekle(kisayol.yetkim, kisayol.secim_gorevli, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id);
                this.Hide();
                yoneticiEkle.tabControl_OkulBilgisi.TabPages.Remove(yoneticiEkle.tabPage_BinaBilgiler);
                yoneticiEkle.ShowDialog(this);
                this.Close();
            }
            else if (combo_secim.Text == "Bina Yöneticisi")
            {
                kisayol.secim_gorevli = 5;
                Gorevli_Ekle yoneticiEkle = new Gorevli_Ekle(kisayol.yetkim, kisayol.secim_gorevli, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id);
                this.Hide();
                yoneticiEkle.tabControl_OkulBilgisi.TabPages.Remove(yoneticiEkle.tabPage_BinaBilgiler);
                yoneticiEkle.ShowDialog(this);
                this.Close();
            }
            else if (combo_secim.Text == "Bina Yardımcısı")
            {
                kisayol.secim_gorevli = 6;
                Gorevli_Ekle yoneticiEkle = new Gorevli_Ekle(kisayol.yetkim, kisayol.secim_gorevli, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id);
                this.Hide();
                yoneticiEkle.tabControl_OkulBilgisi.TabPages.Remove(yoneticiEkle.tabPage_BinaBilgiler);

                yoneticiEkle.ShowDialog(this);
                this.Close();
            }
            else if (combo_secim.Text == "Sınav Sorumlusu")
            {
                kisayol.secim_gorevli = 7;
                Gorevli_Ekle yoneticiEkle = new Gorevli_Ekle(kisayol.yetkim, kisayol.secim_gorevli, kisayol.Il_Id, kisayol.ilce_ID, kisayol.semt_Id);
                this.Hide();
                yoneticiEkle.tabControl_OkulBilgisi.TabPages.Remove(yoneticiEkle.tabPage_BinaBilgiler);

                yoneticiEkle.ShowDialog(this);
                this.Close();
            }
        }

    }


}

