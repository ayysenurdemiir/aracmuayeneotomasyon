using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Net.Mail;

namespace aracproje
{
    public partial class giris_ekranı : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=aracDatabase.mdb");

        int giris_hakkı = 3;
        public giris_ekranı()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // şifremi unuttum butonunu görünmez yapıyor.
            sifremiUnuttum_BTN.Visible = true;
            sifre_TXT.PasswordChar = '*';
            gizle.Text = "Göster";
        }

        private void giris_BTN_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            ana_menu anaMenu = new ana_menu();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM kullanicilar", baglanti);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                if (okuyucu["kullanici_ad"].ToString() == kullaniciad_TXT.Text && okuyucu["sifre"].ToString() == sifre_TXT.Text)
                {
                    anaMenu.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    giris_hakkı -= 1;
                    MessageBox.Show("giriş başarısız kalan hakkınız : " + giris_hakkı);
                    if (giris_hakkı == 0)
                    {
                        sifremiUnuttum_BTN.Visible = true;
                        giris_BTN.Enabled = false;
                    }
                    return;
                }
            }
            baglanti.Close();
        }

        private void sifremiUnuttum_BTN_Click(object sender, EventArgs e)
        {
            sifremiUnuttum sifreEkran = new sifremiUnuttum();
            sifreEkran.Show();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (gizle.Checked)
            {
                sifre_TXT.PasswordChar = '\0';
                gizle.Text = "Gizle";
            }
            else if (!gizle.Checked)
            {
                sifre_TXT.PasswordChar = '*';
                gizle.Text = "Göster";
            }
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void kullaniciad_TXT_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void kapatBtn_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Program kapatılacak emin misiniz?", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

       

