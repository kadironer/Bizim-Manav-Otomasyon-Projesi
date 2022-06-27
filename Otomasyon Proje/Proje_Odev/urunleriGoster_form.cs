using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Proje_Odev
{
    public partial class urunleriGoster_form : Form
    {
        public urunleriGoster_form()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-SVJU753\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);
        public void tabloCagirUrunler()
        {
            SqlCommand sql = new SqlCommand("select * from Urunler", connect);
            SqlDataAdapter dta = new SqlDataAdapter(sql);
            DataTable table = new DataTable();
            dta.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void urunleriGoster_form_Load(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("select * from Urunler", connect);
            SqlDataAdapter dta = new SqlDataAdapter(sql);
            DataTable table = new DataTable();
            dta.Fill(table);
            dataGridView1.DataSource = table;
        }


        private void urunEkle_button_Click(object sender, EventArgs e)
        {
            urunEkle_form urunEkleGit = new urunEkle_form();
            this.Hide();
            urunEkleGit.Show();
        }

        private void urunSil_button_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Ürünü silmek istiyor musunuz ? (Silerseniz ürün bilgileri kaybolacaktır.)", "Uyarı", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();
                    SqlCommand sql = new SqlCommand("delete from Urunler where id='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", connect);
                    sql.ExecuteNonQuery();
                    connect.Close();
                    tabloCagirUrunler();
                    MessageBox.Show("Ürün Silindi");

                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Meydana Geldi" + hata.Message);
            }
        }

        private void urunGuncelle_button_Click(object sender, EventArgs e)
        {

            urunGuncelle_form urunGuncelleGit = new urunGuncelle_form();

            
            this.Hide();
            urunGuncelleGit.Show();
            urunGuncelleGit.label2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            urunGuncelleGit.kategori_cbox.SelectedItem = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            urunGuncelleGit.turAdi_txt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            urunGuncelleGit.kilo_txt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            urunGuncelleGit.alisFiyat_txt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            urunGuncelleGit.satisFiyat_txt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void urunArama_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string select = "select * from Urunler" + " where(urun_adi like '%" + urunArama_txt.Text + "%')";

                SqlDataAdapter adp = new SqlDataAdapter(select, connect);
                DataTable dta = new DataTable();
                adp.Fill(dta);
                dataGridView1.DataSource = dta;
                connect.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Meydana Geldi" + hata.Message);
            }
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
