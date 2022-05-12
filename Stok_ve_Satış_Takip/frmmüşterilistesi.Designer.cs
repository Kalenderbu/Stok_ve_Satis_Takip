
namespace StokTakip
{
    partial class frmmüşterilistesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmüşterilistesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btncikis1 = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdsoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttcara = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.lbltcara = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(317, 89);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 57;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(738, 394);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btncikis1
            // 
            this.btncikis1.BackColor = System.Drawing.Color.Red;
            this.btncikis1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncikis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis1.Location = new System.Drawing.Point(119, 413);
            this.btncikis1.Name = "btncikis1";
            this.btncikis1.Size = new System.Drawing.Size(81, 47);
            this.btncikis1.TabIndex = 23;
            this.btncikis1.Text = "KAPAT";
            this.btncikis1.UseVisualStyleBackColor = false;
            this.btncikis1.Click += new System.EventHandler(this.btncikis1_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.Location = new System.Drawing.Point(23, 327);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(127, 47);
            this.btnguncelle.TabIndex = 22;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 260);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 22);
            this.txtEmail.TabIndex = 21;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(119, 174);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(192, 80);
            this.txtAdres.TabIndex = 20;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(119, 146);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(192, 22);
            this.txtTelefon.TabIndex = 19;
            // 
            // txtAdsoyad
            // 
            this.txtAdsoyad.Location = new System.Drawing.Point(119, 118);
            this.txtAdsoyad.Name = "txtAdsoyad";
            this.txtAdsoyad.Size = new System.Drawing.Size(192, 22);
            this.txtAdsoyad.TabIndex = 18;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(119, 90);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(192, 22);
            this.txtTc.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(57, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(62, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(49, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "TC Kimlik Nu.";
            // 
            // txttcara
            // 
            this.txttcara.Location = new System.Drawing.Point(482, 39);
            this.txttcara.Name = "txttcara";
            this.txttcara.Size = new System.Drawing.Size(190, 22);
            this.txttcara.TabIndex = 24;
            this.txttcara.TextChanged += new System.EventHandler(this.txttcara_TextChanged);
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(170, 327);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(127, 47);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "LİSTEDEN SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lbltcara
            // 
            this.lbltcara.AutoSize = true;
            this.lbltcara.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltcara.Location = new System.Drawing.Point(354, 42);
            this.lbltcara.Name = "lbltcara";
            this.lbltcara.Size = new System.Drawing.Size(112, 17);
            this.lbltcara.TabIndex = 26;
            this.lbltcara.Text = "Müşteri Arama";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Yellow;
            this.label16.Location = new System.Drawing.Point(948, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 16);
            this.label16.TabIndex = 27;
            this.label16.Text = "2020325007";
            // 
            // frmmüşterilistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1067, 495);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbltcara);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txttcara);
            this.Controls.Add(this.btncikis1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdsoyad);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmüşterilistesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.frmmüşterilistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btncikis1;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdsoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttcara;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lbltcara;
        private System.Windows.Forms.Label label16;
    }
}