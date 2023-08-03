using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace aracproje
{
    public partial class PlakaSorgulama : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=aracDatabase.mdb");

        string plaka;

        public PlakaSorgulama()
        {
            InitializeComponent();
        }
        

        private void PlakaSor_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlakaSorgulama_Load(object sender, EventArgs e)
        {
            sorguPanel.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new ana_menu().Show();
            this.Close();
        }

        private void AracPlaka_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sorguPanel.Visible = true;
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select*from aracBorc", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr["plaka"].ToString()==PlakaSor.Text)
                {
                    DateTime dt = Convert.ToDateTime(dr["sahiplikTarihi"]);
                    plakaLbl.Text = "Plaka : "+ dr["plaka"].ToString();
                    sahibLBL.Text = "Araç Sahibi : " + dr["isimSoyisim"].ToString();
                    markalbl.Text = "Marka : " + dr["marka"].ToString();
                    modelLbl.Text = "Model : " + dr["model"].ToString();
                    renkLbl.Text = "Renk : " + dr["renk"].ToString();
                    tarihLbl.Text = "Sahiplik Tarihi : " + dt.ToString("dd/MM/yyyy");

                }
                
            }
            baglanti.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
