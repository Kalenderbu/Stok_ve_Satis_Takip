
namespace StokTakip
{
    partial class frmmarka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmarka));
            this.combokategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.combomarka = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combokategori
            // 
            this.combokategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combokategori.FormattingEnabled = true;
            this.combokategori.Location = new System.Drawing.Point(115, 38);
            this.combokategori.Name = "combokategori";
            this.combokategori.Size = new System.Drawing.Size(154, 24);
            this.combokategori.TabIndex = 0;
            this.combokategori.SelectedIndexChanged += new System.EventHandler(this.combokategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(53, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(232, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "KAPAT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(211, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 16);
            this.label16.TabIndex = 6;
            this.label16.Text = "2020325007";
            // 
            // combomarka
            // 
            this.combomarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combomarka.FormattingEnabled = true;
            this.combomarka.Location = new System.Drawing.Point(115, 80);
            this.combomarka.Name = "combomarka";
            this.combomarka.Size = new System.Drawing.Size(154, 24);
            this.combomarka.TabIndex = 7;
            this.combomarka.SelectedIndexChanged += new System.EventHandler(this.combomarka_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(122, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 38);
            this.button3.TabIndex = 8;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmmarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(330, 199);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.combomarka);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combokategori);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmarka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marka Ekranı";
            this.Load += new System.EventHandler(this.frmmarka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combokategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox combomarka;
        private System.Windows.Forms.Button button3;
    }
}