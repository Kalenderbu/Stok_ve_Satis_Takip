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
    public partial class frmürünekle : Form
    {
        public frmürünekle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\StokVerisi.accdb");
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Ürünler", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtbarkodno.Text==read["BarkodNumarası"].ToString() || txtbarkodno.Text=="")
                { 
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void kategorigetir()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Kategoriler", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combokategori.Items.Add(read["Kategori"].ToString());
            }
            baglanti.Close();
        }
        private void frmürünekle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void combokategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            combomarka.Items.Clear();
            combomarka.Text = "";
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Markalar where Kategori='" + combokategori.SelectedItem + "'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combomarka.Items.Add(read["Marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnyeniekle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into Ürünler(BarkodNumarası,Kategori,Marka,ÜrünAdı,Adet,AlışFiyatı,SatışFiyatı,Tarih) values(@BarkodNumarası,@Kategori,@Marka,@ÜrünAdı,@Adet,@AlışFiyatı,@SatışFiyatı,@Tarih)", baglanti);
                komut.Parameters.AddWithValue("@BarkodNumarası", txtbarkodno.Text);
                komut.Parameters.AddWithValue("@Kategori", combokategori.Text);
                komut.Parameters.AddWithValue("@Marka", combomarka.Text);
                komut.Parameters.AddWithValue("@ÜrünAdı", txturunadi.Text);
                komut.Parameters.AddWithValue("@Adet", int.Parse(txtmiktari.Text));
                komut.Parameters.AddWithValue("@AlışFiyatı", txtalisfiyati.Text);
                komut.Parameters.AddWithValue("@SatışFiyatı", txtsatisfiyati.Text);
                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Ekleme Başarılı","ONAY");
            }
            else
            {
                MessageBox.Show("Girdiğiniz Barkod Numarası Zaten Var.","HATA!");
            }
            
            combomarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void kategoritxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void barkodnotxt_TextChanged(object sender, EventArgs e)
        {
            if (barkodnotxt.Text=="")
            {
                txtmiktar.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Ürünler where BarkodNumarası like '" + barkodnotxt.Text + "'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                kategoritxt.Text = read["Kategori"].ToString();
                markatxt.Text = read["Marka"].ToString();
                urunaditxt.Text = read["ÜrünAdı"].ToString();
                txtmiktar.Text = read["Adet"].ToString();
                           }
            baglanti.Close();
        }

        private void btnvarolanaekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Ürünler set Adet=Adet+'" + int.Parse(miktaritxt.Text) + "' where BarkodNumarası='" + barkodnotxt.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Ürün Miktarı Güncellendi","ONAY");
        }

        private void barkodnotxt_TextChanged_1(object sender, EventArgs e)
        {
            if (barkodnotxt.Text == "")
            {
                txtmiktar.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Ürünler where BarkodNumarası like '" + barkodnotxt.Text + "'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                kategoritxt.Text = read["Kategori"].ToString();
                markatxt.Text = read["Marka"].ToString();
                urunaditxt.Text = read["ÜrünAdı"].ToString();
                txtmiktar.Text = read["Adet"].ToString();
            }
            baglanti.Close();
        }

        private void btnvarolanaekle_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update Ürünler set Adet=Adet+'" + int.Parse(miktaritxt.Text) + "' where BarkodNumarası='" + barkodnotxt.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Ürün Miktarı Güncellendi","ONAY");
        }
    }
}
    

