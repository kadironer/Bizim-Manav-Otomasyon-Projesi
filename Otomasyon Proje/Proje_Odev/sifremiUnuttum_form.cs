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
using System.Net.Mail;
using System.Security;

namespace Proje_Odev
{
    public partial class sifremiUnuttum_form : Form
    {
    
        public sifremiUnuttum_form()
        {
            InitializeComponent();
        }


        private void cikis_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void geriGit_button_Click(object sender, EventArgs e)
        {  
            girisYap_form geriGirisYap = new girisYap_form();
            this.Hide();
            geriGirisYap.Show();
        }
       
        public bool mailGonder(string konu, string icerik)
        {
            MailMessage eMail = new MailMessage();
            eMail.From = new MailAddress("kadironerders@gmail.com");
            eMail.To.Add(sifreUnuttum_txt.Text);
            eMail.Subject = konu;
            eMail.Body = icerik;
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("kadironerders@gmail.com", "Kadir.oner46");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Send(eMail);
            object userState = true;
            bool kontrol = true;
            try
            {
                client.SendAsync(eMail, (object)eMail);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                MessageBox.Show(ex.Message);
            }
            return kontrol;

        }
        string sifre;

        private void sifreGonder_button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connect = new SqlConnection("Data Source=DESKTOP-SVJU753\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True");
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                SqlCommand komut = new SqlCommand("select * from Kisiler where email='" + sifreUnuttum_txt.Text + "'");
                {
                    komut.Connection = connect;
                };
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    sifre = oku["sifre"].ToString();

                    lblHata.Visible = true;
                    lblHata.ForeColor = Color.Green;
                    lblHata.Text = "Şifreniz mail olarak gönderilmiştir";


                    mailGonder("ŞİFRE HATIRLATMA", "Şifreniz: " + sifre);
                    connect.Close();
                }
                else
                {
                    lblHata.Visible = true;
                    lblHata.ForeColor = Color.Red;
                    lblHata.Text = "Girmiş Olduğunuz Bilgiler Uyuşmuyor";
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata", hata.Message);
                lblHata.Visible = true;
                lblHata.ForeColor = Color.Red;
                lblHata.Text = "Mail Gönderme Hatası";

            }
        }
    }
}


