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
    public partial class frmkullanici : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\StokVerisi.accdb");
        OleDbCommand komut;
        OleDbDataReader read;
        public OleDbDataReader kullanici(TextBox kullaniciadi, TextBox sifre)
        {
            baglanti.Open();
            komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select *from Kullanıcı where Kullanıcıadı='" + kullaniciadi.Text + "'";
            read = komut.ExecuteReader();
            if (read.Read() == true)
            {
                if (sifre.Text == read["Şifre"].ToString())
                {
                    Formsatis Satışlar = new Formsatis();
                    Satışlar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Şifrenizi Kontrol Ediniz.", "HATA!");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınızı ve Şifrenizi Kontrol Ediniz.", "HATA!");
            }
            baglanti.Close();
            return read;
        }
        public frmkullanici()
        {
            InitializeComponent();
        }
        private void btncikisyap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kullanici(txtkullaniciadi,txtsifre);
            txtkullaniciadi.Clear();
            txtsifre.Clear();
        }
    }
}
