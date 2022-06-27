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
    public partial class musteriEkle_form : Form
    {
        public musteriEkle_form()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-SVJU753\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);

        private void musteriEkle_button_Click(object sender, EventArgs e)
        {
            if (musteriAdi_txt.Text == "")
            {
                MessageBox.Show("Müşteri adını yazınız");
            }
            else if (musteriSoyadi_txt.Text == "")
            {
                MessageBox.Show("Müşteri soyadını yazınız");
            }
            else if (musteriTelefon_txt.Text == "")
            {
                MessageBox.Show("Telefon numarasını yazınız");
            }
            else
            {


                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();
                    string urunKayit = "insert into musteriler (musteri_adi,musteri_soyadi,telefon_no,toplam_borc) values(@musteri_adi,@musteri_soyadi,@telefon_no,@toplam_borc)";
                    SqlCommand komut = new SqlCommand(urunKayit, connect);

                    komut.Parameters.AddWithValue("@musteri_adi", musteriAdi_txt.Text);
                    komut.Parameters.AddWithValue("@musteri_soyadi", musteriSoyadi_txt.Text);
                    komut.Parameters.AddWithValue("@telefon_no", musteriTelefon_txt.Text);
                    komut.Parameters.AddWithValue("@toplam_borc", musteriBorc_txt.Text);



                    komut.ExecuteNonQuery();

                    connect.Close();
                    MessageBox.Show("Müşteri Eklendi");
                    musteriler_form musterilerGit = new musteriler_form();
                    this.Hide();
                    musterilerGit.tabloCagir();
                    musterilerGit.Show();


                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata Meydana Geldi" + hata.Message);
                }
            }
        }

        private void geriGit_button_Click(object sender, EventArgs e)
        {
            musteriler_form geriGitMusteriler = new musteriler_form();
            this.Hide();
            geriGitMusteriler.Show();
        }

        private void cikis_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }



        private void musteriSoyadi_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            musteriSoyadi_txt.CharacterCasing = CharacterCasing.Upper;
            
        }


        private void musteriBorc_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void musteriAdi_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            musteriAdi_txt.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
