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
    public partial class randevuGecmis : Form
    {
        private OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=aracDatabase.mdb");

        public randevuGecmis()
        {
            InitializeComponent();
        }

        private void randevuGecmis_Load(object sender, EventArgs e)
        {
            randevuGemis_listeleme();
        }
        private void randevuGemis_listeleme()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            randevutbl.Items.Clear();
            komut.CommandText = "Select * From gecmistarihi";
            komut.Connection = baglanti;
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                DateTime tarih = Convert.ToDateTime(dr["randevuTarihi"]);
                ListViewItem lw = new ListViewItem(dr["plaka"].ToString());
                lw.SubItems.Add(dr["aracturu"].ToString());
                lw.SubItems.Add(dr["hizmeturu"].ToString());
                lw.SubItems.Add(tarih.ToString("d"));
                randevutbl.Items.Add(lw);
            }
            baglanti.Close();
        }

        private void randevutbl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void arama_TextChanged(object sender, EventArgs e)
        {

            if (arama.Text == "")
            {
                randevuGemis_listeleme();
            }
            else
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand();
                randevutbl.Items.Clear();
                komut.CommandText = "Select * From gecmistarihi";
                komut.Connection = baglanti;
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["plaka"].ToString().Contains(arama.Text))
                    {
                       DateTime tarih = Convert.ToDateTime(dr["randevuTarihi"]);
                        ListViewItem lw = new ListViewItem(dr["plaka"].ToString());
                        lw.SubItems.Add(dr["aracturu"].ToString());
                        lw.SubItems.Add(dr["hizmeturu"].ToString());
                        lw.SubItems.Add(tarih.ToString("d"));
                        randevutbl.Items.Add(lw);
                    }
                }
                baglanti.Close();
            }
        }
    }
    }

