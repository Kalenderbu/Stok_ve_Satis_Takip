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
namespace StokTakip
{
    public partial class frmkategori : Form
    {
        public frmkategori()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\StokVerisi.accdb");

        bool durum;
        private void kategorikontrol()
        {
            durum = true;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Kategoriler",baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (comboBox1.Text==read["Kategori"].ToString()|| comboBox1.Text=="")
                {
                    durum = false;
                }
            }
            baglanti.Close();
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
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmkategori_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            kategorikontrol();
            if (durum==true)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into Kategoriler(Kategori) values('" + comboBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                
                MessageBox.Show("Kategori Ekleme Başarılı.","ONAY");
                
            }
            else
            {
                MessageBox.Show("Girdiğiniz Kategori Zaten Var","HATA! ");
            }
            comboBox1.Text = "";
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Kategoriler where Kategori='" + comboBox1.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Silme Başarılı.", "ONAY");
            comboBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
