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
    public partial class frmmarka : Form
    {
        public frmmarka()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\StokVerisi.accdb");
        bool durum;
        private void markakontrol()
        {
            durum = true;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Markalar", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (combokategori.Text==read["Kategori"].ToString() && combomarka.Text == read["Marka"].ToString() || combokategori.Text=="" || combomarka.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            markakontrol();
            if (durum==true)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into Markalar(Kategori,Marka) values('" + combokategori.Text + "','" + combomarka.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Marka Ekleme Başarılı.", "ONAY");
            }
            else
            {
                MessageBox.Show("Girdiğiniz Kategori veya Marka Zaten Var.","HATA! ");
            }
            
            combomarka.Text = "";
            combokategori.Text = "";
            
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

        private void frmmarka_Load(object sender, EventArgs e)
        {
            kategorigetir();
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

        private void combomarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Markalar where Marka='" + combomarka.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Silme Başarılı.", "ONAY");
            combomarka.Text = "";
            combokategori.Text = "";
        }
    }
}
