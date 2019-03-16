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
    public partial class onay_ekrani : Form
    {
        public onay_ekrani()
        {
            InitializeComponent();
        }
        KisaYollar kisayol = new KisaYollar();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            kisayol.mesajBox_Butonlu("Görevli Kaydı Başarıyla Onaylandı !!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_reddet_Click(object sender, EventArgs e)
        {
            this.Close();
            kisayol.mesajBox_Butonlu("Görevli kaydı onayı reddedildi !!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void onay_ekrani_Load(object sender, EventArgs e)
        {

        }
    }
}
