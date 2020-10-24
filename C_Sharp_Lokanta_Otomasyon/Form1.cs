using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Lokanta_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int toplam = 0, kasa=0;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //Çorba Kontrol
            if (cmbCorba.SelectedIndex!=-1)
            {
                if (cmbCorba.Text == "İşkembe" || cmbCorba.Text == "Paça")
                {
                    toplam += 8;
                }
                else
                {
                    toplam += 5;
                }
            }

            //Kebap Kontrol
            if (cmbYemek.SelectedIndex!=-1)
            {
                if (cmbYemek.Text == "Tas Kebabı" || cmbYemek.Text == "Orman Kebabı" || cmbYemek.Text == "Cağ Kebabı")
                {
                    toplam += 20;
                }
                else
                {
                    toplam += 15;
                }
            }

            //Köfte Kontrol

            if (cmbKofte.SelectedIndex!=-1)
            {
                toplam += 18;
            }

            //Pide Kontrol

            if (cmbPide.SelectedIndex != -1)
            {
                if (cmbPide.Text=="Karadeniz")
                {
                    toplam += 10;
                }
                else
                {
                    toplam += 8;
                }
            }

            //İçecek Kontrol

            if (cmbIcecek.SelectedIndex!=-1)
            {
                if (cmbIcecek.Text=="Su")
                {
                    toplam += 2;
                }
                else if(cmbIcecek.Text=="Çay")
                {
                    toplam += 3;
                }
                else
                {
                    toplam += 4;
                }
            }

            //Salata Kontrol

            if (cmbSalata.SelectedIndex != -1)
            {
                toplam += 5;
            }

            //Tatlı Kontrol

            if (cmbTatli.SelectedIndex != -1)
            {
                toplam += 12;
            }

            labelToplam.Text = "Toplam : " + toplam + " TL";
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnÖde_Click(object sender, EventArgs e)
        {
            kasa = kasa + toplam;

            lblKasa.Text = "Toplam Kasa : " + kasa+" TL";

            temizle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temizle();
        }

        public void temizle()
        {
            toplam = 0;

            cmbCorba.Text = "";
            cmbIcecek.Text = "";
            cmbKofte.Text = "";
            cmbPide.Text = "";
            cmbSalata.Text = "";
            cmbTatli.Text = "";
            cmbYemek.Text = "";

            labelToplam.Text = "Toplam : " + toplam + " TL";
        }
    }
}
