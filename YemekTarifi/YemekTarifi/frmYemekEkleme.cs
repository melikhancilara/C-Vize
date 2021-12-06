using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YemekTarifi
{
    public partial class frmYemekEkleme : Form
    {
        public frmYemekEkleme()
        {
            InitializeComponent();
        }

        Sınıflar.Yemek yemek = new Sınıflar.Yemek();
        
        private void btnYemekEklemeYemekEkle_Click(object sender, EventArgs e)
        {           
            yemek.yemekAdi = yemekeklemeadi.Text ;
            yemekvemalzeme.Items.Add(yemek.yemekAdi);
            MessageBox.Show("Yemek Eklendi");
        }

        private void btnYemekEkleMalzemeEkle_Click(object sender, EventArgs e)
        {
            
            yemek.malzemeAdi = yemekmalzemeeklemeadi.Text;
            string[] malzemeler = new string[] { yemek.malzemeAdi };
            yemek.malzemeListe.AddRange(malzemeler);
            yemekvemalzeme.Items.AddRange(malzemeler);
            
           
            MessageBox.Show("Malzeme Eklendi");

        }

      
    }
}
