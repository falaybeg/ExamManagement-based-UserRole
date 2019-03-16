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
    public partial class Gorevli_Onay : Form
    {
        public Gorevli_Onay()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            onay_ekrani onaylaEkran = new onay_ekrani();
            onaylaEkran.ShowDialog();
        }

        private void Gorevli_Onay_Load(object sender, EventArgs e)
        {

        }

        private void datagridView_OnayListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();         
            onay_ekrani onayla = new onay_ekrani();
            onayla.ShowDialog(this);      
            this.Show();

        }
    }
}
