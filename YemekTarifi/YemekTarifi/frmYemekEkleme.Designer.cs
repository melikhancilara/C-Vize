
namespace YemekTarifi
{
    partial class frmYemekEkleme
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
            this.btnYemekEklemeYemekEkle = new System.Windows.Forms.Button();
            this.lblYemekEklemeYemekAdi = new System.Windows.Forms.Label();
            this.lblYemekEklemeMalzemeler = new System.Windows.Forms.Label();
            this.yemekmalzemeeklemeadi = new System.Windows.Forms.TextBox();
            this.btnYemekEkleMalzemeEkle = new System.Windows.Forms.Button();
            this.yemekeklemeadi = new System.Windows.Forms.TextBox();
            this.yemekvemalzeme = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnYemekEklemeYemekEkle
            // 
            this.btnYemekEklemeYemekEkle.Location = new System.Drawing.Point(510, 35);
            this.btnYemekEklemeYemekEkle.Name = "btnYemekEklemeYemekEkle";
            this.btnYemekEklemeYemekEkle.Size = new System.Drawing.Size(124, 23);
            this.btnYemekEklemeYemekEkle.TabIndex = 5;
            this.btnYemekEklemeYemekEkle.Text = "Yemeği Ekle";
            this.btnYemekEklemeYemekEkle.UseVisualStyleBackColor = true;
            this.btnYemekEklemeYemekEkle.Click += new System.EventHandler(this.btnYemekEklemeYemekEkle_Click);
            // 
            // lblYemekEklemeYemekAdi
            // 
            this.lblYemekEklemeYemekAdi.AutoSize = true;
            this.lblYemekEklemeYemekAdi.Location = new System.Drawing.Point(40, 39);
            this.lblYemekEklemeYemekAdi.Name = "lblYemekEklemeYemekAdi";
            this.lblYemekEklemeYemekAdi.Size = new System.Drawing.Size(63, 15);
            this.lblYemekEklemeYemekAdi.TabIndex = 6;
            this.lblYemekEklemeYemekAdi.Text = "Yemek Adı\r\n";
            // 
            // lblYemekEklemeMalzemeler
            // 
            this.lblYemekEklemeMalzemeler.AutoSize = true;
            this.lblYemekEklemeMalzemeler.Location = new System.Drawing.Point(40, 90);
            this.lblYemekEklemeMalzemeler.Name = "lblYemekEklemeMalzemeler";
            this.lblYemekEklemeMalzemeler.Size = new System.Drawing.Size(68, 15);
            this.lblYemekEklemeMalzemeler.TabIndex = 7;
            this.lblYemekEklemeMalzemeler.Text = "Malzemeler";
            // 
            // yemekmalzemeeklemeadi
            // 
            this.yemekmalzemeeklemeadi.Location = new System.Drawing.Point(108, 87);
            this.yemekmalzemeeklemeadi.Name = "yemekmalzemeeklemeadi";
            this.yemekmalzemeeklemeadi.Size = new System.Drawing.Size(526, 23);
            this.yemekmalzemeeklemeadi.TabIndex = 8;
            // 
            // btnYemekEkleMalzemeEkle
            // 
            this.btnYemekEkleMalzemeEkle.Location = new System.Drawing.Point(309, 116);
            this.btnYemekEkleMalzemeEkle.Name = "btnYemekEkleMalzemeEkle";
            this.btnYemekEkleMalzemeEkle.Size = new System.Drawing.Size(124, 23);
            this.btnYemekEkleMalzemeEkle.TabIndex = 9;
            this.btnYemekEkleMalzemeEkle.Text = "Malzemeyi Ekle";
            this.btnYemekEkleMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnYemekEkleMalzemeEkle.Click += new System.EventHandler(this.btnYemekEkleMalzemeEkle_Click);
            // 
            // yemekeklemeadi
            // 
            this.yemekeklemeadi.Location = new System.Drawing.Point(109, 36);
            this.yemekeklemeadi.Name = "yemekeklemeadi";
            this.yemekeklemeadi.Size = new System.Drawing.Size(379, 23);
            this.yemekeklemeadi.TabIndex = 11;
            // 
            // yemekvemalzeme
            // 
            this.yemekvemalzeme.FormattingEnabled = true;
            this.yemekvemalzeme.ItemHeight = 15;
            this.yemekvemalzeme.Location = new System.Drawing.Point(40, 172);
            this.yemekvemalzeme.Name = "yemekvemalzeme";
            this.yemekvemalzeme.Size = new System.Drawing.Size(673, 169);
            this.yemekvemalzeme.TabIndex = 12;
            // 
            // frmYemekEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(755, 374);
            this.Controls.Add(this.yemekvemalzeme);
            this.Controls.Add(this.yemekeklemeadi);
            this.Controls.Add(this.btnYemekEkleMalzemeEkle);
            this.Controls.Add(this.yemekmalzemeeklemeadi);
            this.Controls.Add(this.lblYemekEklemeMalzemeler);
            this.Controls.Add(this.lblYemekEklemeYemekAdi);
            this.Controls.Add(this.btnYemekEklemeYemekEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmYemekEkleme";
            this.Text = "Yemek Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnYemekEklemeYemekEkle;
        private System.Windows.Forms.Label lblYemekEklemeYemekAdi;
        private System.Windows.Forms.Label lblYemekEklemeMalzemeler;
        private System.Windows.Forms.TextBox yemekmalzemeeklemeadi;
        private System.Windows.Forms.Button btnYemekEkleMalzemeEkle;
        private System.Windows.Forms.TextBox yemekeklemeadi;
        private System.Windows.Forms.ListBox yemekvemalzeme;
    }
}