
namespace StokTakip
{
    partial class frmürünlistele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmürünlistele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.barkodnotxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.urunaditxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.btncikis1 = new System.Windows.Forms.Button();
            this.txturunara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsatisfiyati = new System.Windows.Forms.TextBox();
            this.txtalisfiyati = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(324, 75);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 57;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(772, 366);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(36, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 17);
            this.label15.TabIndex = 51;
            this.label15.Text = "Mevcut Miktar";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Location = new System.Drawing.Point(190, 375);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(116, 40);
            this.btnguncelle.TabIndex = 39;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // barkodnotxt
            // 
            this.barkodnotxt.Location = new System.Drawing.Point(160, 77);
            this.barkodnotxt.Name = "barkodnotxt";
            this.barkodnotxt.ReadOnly = true;
            this.barkodnotxt.Size = new System.Drawing.Size(146, 22);
            this.barkodnotxt.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(12, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 17);
            this.label14.TabIndex = 46;
            this.label14.Text = "Barkod Numarası";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(66, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 50;
            this.label10.Text = "Alış Fiyatı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(73, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 49;
            this.label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(92, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 48;
            this.label12.Text = "Marka";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(75, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 47;
            this.label13.Text = "Kategori";
            // 
            // txtmiktar
            // 
            this.txtmiktar.Location = new System.Drawing.Point(160, 249);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(146, 22);
            this.txtmiktar.TabIndex = 43;
            // 
            // urunaditxt
            // 
            this.urunaditxt.Location = new System.Drawing.Point(160, 207);
            this.urunaditxt.Name = "urunaditxt";
            this.urunaditxt.Size = new System.Drawing.Size(146, 22);
            this.urunaditxt.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Satış Fiyatı";
            // 
            // btnsil
            // 
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(51, 375);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(116, 40);
            this.btnsil.TabIndex = 54;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btncikis1
            // 
            this.btncikis1.BackColor = System.Drawing.Color.Red;
            this.btncikis1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncikis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis1.Location = new System.Drawing.Point(137, 432);
            this.btncikis1.Name = "btncikis1";
            this.btncikis1.Size = new System.Drawing.Size(86, 47);
            this.btncikis1.TabIndex = 55;
            this.btncikis1.Text = "KAPAT";
            this.btncikis1.UseVisualStyleBackColor = false;
            this.btncikis1.Click += new System.EventHandler(this.btncikis1_Click);
            // 
            // txturunara
            // 
            this.txturunara.Location = new System.Drawing.Point(685, 29);
            this.txturunara.Name = "txturunara";
            this.txturunara.Size = new System.Drawing.Size(193, 22);
            this.txturunara.TabIndex = 56;
            this.txturunara.TextChanged += new System.EventHandler(this.txturunara_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(481, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Barkod Numarasını Ara";
            // 
            // txtsatisfiyati
            // 
            this.txtsatisfiyati.Location = new System.Drawing.Point(160, 333);
            this.txtsatisfiyati.Name = "txtsatisfiyati";
            this.txtsatisfiyati.Size = new System.Drawing.Size(145, 22);
            this.txtsatisfiyati.TabIndex = 59;
            // 
            // txtalisfiyati
            // 
            this.txtalisfiyati.Location = new System.Drawing.Point(160, 291);
            this.txtalisfiyati.Name = "txtalisfiyati";
            this.txtalisfiyati.Size = new System.Drawing.Size(145, 22);
            this.txtalisfiyati.TabIndex = 58;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 24);
            this.comboBox1.TabIndex = 60;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(160, 163);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 24);
            this.comboBox2.TabIndex = 61;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(1009, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 16);
            this.label16.TabIndex = 62;
            this.label16.Text = "2020325007";
            // 
            // frmürünlistele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1117, 497);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtsatisfiyati);
            this.Controls.Add(this.txtalisfiyati);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txturunara);
            this.Controls.Add(this.btncikis1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.barkodnotxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtmiktar);
            this.Controls.Add(this.urunaditxt);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmürünlistele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listesi Ekranı";
            this.Load += new System.EventHandler(this.frmürünlistele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox barkodnotxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.TextBox urunaditxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btncikis1;
        private System.Windows.Forms.TextBox txturunara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsatisfiyati;
        private System.Windows.Forms.TextBox txtalisfiyati;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label16;
    }
}