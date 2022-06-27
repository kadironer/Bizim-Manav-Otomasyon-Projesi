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
    public partial class urunGuncelle_form : Form
    {
        public urunGuncelle_form()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-SVJU753\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);

        private void urunGuncelle_button_Click(object sender, EventArgs e)
        {
            float toplam_alisFiyat = 0;
            toplam_alisFiyat = (Convert.ToSingle(kilo_txt.Text) * Convert.ToSingle(alisFiyat_txt.Text));

            float toplam_satisFiyat = 0;
            toplam_satisFiyat = (Convert.ToSingle(kilo_txt.Text) * Convert.ToSingle(satisFiyat_txt.Text));
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                SqlCommand sql = new SqlCommand("update Urunler set urun_kategori='" + kategori_cbox.SelectedItem + "',urun_adi='" + turAdi_txt.Text + "',urun_kilo='" + kilo_txt.Text + "',urun_alisFiyat='" + alisFiyat_txt.Text + "',urun_satisFiyat='" + satisFiyat_txt.Text + "',toplam_alisFiyat='" + toplam_alisFiyat + "',toplam_satisFiyat='" + toplam_satisFiyat + "' where id='" + label2.Text + "'", connect);
                sql.ExecuteNonQuery();

                connect.Close();
                MessageBox.Show("Ürün Güncellendi");
                urunleriGoster_form urunlerGit = new urunleriGoster_form();
                this.Hide();
                urunlerGit.Show();
                urunleriGoster_form urun = new urunleriGoster_form();
                urun.tabloCagirUrunler();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Meydana Geldi" + hata.Message);
            }


        }

        private void kategori_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kategori_cbox.SelectedItem == "MEYVE")
            {
                turAdi_lbl.Text = "Meyve Adı Giriniz :";
                turAdi_lbl.Location = new Point(38, 241);
            }

            else if (kategori_cbox.SelectedItem == "SEBZE")
            {
                turAdi_lbl.Text = "Sebze Adı Giriniz :";
                turAdi_lbl.Location = new Point(55, 241);
            }

        }

        private void cikis_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void geriGit_button_Click(object sender, EventArgs e)
        {
            urunleriGoster_form geriGitUrunGoster = new urunleriGoster_form();
            this.Hide();
            geriGitUrunGoster.Show();
        }
    }
}