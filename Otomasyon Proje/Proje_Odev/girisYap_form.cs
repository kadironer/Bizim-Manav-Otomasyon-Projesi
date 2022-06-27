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
    public partial class girisYap_form : Form
    {
        public girisYap_form()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        private void cikis_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void geriGit_button_Click(object sender, EventArgs e)
        {
            
        }

        private void sifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremiUnuttum_form formSifremiUnuttum = new sifremiUnuttum_form();
            this.Hide();
            formSifremiUnuttum.Show();
        }

        private void girisYap_button_Click(object sender, EventArgs e)
        {
            if (email_txt.Text == "")
            {
                MessageBox.Show("Tüm bilgileri eksiksiz doldurunuz");
            }
            else if (sifre_txt.Text == "")
            {
                MessageBox.Show("Tüm bilgileri eksiksiz doldurunuz");
            }

            else
            {
                con = new SqlConnection("Data Source=DESKTOP-SVJU753\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True");
                com = new SqlCommand();
                con.Open();
                com.Connection = con;
                com.CommandText = "select * from Kisiler where email='" + email_txt.Text + "' And sifre='" + sifre_txt.Text + "'";

                dr = com.ExecuteReader();
                if (dr.Read())
                {

                    MessageBox.Show("Giriş Başarılı");
                    profilAnasayfa formProfilAnasayfa = new profilAnasayfa();
                    this.Hide();
                    formProfilAnasayfa.Show();
                }
                else
                {
                    MessageBox.Show("E-posta ya da Şifre hatalı Lütfen yeniden deneyiniz");
                }
                con.Close();
            }
        }

        private void geriGit_button_Click_1(object sender, EventArgs e)
        {
            anaSayfa geriAnasayfa = new anaSayfa();
            this.Hide();
            geriAnasayfa.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sifremiUnuttum_form sifreGit = new sifremiUnuttum_form();
            this.Hide();
            sifreGit.Show();
        }
    }
}
