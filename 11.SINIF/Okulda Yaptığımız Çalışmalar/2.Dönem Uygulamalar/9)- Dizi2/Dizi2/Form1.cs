using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dizi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random sayi = new Random();
        int[] dizi = new int[20];
        int cıfts = 0; int teks = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            cıfts = 0; teks = 0;

            for (int i = 0; i < 20; i++)
            {
                dizi[i] = sayi.Next(1, 100);
                listBox1.Items.Add(dizi[i]);
                if (dizi[i] % 2 == 0)
                {
                    cıfts++;
                }
                else
                {
                    teks++;
                }
            }
            MessageBox.Show("Tek Sayı: " + teks + " Çift Sayı: " + cıfts);
        }
    }
}
