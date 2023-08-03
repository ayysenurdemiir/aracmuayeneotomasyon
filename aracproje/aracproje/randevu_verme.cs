using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace aracproje
{
    public partial class randevu_verme : Form
    {
        private OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=aracDatabase.mdb");

        private List<string> saatler = new List<string>();

        public randevu_verme()
        {
            InitializeComponent();
        }

        private void saatlerEkle()
        {
            saatler.Add("09:00");
            saatler.Add("09:30");
            saatler.Add("10:00");
            saatler.Add("10:30");
            saatler.Add("11:00");
            saatler.Add("11:30");
            saatler.Add("13:00");
            saatler.Add("13:30");
            saatler.Add("14:00");
            saatler.Add("14:30");
            saatler.Add("15:00");
            saatler.Add("15:30");
            saatler.Add("16:00");
        }

        private void randevu_verme_Load(object sender, EventArgs e)
        {
            saatlerEkle();
            randevuListeleme();
            {
                aracTur.Items.Add("OTOMOBİL");
                aracTur.Items.Add("MOTORSİKLET");
                aracTur.Items.Add("TRAKTÖR");
                aracTur.Items.Add("MİNİBÜS");
                aracTur.Items.Add("KAMYON");
                aracTur.Items.Add("ÇEKİCİ");
                aracTur.Items.Add("TANKER");
                aracTur.Items.Add("KAMYONET");
                aracTur.Items.Add("RÖMORK");
                aracTur.Items.Add("OTOBÜS");
            }
            {
                muaTur.Items.Add("BAKIM HİZMETLERİ");
                muaTur.Items.Add("LASTİK HİZMETLERİ");
                muaTur.Items.Add("KONTROL VE TESTLER");
                
            }
            {
                saati.Items.AddRange(saatler.ToArray());
            }
        }

        private void randevuListeleme()
        {
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            OleDbCommand komut = new OleDbCommand();
            randevutbl.Items.Clear();
            komut.CommandText = "Select * From randevuAlma";
            komut.Connection = baglanti;
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                DateTime saat = Convert.ToDateTime(dr["randevuSaati"]);
                DateTime tarih = Convert.ToDateTime(dr["randevuTarihi"]);
                ListViewItem lw = new ListViewItem(dr["plaka"].ToString());
                lw.SubItems.Add(dr["aracTürü"].ToString());
                lw.SubItems.Add(dr["hizmeTürü"].ToString());
                lw.SubItems.Add(tarih.ToString("d"));
                lw.SubItems.Add(saat.ToString("t"));
                randevutbl.Items.Add(lw);
            }
            baglanti.Close();
        }

        private void onayla_Click(object sender, EventArgs e)
        {
            try
            {
                if (plakaTxt.Text != "" && aracTur.Text != "" && muayeneTur.Text != "" && tarihi.Text != "" && saati.Text != "")
                {
                    if (baglanti.State == System.Data.ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }
                    OleDbCommand komut = new OleDbCommand();
                    komut.CommandText = "INSERT INTO randevuAlma(plaka ,aracTürü , hizmeTürü , randevuTarihi , randevuSaati ) VALUES (@plaka, @aractürü , @hizmeTürü , @muayenetarihi , @muayenesaati )";
                    komut.Connection = baglanti;
                    komut.Parameters.AddWithValue("@plaka", plakaTxt.Text);
                    komut.Parameters.AddWithValue("@aractürü", aracTur.Text);
                    komut.Parameters.AddWithValue("@hizmeTürü", muaTur.Text);
                    komut.Parameters.AddWithValue("@muayenetarihi", Convert.ToDateTime(tarihi.Text));
                    komut.Parameters.AddWithValue("@muayenesaati", Convert.ToDateTime(saati.Text));

                    MessageBox.Show("kayıt başarılı");
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    randevuListeleme();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Ayşenur Oto programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void arama_TextChanged(object sender, EventArgs e)
        {
            if (arama.Text == "")
            {
                randevuListeleme();
            }
            else
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                OleDbCommand komut = new OleDbCommand();
                randevutbl.Items.Clear();
                komut.CommandText = "Select * From randevuAlma";
                komut.Connection = baglanti;
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["plaka"].ToString().Contains(arama.Text))
                    {
                        DateTime saat = Convert.ToDateTime(dr["randevuSaati"]);
                        DateTime tarih = Convert.ToDateTime(dr["randevuTarihi"]);
                        ListViewItem lw = new ListViewItem(dr["plaka"].ToString());
                        lw.SubItems.Add(dr["aracTürü"].ToString());
                        lw.SubItems.Add(dr["hizmeTürü"].ToString());
                        lw.SubItems.Add(tarih.ToString("d"));
                        lw.SubItems.Add(saat.ToString("t"));
                        randevutbl.Items.Add(lw);
                    }
                }
                baglanti.Close();
            }
        }

        private void tarihi_ValueChanged_1(object sender, EventArgs e)
        {
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            OleDbCommand komut = new OleDbCommand();
            komut.CommandText = "Select * From randevuAlma";
            komut.Connection = baglanti;
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               
                DateTime saat = Convert.ToDateTime(dr["randevuSaati"]);
                DateTime tarih = Convert.ToDateTime(dr["randevuTarihi"]);
                if (tarih.ToString("d") == tarihi.Text && saatler.Contains(saat.ToString("t")))
                {
                    saatler.Remove(saat.ToString("t"));
                    break;
                }
            }
            saati.Items.Clear();
            saati.Items.AddRange(saatler.ToArray());
            baglanti.Close();
        }

        private void muaTur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aracTur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void randevutbl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void silmeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                    baglanti.Open();
                OleDbCommand komut = new OleDbCommand("delete from randevuAlma where plaka='" + randevutbl.SelectedItems[0].SubItems[0].Text+"'",baglanti);
                komut.ExecuteReader();
                baglanti.Close();
                randevuListeleme();
            }
            catch (Exception)
            {
                MessageBox.Show("lütfen silmeden önce tablodan veri seçiniz.");
            }
            
        }
    }
}