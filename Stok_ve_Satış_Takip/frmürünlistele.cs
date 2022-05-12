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
    public partial class frmürünlistele : Form
    {
        public frmürünlistele()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\StokVerisi.accdb");
        DataSet daset = new DataSet();
        private void btncikis1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void kategorigetir()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Kategoriler", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["Kategori"].ToString());
            }
            baglanti.Close();
        }
        private void frmürünlistele_Load(object sender, EventArgs e)
        {
            urunlistele();
            kategorigetir();
        }

        private void urunlistele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *from Ürünler", baglanti);
            adtr.Fill(daset, "Ürünler");
            dataGridView1.DataSource = daset.Tables["Ürünler"];
            baglanti.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            barkodnotxt.Text = dataGridView1.CurrentRow.Cells["BarkodNumarası"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["Kategori"].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
            urunaditxt.Text = dataGridView1.CurrentRow.Cells["ÜrünAdı"].Value.ToString();
            txtmiktar.Text = dataGridView1.CurrentRow.Cells["Adet"].Value.ToString();
            txtalisfiyati.Text = dataGridView1.CurrentRow.Cells["AlışFiyatı"].Value.ToString();
            txtsatisfiyati.Text = dataGridView1.CurrentRow.Cells["SatışFiyatı"].Value.ToString();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Ürünler set BarkodNumarası='"+ barkodnotxt.Text +"',Kategori='"+comboBox1.Text+ "',Marka='" + comboBox2.Text + "',ÜrünAdı='" + urunaditxt.Text + "',Adet='" + txtmiktar.Text + "',AlışFiyatı='" + txtalisfiyati.Text + "',SatışFiyatı='" + txtsatisfiyati.Text + "' where BarkodNumarası='" + barkodnotxt.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Ürünler"].Clear();
            urunlistele();
            MessageBox.Show("Güncelleme Başarılı.","ONAY");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Markalar where Kategori='" + comboBox1.SelectedItem + "'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox2.Items.Add(read["Marka"].ToString());
            }
            baglanti.Close();
        }

        private void txturunara_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *from Ürünler where BarkodNumarası like '%" + txturunara.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Ürünler where BarkodNumarası='" + dataGridView1.CurrentRow.Cells["BarkodNumarası"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Ürünler"].Clear();
            urunlistele();
            MessageBox.Show("Ürün Silme Başarılı.","ONAY");
        }
    }
}
