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
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
        }

        private void cikis_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void girisYap_button_Click(object sender, EventArgs e)
        {
            girisYap_form formGiris = new girisYap_form();
            this.Hide();
            formGiris.Show();
        }

        private void kayitOl_button_Click(object sender, EventArgs e)
        {
            kayıtOl_form formKayit = new kayıtOl_form();
            this.Hide();
            formKayit.Show();
        }
    }
}
