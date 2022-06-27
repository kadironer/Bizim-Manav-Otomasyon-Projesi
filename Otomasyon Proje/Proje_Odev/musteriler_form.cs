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
    public partial class musteriler_form : Form
    {
        public musteriler_form()
        {
            InitializeComponent();
        }

        static string conString = "Data Source=DESKTOP-SVJU753\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);

        public void tabloCagir()
        {
            SqlCommand sql = new SqlCommand("select * from musteriler", connect);
        SqlDataAdapter dta = new SqlDataAdapter(sql);
        DataTable table = new DataTable();
        dta.Fill(table);
            dataGridView1.DataSource = table;
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

        private void musteriler_form_Load(object sender, EventArgs e)
        {
            tabloCagir();
        }

        private void musteriEkle_button_Click(object sender, EventArgs e)
        {
            musteriEkle_form musteriEkleGit = new musteriEkle_form();
            this.Hide();
            musteriEkleGit.Show();
        }

        private void musteriGuncelle_button_Click(object sender, EventArgs e)
        {

            musteriGuncelle_form guncelleGit = new musteriGuncelle_form();
            guncelleGit.Show();

            guncelleGit.label5.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            guncelleGit.musteriAdi_txt.Text =dataGridView1.CurrentRow.Cells[1].Value.ToString();
            guncelleGit.musteriSoyadi_txt.Text =dataGridView1.CurrentRow.Cells[2].Value.ToString();
           guncelleGit.musteriTelefon_txt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           guncelleGit.musteriBorc_txt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void musteriSil_button_Click(object sender, EventArgs e)
        {
            try
            {



                string musteri_adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string musteri_soyadi = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("" + musteri_adi + " " + musteri_soyadi + " adlı müşteriyi silmek istiyor musunuz ? (Silerseniz bilgiler kaybolacaktır.)", "Uyarı", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();
                    SqlCommand sql = new SqlCommand("delete from musteriler where telefon_no='" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "'", connect);
                    sql.ExecuteNonQuery();
                    connect.Close();
                    tabloCagir();
                    MessageBox.Show("Müşteri Silindi");
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

        private void musteriAra_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string select="select * from musteriler" + " where(musteri_adi like '%" + musteriAra_txt.Text + "%')or(musteri_soyadi like '%" + musteriAra_txt.Text + "%')or(telefon_no like '%" + musteriAra_txt.Text + "%') ";

                SqlDataAdapter adp = new SqlDataAdapter(select,connect);
                DataTable dta = new DataTable();
                adp.Fill(dta);
                dataGridView1.DataSource = dta;
                connect.Close();
            }
            catch(Exception hata)
            {
                MessageBox.Show("Hata Meydana Geldi" + hata.Message);
            }
        }

        private void musteriAra_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            musteriAra_txt.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
