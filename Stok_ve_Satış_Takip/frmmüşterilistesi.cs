using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class frmmüşterilistesi : Form
    {
        public frmmüşterilistesi()
        {
            InitializeComponent();
        }

        private void btncikis1_Click(object sender, EventArgs e)
        {
            Close();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\StokVerisi.accdb");
        DataSet daset = new DataSet();

        private void frmmüşterilistesi_Load(object sender, EventArgs e)
        {
            Kayıt_Goster();
        }

        private void Kayıt_Goster()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *from Müşteriler", baglanti);
            adtr.Fill(daset, "Müşteriler");
            dataGridView1.DataSource = daset.Tables["Müşteriler"];
            baglanti.Close();
        }


        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Müşteriler set AdSoyad='" + txtAdsoyad.Text + "',Telefon='" + txtTelefon.Text + "',Adres='" + txtAdres.Text + "',Email='" + txtEmail.Text + "' where TC='" + txtTc.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Müşteriler"].Clear();
            Kayıt_Goster();
            MessageBox.Show("Kayıt Güncellendi.","ONAY");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Müşteriler where TC='"+dataGridView1.CurrentRow.Cells["TC"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Müşteriler"].Clear();
            Kayıt_Goster();
            MessageBox.Show("Kayıt Silme Başarılı.","ONAY");
        }

        private void txttcara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *from Müşteriler where AdSoyad like '%" + txttcara.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            txtAdsoyad.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
        }
    }
}
