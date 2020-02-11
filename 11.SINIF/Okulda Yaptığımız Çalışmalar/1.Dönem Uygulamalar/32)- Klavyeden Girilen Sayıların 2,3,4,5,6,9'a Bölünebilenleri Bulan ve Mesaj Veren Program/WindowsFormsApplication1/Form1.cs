using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int kac, sayi, bir, on , yüz, onbin, yüzbin, top, bs;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kac = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Kaç Sayı Giriceksiniz?"));

            for (int i = 0; i < kac; i++)
            {
                sayi = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("5 Basamaklı Sayı Giriniz"));
                bir = (((sayi % 10000) % 1000) % 100) % 10;
                on = (((sayi % 10000) % 1000) % 100)/10;
                yüz = ((sayi % 10000) % 1000)/100; 
                onbin = (sayi % 10000)/1000;
                yüzbin = sayi / 10000;
                top = bir + on + yüz + onbin + yüzbin;
                
               if (bir % 2 == 0)
                {
                    MessageBox.Show("Sayı İkiye Bölünebiliyor");
                    bs++;
                }
               
               if (top % 3 == 0)
                {
                    MessageBox.Show("Sayı Üçe Bölünebiliyor");
                    bs++;
                }
               if (yüz % 4 ==0 )
                {
                    MessageBox.Show("Sayı Dörde Bölünebiliyor");
                    bs++;
                }
                if (bir == 0 || bir == 5)
                {
                    MessageBox.Show("Sayı Beşe Bölünebiliyor");
                    bs++;
                }
                if (bir % 2 == 0 && top % 3 == 0)
                {
                    MessageBox.Show("Sayı Altıya Bölünebiliyor");
                    bs++;
                }
                if (top % 9 == 0)
                {
                    MessageBox.Show("Sayı Dokuza Bölünebiliyor");
                    bs++;
                }
            }
            MessageBox.Show(bs + " tane sayı bölündü");
        }
    }
}
