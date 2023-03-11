using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagitMakasOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random random = new Random();
        int oyuncuSkor = 0;
        int bilgisayarSkor = 0;
        TkmSecimleri oyuncuSecimi;

        enum TkmSecimleri
        {
            Tas,
            Kagit,
            Makas
        }


        private void OyuncuSecimiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secim = OyuncuSecimiComboBox.SelectedItem.ToString();
            switch (secim)
            {
                case "Taş":
                    oyuncuSecimi = TkmSecimleri.Tas;
                    break;
                case "Kağıt":
                    oyuncuSecimi = TkmSecimleri.Kagit;
                    break;
                case "Makas":
                    oyuncuSecimi = TkmSecimleri.Makas;
                    break;
                default:
                    oyuncuSecimi = TkmSecimleri.Tas;
                    break;
            }
        }

        private TkmSecimleri BilgisayarSecimi()
        {
            TkmSecimleri[] secimler = { TkmSecimleri.Tas, TkmSecimleri.Kagit, TkmSecimleri.Makas };
            int index = random.Next(secimler.Length);
            return secimler[index];
        }

        private void OynaButton_Click(object sender, EventArgs e)
        {
            TkmSecimleri bilgisayarSecimi = BilgisayarSecimi();

            string oyuncuSecimiMetni = oyuncuSecimi.ToString();
            string bilgisayarSecimiMetni = bilgisayarSecimi.ToString();

            OyuncuSecimiLabel.Text = "Oyuncunun Seçimi: " + oyuncuSecimiMetni;
            BilgisayarSecimiLabel.Text = "Bilgisayarın Seçimi: " + bilgisayarSecimiMetni;

            if (oyuncuSecimi == bilgisayarSecimi)
            {
                SonucLabel.Text = "Berabere!";
            }
            else if ((oyuncuSecimi == TkmSecimleri.Tas && bilgisayarSecimi == TkmSecimleri.Makas) ||
                (oyuncuSecimi == TkmSecimleri.Kagit && bilgisayarSecimi == TkmSecimleri.Tas) ||
                (oyuncuSecimi == TkmSecimleri.Makas && bilgisayarSecimi == TkmSecimleri.Kagit))
            {
                oyuncuSkor++;
                OyuncuSkorLabel.Text = "Oyuncu: " + oyuncuSkor.ToString();
                SonucLabel.Text = "Oyuncu kazandı!";
            }
            else
            {
                bilgisayarSkor++;
                BilgisayarSkorLabel.Text = "Bilgisayar: " + bilgisayarSkor.ToString();
                SonucLabel.Text = "Bilgisayar kazandı!";
            }
        }

        private void YenidenBaslatButton_Click(object sender, EventArgs e)
        {
            oyuncuSkor = 0;
            bilgisayarSkor = 0;
            OyuncuSkorLabel.Text = "Oyuncu: 0";
            BilgisayarSkorLabel.Text = "Bilgisayar: 0";
            OyuncuSecimiLabel.Text = "Oyuncunun Seçimi: ";
            BilgisayarSecimiLabel.Text = "Bilgisayarın Seçimi: ";
            SonucLabel.Text = "";
            OyuncuSecimiComboBox.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OyuncuSecimiComboBox.SelectedIndex = 0;
        }
    }
}