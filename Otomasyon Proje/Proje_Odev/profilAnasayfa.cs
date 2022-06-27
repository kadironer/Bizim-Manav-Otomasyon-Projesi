using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Odev
{
    public partial class profilAnasayfa : Form
    {
        public profilAnasayfa()
        {
            InitializeComponent();
        }

        private void cikis_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void geriGit_button_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Geri gitmek istiyor musunuz ? (Yeniden giriş yapmak zorundasınız.)", "Uyarı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                anaSayfa geriAnasayfa = new anaSayfa();
                this.Hide();
                geriAnasayfa.Show();
            }
            else
            {
                MessageBox.Show("İşleminiz iptal edildi");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void urunEkle_button_Click(object sender, EventArgs e)
        {
            urunEkle_form urunEkleGit = new urunEkle_form();
            this.Hide();
            urunEkleGit.Show();
        }

        private void urunSatıs_button_Click(object sender, EventArgs e)
        {
            urunSatis_form urunSatisGit = new urunSatis_form();
            this.Hide();
            urunSatisGit.Show();
        }

        private void musteriler_button_Click(object sender, EventArgs e)
        {
            musteriler_form musterilerGit = new musteriler_form();
            this.Hide();
            musterilerGit.Show();
        }

        private void urunGoster_button_Click(object sender, EventArgs e)
        {
            urunleriGoster_form urunGosterGit = new urunleriGoster_form();
            this.Hide();
            urunGosterGit.Show();
        }

        private void gunlukRapor_button_Click(object sender, EventArgs e)
        {
            gunlukRaporlar_form gunlukRaporlarGit = new gunlukRaporlar_form();
            this.Hide();
            gunlukRaporlarGit.Show();
        }
    }
}
