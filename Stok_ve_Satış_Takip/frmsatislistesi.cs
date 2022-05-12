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
    public partial class frmsatislistesi : Form
    {
        public frmsatislistesi()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\StokVerisi.accdb");
        DataSet daset = new DataSet();
        private void satislistele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select *from Satışlar", baglanti);
            adtr.Fill(daset, "Satışlar");
            dataGridView1.DataSource = daset.Tables["Satışlar"];
            baglanti.Close();
        }

        private void frmsatislistesi_Load(object sender, EventArgs e)
        {
            satislistele();
        }

        private void btncikis1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
