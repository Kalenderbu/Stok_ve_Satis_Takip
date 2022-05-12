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
    public partial class frmMüşteriEkle : Form
    {
        public frmMüşteriEkle()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\StokVerisi.accdb");
        private void label3_Click(object sender, EventArgs e)
        {

        }
        bool durum;
        private void tckontrol()
        {
            durum = true;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Müşteriler", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtTc.Text == read["TC"].ToString() || txtTc.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void btncikis1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMüşteriEkle_Load(object sender, EventArgs e)
        {
            
        }

        private void btnekle1_Click(object sender, EventArgs e)
        {
            tckontrol();
            if (durum == true)
            {
                baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Müşteriler(TC,AdSoyad,Telefon,Adres,Email) values(@TC,@AdSoyad,@Telefon,@Adres,@Email)", baglanti);
            komut.Parameters.AddWithValue("@TC", txtTc.Text);
            komut.Parameters.AddWithValue("@AdSoyad", txtAdsoyad.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@Email", txtEmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı.","ONAY");
        }
            else
            {
                MessageBox.Show("Girdiğiniz TC Kimlik Numarası Zaten Var.", "HATA!");
            }
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
