
namespace StokTakip
{
    partial class frmkullanici
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncikisyap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtsifre);
            this.groupBox1.Controls.Add(this.txtkullaniciadi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::StokTakip.Properties.Resources.giris;
            this.pictureBox1.Location = new System.Drawing.Point(88, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(137, 206);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(189, 22);
            this.txtsifre.TabIndex = 3;
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(137, 153);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(189, 22);
            this.txtkullaniciadi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // btncikisyap
            // 
            this.btncikisyap.BackColor = System.Drawing.Color.Red;
            this.btncikisyap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncikisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikisyap.Location = new System.Drawing.Point(255, 286);
            this.btncikisyap.Name = "btncikisyap";
            this.btncikisyap.Size = new System.Drawing.Size(114, 49);
            this.btncikisyap.TabIndex = 18;
            this.btncikisyap.Text = "ÇIKIŞ";
            this.btncikisyap.UseVisualStyleBackColor = false;
            this.btncikisyap.Click += new System.EventHandler(this.btncikisyap_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 49);
            this.button1.TabIndex = 19;
            this.button1.Text = "GİRİŞ YAP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Enter += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(281, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "2020325007";
            // 
            // frmkullanici
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 351);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncikisyap);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmkullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş Ekranı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncikisyap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label16;
    }
}