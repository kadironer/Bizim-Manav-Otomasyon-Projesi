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
    public partial class kayıtOl_form : Form
    {
        public kayıtOl_form()
        {
            InitializeComponent();
        }
        static string conString = "Data Source=DESKTOP-SVJU753\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True";
        SqlConnection connect = new SqlConnection(conString);

        private void geriGit_button_Click(object sender, EventArgs e)
        {
            anaSayfa geriAnasayfa = new anaSayfa();
            this.Hide();
            geriAnasayfa.Show();
        }

        private void cikis_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kayitOl_button_Click(object sender, EventArgs e)
        {
            if (adKayit_txt.Text == "")
            {
                MessageBox.Show("Adı eksiksiz doldurunuz");
            }

            else if (soyadKayit_txt.Text == "")
            {
                MessageBox.Show("Soyadı eksiksiz doldurunuz");
            }

            else if (emailKayit_txt.Text == "")
            {
                MessageBox.Show("Mail adresini eksiksiz doldurunuz");
            }

            else if (sifreKayit_txt.Text == "")
            {
                MessageBox.Show("Şifreyi eksiksiz doldurunuz");
            }

            else
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();
                    string kayit = "insert into Kisiler (adi,soyadi,email,sifre) values(@adi,@soyadi,@email,@sifre)";
                    SqlCommand komut = new SqlCommand(kayit, connect);

                    komut.Parameters.AddWithValue("@adi", adKayit_txt.Text);
                    komut.Parameters.AddWithValue("@soyadi", soyadKayit_txt.Text);
                    komut.Parameters.AddWithValue("@email", emailKayit_txt.Text);
                    komut.Parameters.AddWithValue("@sifre", sifreKayit_txt.Text);

                    komut.ExecuteNonQuery();

                    connect.Close();
                    MessageBox.Show("Kayıt Olundu");
                    profilAnasayfa formProfilAnasayfa = new profilAnasayfa();
                    this.Hide();
                    formProfilAnasayfa.Show();

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata Meydana Geldi" + hata.Message);
                }
            }
        }

        private void adKayit_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            adKayit_txt.CharacterCasing = CharacterCasing.Upper;
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void soyadKayit_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            soyadKayit_txt.CharacterCasing = CharacterCasing.Upper;
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    }
}
