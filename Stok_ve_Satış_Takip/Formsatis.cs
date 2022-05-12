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
    public partial class Formsatis : Form
    {
        public Formsatis()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\StokVerisi.accdb");
        DataSet daset = new DataSet();

        private void sepetlistesi()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *from Sepet",baglanti);
            adtr.Fill(daset,"Sepet");
            dataGridView1.DataSource = daset.Tables["Sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnmusteriislem_Click(object sender, EventArgs e)
        {
            frmMüşteriEkle ekle = new frmMüşteriEkle();
            ekle.ShowDialog();
        }

        private void Formsatis_Load(object sender, EventArgs e)
        {
            sepetlistesi();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select sum(ToplamFiyat) from Sepet", baglanti);
                lblgeneltoplam.Text = komut.ExecuteScalar() + " TL";
                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
        }
        private void btncikisyap_Click(object sender, EventArgs e)
        {
            DialogResult onayla = MessageBox.Show("Programdan Çıkmak İstediğinize Emin misiniz?","UYARI!",MessageBoxButtons.YesNo);
            if (onayla==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnmusteriliste_Click(object sender, EventArgs e)
        {
            frmmüşterilistesi listele = new frmmüşterilistesi();
            listele.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            frmürünekle ekle = new frmürünekle();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmkategori Kategori = new frmkategori();
            Kategori.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmmarka Marka = new frmmarka();
            Marka.ShowDialog();
        }

        private void btnurunliste_Click(object sender, EventArgs e)
        {
            frmürünlistele listele = new frmürünlistele();
            listele.ShowDialog();
        }

        private void txtadsoyad_TextChanged(object sender, EventArgs e)
        {
            if (txtadsoyad.Text=="")
            {
                txttc.Text = "";
                txttelefon.Text = "";
            }
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Müşteriler where AdSoyad like '"+txtadsoyad.Text+"'",baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txttc.Text = read["TC"].ToString();
                txttelefon.Text = read["Telefon"].ToString();
            }
            baglanti.Close();
        }

        private void txtbarkodno_TextChanged(object sender, EventArgs e)
        {
            yenile();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Ürünler where BarkodNumarası like '" + txtbarkodno.Text + "'", baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txturunadi.Text = read["ÜrünAdı"].ToString();
                txtsatisfiyat.Text = read["SatışFiyatı"].ToString();
                if (txtbarkodno.Text == "")
                {
                    foreach (Control item in groupBox2.Controls)
                    {
                        if (item is Label)
                        {
                            if (item != txtstok)
                            {
                                item.Text = "";
                            }
                        }
                    }
                }
                txtstok.Text = read["Adet"].ToString();

            }
            baglanti.Close();
        }

        private void yenile()
        {
            if (txtbarkodno.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtstokadet)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Sepet",baglanti);
            OleDbDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtbarkodno.Text==read["BarkodNumarası"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (txtstok.Text=="0"||int.Parse(txtstokadet.Text)> int.Parse(txtstok.Text))
            {
                MessageBox.Show("Ürün Stoklarını kontrol ediniz!","UYARI");
            }
            else
            {
            barkodkontrol();
            if (durum==true)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into Sepet(TC,AdSoyad,Telefon,BarkodNumarası,ÜrünAdı,Adet,SatışFiyatı,ToplamFiyat,Tarih) values(@TC,@AdSoyad,@Telefon,@BarkodNumarası,@ÜrünAdı,@Adet,@SatışFiyatı,@ToplamFiyat,@Tarih)", baglanti);
                komut.Parameters.AddWithValue("@TC", txttc.Text);
                komut.Parameters.AddWithValue("@AdSoyad", txtadsoyad.Text);
                komut.Parameters.AddWithValue("@Telefon", txttelefon.Text);
                komut.Parameters.AddWithValue("@BarkodNumarası", txtbarkodno.Text);
                komut.Parameters.AddWithValue("@ÜrünAdı", txturunadi.Text);
                komut.Parameters.AddWithValue("@Adet", int.Parse(txtstokadet.Text));
                komut.Parameters.AddWithValue("@SatışFiyatı", double.Parse(txtsatisfiyat.Text));
                komut.Parameters.AddWithValue("@ToplamFiyat", double.Parse(txttoplamfiyat.Text));
                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                OleDbCommand komut1 = new OleDbCommand("update Sepet set Adet=Adet+'"+int.Parse(txtstokadet.Text)+ "' where BarkodNumarası='" + txtbarkodno.Text + "'", baglanti);
                komut1.ExecuteNonQuery();
                OleDbCommand komut2 = new OleDbCommand("update Sepet set ToplamFiyat=Adet*SatışFiyatı where BarkodNumarası='"+txtbarkodno.Text+"'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            txtstokadet.Text = "1";
            daset.Tables["Sepet"].Clear();
            sepetlistesi();
            hesapla();
            txtbarkodno.Clear();
            }
        }

        private void txtstokadet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplamfiyat.Text = (double.Parse(txtstokadet.Text) * double.Parse(txtsatisfiyat.Text)).ToString();
            }
            catch (Exception)
            {
               ;
            }
        }

        private void txtsatisfiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplamfiyat.Text = (double.Parse(txtstokadet.Text) * double.Parse(txtsatisfiyat.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Sepet where BarkodNumarası='"+dataGridView1.CurrentRow.Cells["BarkodNumarası"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Silme Başarılı.","ONAY");
            daset.Tables["Sepet"].Clear();
            sepetlistesi();
            hesapla();
        }

        private void btnsatisiptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from Sepet ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
            MessageBox.Show("Satış İptali Başarılı.","ONAY");
            daset.Tables["Sepet"].Clear();
            sepetlistesi();
            hesapla();
        }

        private void btnsatisliste_Click(object sender, EventArgs e)
        {
            frmsatislistesi listele = new frmsatislistesi();
            listele.ShowDialog();
        }
        

        private void btnsatisyap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("insert into Satışlar(TC,AdSoyad,Telefon,BarkodNumarası,ÜrünAdı,Adet,SatışFiyatı,ToplamFiyat,Tarih) values(@TC,@AdSoyad,@Telefon,@BarkodNumarası,@ÜrünAdı,@Adet,@SatışFiyatı,@ToplamFiyat,@Tarih)", baglanti);
                komut.Parameters.AddWithValue("@TC", txttc.Text);
                komut.Parameters.AddWithValue("@AdSoyad", txtadsoyad.Text);
                komut.Parameters.AddWithValue("@Telefon", txttelefon.Text);
                komut.Parameters.AddWithValue("@BarkodNumarası", dataGridView1.Rows[i].Cells["BarkodNumarası"].Value.ToString());
                komut.Parameters.AddWithValue("@ÜrünAdı", dataGridView1.Rows[i].Cells["ÜrünAdı"].Value.ToString());
                komut.Parameters.AddWithValue("@Adet", int.Parse(dataGridView1.Rows[i].Cells["Adet"].Value.ToString()));
                komut.Parameters.AddWithValue("@SatışFiyatı", double.Parse(dataGridView1.Rows[i].Cells["SatışFiyatı"].Value.ToString()));
                komut.Parameters.AddWithValue("@ToplamFiyat", double.Parse(dataGridView1.Rows[i].Cells["ToplamFiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                OleDbCommand komut1 = new OleDbCommand("update Ürünler set Adet=Adet-'" + int.Parse(dataGridView1.Rows[i].Cells["Adet"].Value.ToString()) + "' where BarkodNumarası='" + dataGridView1.Rows[i].Cells["BarkodNumarası"].Value.ToString() + "'", baglanti);
                komut1.ExecuteNonQuery();
                baglanti.Close();
                
                
                
            }
            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("delete from Sepet ", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Sepet"].Clear();
            sepetlistesi();
            hesapla();
            MessageBox.Show("Satış Yapıldı.","ONAY");
        }
    }
}
