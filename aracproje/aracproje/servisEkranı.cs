using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace aracproje
{
    public partial class servisEkranı : Form
    {
        private OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=aracDatabase.mdb");
        string plaka, hizmet, tutar;
        public servisEkranı()
        {
            InitializeComponent();
        }

        private void servisEkranı_Load(object sender, EventArgs e)
        {
            listelme();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listelme()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            randevutbl.Items.Clear();
            komut.CommandText = "Select * From gecmistarihi";
            komut.Connection = baglanti;
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lw = new ListViewItem(dr["plaka"].ToString());
                lw.SubItems.Add(dr["servisdetayı"].ToString());
                lw.SubItems.Add(dr["tutar"].ToString());
                randevutbl.Items.Add(lw);
            }
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                listelme();
            }
            else
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                OleDbCommand komut = new OleDbCommand();
                randevutbl.Items.Clear();
                komut.CommandText = "Select * From gecmistarihi";
                komut.Connection = baglanti;
                OleDbDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["plaka"].ToString().Contains(textBox1.Text))
                    {
                        ListViewItem lw = new ListViewItem(dr["plaka"].ToString());
                        lw.SubItems.Add(dr["servisdetayı"].ToString());
                        lw.SubItems.Add(dr["tutar"].ToString());
                        
                        randevutbl.Items.Add(lw);
                    }
                }
                baglanti.Close();
            }
        }
    

        private void tutarBtn_Click(object sender, EventArgs e)
        {
            if (baglanti.State == System.Data.ConnectionState.Closed)
                baglanti.Open();

            OleDbCommand komut = new OleDbCommand("update gecmistarihi set tutar = @t where plaka = '"+plaka+"'",baglanti);
            komut.Parameters.AddWithValue("@t", Convert.ToInt32(tutarTxt.Text));
            komut.ExecuteReader();
            baglanti.Close();
            listelme();

        }

        private void randevutbl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (randevutbl.SelectedItems[0]!=null)
            {
                foreach (var item in randevutbl.SelectedItems)
                {
                    plaka = randevutbl.SelectedItems[0].SubItems[0].Text;
                    hizmet = randevutbl.SelectedItems[0].SubItems[1].Text;
                    tutar = randevutbl.SelectedItems[0].SubItems[2].Text;
                }
            }
        }
    }
}