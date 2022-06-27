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
using System.Data.Sql;

namespace Proje_Odev
{
    public partial class gunlukRaporlar_form : Form
    {
        public gunlukRaporlar_form()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-SVJU753\\SQLEXPRESS;Initial Catalog=uyeKayit;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);
        public void tabloCagir()
        {
            float toplam = 0;
            if (connect.State == ConnectionState.Closed)
                connect.Open();

            SqlDataAdapter dta = new SqlDataAdapter("select urun_adi,urun_satisFiyati,toplam_fiyat,urun_kategori,satilan_kilo from satilan_urunler where tarih='" + dtpSales.Value.ToString("yyyyMMdd") + "'", connect);
            DataTable table = new DataTable();
            dta.Fill(table);
            dataGridView1.DataSource = table;
            toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string toplam1 = dataGridView1.Rows[i].Cells[2].Value.ToString();
                toplam += Convert.ToSingle(toplam1);
            }
            toplamFiyat_lbl.Text = toplam.ToString();

            connect.Close();
        }
        private void gunlukRaporlar_form_Load(object sender, EventArgs e)
        {
            tabloCagir();
        }

        private void dtpSales_ValueChanged(object sender, EventArgs e)
        {
            tabloCagir();
        }

        private void cikis_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void geriGit_button_Click(object sender, EventArgs e)
        {
            profilAnasayfa geriGitProfilAnasayfa = new profilAnasayfa();
            this.Hide();
            geriGitProfilAnasayfa.Show();
        }
    }
}
