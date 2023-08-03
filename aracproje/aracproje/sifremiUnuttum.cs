using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace aracproje
{
    public partial class sifremiUnuttum : Form
    {
        string sifre; 
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=aracDatabase.mdb");

        public sifremiUnuttum()
        {
            InitializeComponent();
        }

        private void sifremiUnuttum_Load(object sender, EventArgs e)
        {

        }

        public bool MailGonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("aracmuayenerandevuproje@gmail.com");
            ePosta.To.Add(mailTxtbx.Text); //göndereceğimiz mail adresi

            ePosta.Subject = konu; //mail konusu
            ePosta.Body = icerik; //mail içeriği 

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("aracmuayenerandevuproje@gmail.com", "aracmuayene123");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                MessageBox.Show(ex.Message);
            }
            return kontrol;
        }

        private void gndrBtn_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                OleDbCommand komut = new OleDbCommand("select * from kullanicilar where mail='" + mailTxtbx.Text + "'", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    sifre = oku["sifre"].ToString();

                    mesajLbl.Visible = true;
                    mesajLbl.ForeColor = Color.Green;
                    mesajLbl.Text = "Girmiş Olduğunuz Bilgiler Uyuşuyor Şifreniz Mail Olarak Gönderildi";

                    MailGonder("ŞİFRE HATIRLATMA", "Sistemimizde kayıtlı olan şifreniz " + sifre+"'dir.");
                    baglanti.Close();
                }
                else
                {
                    mesajLbl.Visible = true;
                    mesajLbl.ForeColor = Color.Red;
                    mesajLbl.Text = "Girmiş Olduğunuz Bilgiler Uyuşmuyor";
                }
            }
            catch (Exception )
            {
                mesajLbl.Visible = true;
                mesajLbl.ForeColor = Color.Red;
                mesajLbl.Text = "Mail Gönderme Hatası";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

