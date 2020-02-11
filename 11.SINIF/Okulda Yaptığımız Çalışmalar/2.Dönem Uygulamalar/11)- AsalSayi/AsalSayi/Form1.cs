using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AsalSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] dizi = new int[50];
        Random sayi = new Random();
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                dizi[i] = sayi.Next(1, 100);
                listBox1.Items.Add(dizi[i]);
                if (dizi[i] % dizi[i] == 0 && dizi[i] % 2 != 0 && dizi[i] % 3 != 0 && dizi[i] % 4 != 0 && dizi[i] % 5 != 0)
                {
                    sayac++;
                }
            }
            int[] asal = new int[sayac];
            int k = 0;
            for (int i = 0; i < 50; i++)
            {
                if (dizi[i] % dizi[i] == 0 && dizi[i] % 2 != 0 && dizi[i] % 3 != 0 && dizi[i] % 4 != 0 && dizi[i] % 5 != 0)
                {
                    asal[k] = dizi[i];
                    listBox2.Items.Add(asal[k]);
                    k++;

                }
            }
        }
    }
}
