using System;
using System.Windows.Forms;
using System.Data.OleDb;



namespace aracproje
{ 
    public partial class ana_menu : Form
    {
        public ana_menu()
        {
            InitializeComponent();
        }



        private Form acikEkran = null;


        private void ekEkranAcma(Form frm)
        {
            if (acikEkran != null)
                acikEkran.Close();

            acikEkran = frm;

            // formumuzun özelliklerini burada ayarkadık.
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;// formun çerçeves,n, değiştirdik
            frm.Dock = DockStyle.Fill;

            // formumuzu panel içerisine doldurduk.
            panelDesktop.Controls.Add(frm);
            panelDesktop.Tag = frm;

            // formumuzu en öne getirdik.
            frm.BringToFront();

            // formumuzu panel içinde açtık.
            frm.Show();

            // geriye gitme butonumuzu görünür hale getirdik.
            // geriBtn.Visible = true;

        }

        private void ana_menu_Load(object sender, EventArgs e)
        {
           // geriBtn.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ekEkranAcma(new randevuGecmis());
        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Form açma metot kullanımı

        private void PlakaSorgulama_Click(object sender, EventArgs e)
        {
            ekEkranAcma(new PlakaSorgulama());
        }

        private void btnCloseChild_Click(object sender, EventArgs e)
        {
            if (acikEkran != null)
                acikEkran.Close();
            //geriBtn.Visible = false;
            
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Randevular_Click(object sender, EventArgs e)
        {

            ekEkranAcma(new randevu_verme());
        }

        private void muayeneozeti_Click(object sender, EventArgs e)
        {
            ekEkranAcma(new servisEkranı());
        }

        // kapatma butonu
        private void kapatBtn_Click(object sender, EventArgs e)
        {

            DialogResult Cikis;
            Cikis = MessageBox.Show("Program kapatılacak emin misiniz?", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        // büyütme butonu
        private void buyutBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState== FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;

        }


        // küçültme butonu
        private void kucultBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void fiyatListe_Click_1(object sender, EventArgs e)
        {
            ekEkranAcma(new fiyatListesi());
        }
    }
}