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
    public partial class urunEkle_form : Form
    {
        public urunEkle_form()
        {
            InitializeComponent();
        }


        static string conString = "Data Source=DESKTOP-SVJU753\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);

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

        private void kategori_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kategori_cbox.SelectedItem == "MEYVE")
            {
                turAdi_lbl.Text = "Meyve Adı Giriniz :";
                turAdi_lbl.Location = new Point(38, 241);

                turAdi_lbl.Visible = true;
                turAdi_txt.Visible = true;

                kilo_lbl.Visible = true;
                kilo_txt.Visible = true;

                alisFiyat_lbl.Visible = true;
                alisFiyat_txt.Visible = true;

                satisFiyat_lbl.Visible = true;
                satisFiyat_txt.Visible = true;

                urunEkle_button.Visible = true;

            }
            else if (kategori_cbox.SelectedItem == "SEBZE")
            {
                turAdi_lbl.Text = "Sebze Adı Giriniz :";
                turAdi_lbl.Location = new Point(55, 241);

                turAdi_lbl.Visible = true;
                turAdi_txt.Visible = true;

                kilo_lbl.Visible = true;
                kilo_txt.Visible = true;

                alisFiyat_lbl.Visible = true;
                alisFiyat_txt.Visible = true;

                satisFiyat_lbl.Visible = true;
                satisFiyat_txt.Visible = true;

                urunEkle_button.Visible = true;
            }
        }

        private void turAdi_txt_TextChanged(object sender, EventArgs e)
        {

            turAdi_txt.CharacterCasing = CharacterCasing.Upper;
        }


        private void kilo_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void alisFiyat_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void satisFiyat_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void urunEkle_button_Click(object sender, EventArgs e)
        {
            if (turAdi_txt.Text == "" && kategori_cbox.SelectedItem=="MEYVE")
            {
                MessageBox.Show("Meyve adını yazınız");
            }
            else if (turAdi_txt.Text == "" && kategori_cbox.SelectedItem == "SEBZE")
            {
                MessageBox.Show("Sebze adını yazınız");
            }
            else if (kilo_txt.Text == "")
            {
                MessageBox.Show("Kiloyu giriniz");
            }
            else if (alisFiyat_txt.Text == "")
            {
                MessageBox.Show("Alış fiyatını giriniz");
            }
            else if (satisFiyat_txt.Text == "")
            {
                MessageBox.Show("Satış fiyatını giriniz");
            }
            else
            {


                float toplam_alisFiyat = 0;
                toplam_alisFiyat = (Convert.ToSingle(kilo_txt.Text) * Convert.ToSingle(alisFiyat_txt.Text));

                float toplam_satisFiyat = 0;
                toplam_satisFiyat = (Convert.ToSingle(kilo_txt.Text) * Convert.ToSingle(satisFiyat_txt.Text));


                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();
                    string urunKayit = "insert into Urunler (urun_kategori,urun_adi,urun_kilo,urun_alisFiyat,urun_satisFiyat,toplam_alisFiyat,toplam_satisFiyat) values(@urun_kategori,@urun_adi,@urun_kilo,@urun_alisFiyat,@urun_satisFiyat,@toplam_alisFiyat,@toplam_satisFiyat)";
                    SqlCommand komut = new SqlCommand(urunKayit, connect);

                    komut.Parameters.AddWithValue("@urun_kategori", kategori_cbox.SelectedItem);
                    komut.Parameters.AddWithValue("@urun_adi", turAdi_txt.Text);
                    komut.Parameters.AddWithValue("@urun_kilo", kilo_txt.Text);
                    komut.Parameters.AddWithValue("@urun_alisFiyat", alisFiyat_txt.Text);
                    komut.Parameters.AddWithValue("@urun_satisFiyat", satisFiyat_txt.Text);
                    komut.Parameters.AddWithValue("@toplam_alisFiyat", toplam_alisFiyat.ToString());
                    komut.Parameters.AddWithValue("@toplam_satisFiyat", toplam_satisFiyat.ToString());


                    komut.ExecuteNonQuery();

                    connect.Close();
                    MessageBox.Show("Ürün Eklendi");
                    profilAnasayfa profilAnasayfaGit = new profilAnasayfa();
                    this.Hide();
                    profilAnasayfaGit.Show();


                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata Meydana Geldi" + hata.Message);
                }
            }
        }
    }
}

