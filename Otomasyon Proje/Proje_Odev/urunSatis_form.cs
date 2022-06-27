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
    public partial class urunSatis_form : Form
    {
        public urunSatis_form()
        {
            InitializeComponent();
        }

        static string conString = "Data Source=DESKTOP-SVJU753\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);
        DataTable tablo = new DataTable();
        public void dgv1Tablo()
        {
            SqlCommand sql = new SqlCommand("select id, urun_kategori,urun_adi,urun_kilo,urun_satisFiyat from Urunler", connect);
            SqlDataAdapter dta = new SqlDataAdapter(sql);
            DataTable table = new DataTable();
            dta.Fill(table);
            dataGridView1.DataSource = table;
        }
        float toplam;
        public void dataGrid1TodataGrid2()
        {
            float toplam_tutar = Convert.ToSingle(dataGridView1.CurrentRow.Cells[4].Value) * Convert.ToSingle(kilo_txt.Text);
            tablo.Rows.Add(dataGridView1.CurrentRow.Cells[2].Value.ToString(),kilo_txt.Text, dataGridView1.CurrentRow.Cells[4].Value.ToString(),toplam_tutar.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(),dataGridView1.CurrentRow.Cells[0].Value,dataGridView1.CurrentRow.Cells[1].Value);
            dataGridView2.DataSource = tablo;
            toplam = 0;

            string satis_fiyati,kilo;
            satis_fiyati = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kilo = kilo_txt.Text;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                toplam += Convert.ToSingle(dataGridView2.Rows[i].Cells[3].Value);

                string toplam_kilo = dataGridView2.Rows[i].Cells[4].Value.ToString();
                string satilan_kilo = dataGridView2.Rows[i].Cells[1].Value.ToString();
                
              
            }
            toplam_satis.Text = Convert.ToString(toplam);
            kilo_txt.Text = "";

        }
        private void urunSatis_form_Load(object sender, EventArgs e)
        {
            dgv1Tablo();
            tablo.Columns.Add("Ürün Adı", typeof(string));
            tablo.Columns.Add("Kilo", typeof(string));
            tablo.Columns.Add("Satış Fiyatı", typeof(string));
            tablo.Columns.Add("Toplam Tutar", typeof(string));
            tablo.Columns.Add("Toplam Kilo", typeof(string));
            tablo.Columns.Add("Ürün ID", typeof(int));
            tablo.Columns.Add("Kategori Adı", typeof(string));

            dataGridView2.DataSource = tablo;

            dataGridView1.Columns[0].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
            

        }
        private void urunArama_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string select = "select urun_kategori,urun_adi,urun_kilo,urun_satisFiyat from Urunler" + " where(urun_adi like '%" + urunArama_txt.Text + "%')";

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
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            if (kilo_txt.Text=="")
            {
                MessageBox.Show("Satılacak kiloyu giriniz");
            }
            else {
            dataGrid1TodataGrid2();
            }
        }

        private void satıs_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                
                string toplam_kilo = dataGridView2.Rows[i].Cells[4].Value.ToString();
                string satilan_kilo = dataGridView2.Rows[i].Cells[1].Value.ToString();
                string satis_fiyati= dataGridView2.Rows[i].Cells[2].Value.ToString();
                if (Convert.ToSingle(toplam_kilo)-Convert.ToSingle(satilan_kilo)>=0)
                {
                    string toplam_fiyat = (Convert.ToSingle(satilan_kilo) * Convert.ToSingle(satis_fiyati)).ToString();
                    string guncel_kilo = (Convert.ToInt32(toplam_kilo) - Convert.ToInt32(satilan_kilo)).ToString();
                    int id = Convert.ToInt32(dataGridView2.Rows[i].Cells[5].Value);
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();

                    SqlCommand stock = new SqlCommand("update Urunler Set urun_kilo='" + guncel_kilo.ToString() + "'where id='" + id + "'", connect);
                    SqlCommand satilan_urunler=new SqlCommand("insert into satilan_urunler (urun_adi,urun_kategori,urun_satisFiyati,satilan_kilo,toplam_fiyat,tarih ) values(@urun_adi,@urun_kategori,@urun_satisFiyati,@satilan_kilo,@toplam_fiyat,@tarih)", connect);
                    satilan_urunler.Parameters.AddWithValue("@urun_kategori",dataGridView2.Rows[i].Cells[6].Value );
                    satilan_urunler.Parameters.AddWithValue("@urun_satisFiyati", dataGridView2.Rows[i].Cells[2].Value);
                    satilan_urunler.Parameters.AddWithValue("@urun_adi", dataGridView2.Rows[i].Cells[0].Value);
                    satilan_urunler.Parameters.AddWithValue("@satilan_kilo", dataGridView2.Rows[i].Cells[1].Value);
                    satilan_urunler.Parameters.AddWithValue("@toplam_fiyat", toplam_fiyat);
                    satilan_urunler.Parameters.AddWithValue("@tarih", Convert.ToDateTime(dtpSales.Text));

                    stock.ExecuteNonQuery();
                    satilan_urunler.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Ürün Satıldı");
                }
                else
                {
                    MessageBox.Show("Ürün Kalmamıştır.Yeni Ürün Ekleyin");
                }
                
            }
            tablo.Rows.Clear();
            dgv1Tablo();

            
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

        private void kilo_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void urunArama_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            urunArama_txt.CharacterCasing = CharacterCasing.Upper;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpSales_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
