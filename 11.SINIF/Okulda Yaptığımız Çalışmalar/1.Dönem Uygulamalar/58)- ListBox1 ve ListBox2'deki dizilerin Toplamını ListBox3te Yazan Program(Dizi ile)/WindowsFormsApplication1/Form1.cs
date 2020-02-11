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
        public Form1()
        {
            InitializeComponent();
        }
        Random sayi = new Random();
        int[] dizi = new int[10];
        int[] dizi2 = new int[10];
        int[] dizitoplam = new int[10];

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                int xsayi = sayi.Next(0, 100);
                dizi[i] = xsayi;
            }
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(dizi[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                int xsayi = sayi.Next(0, 100);
                dizi2[i] = xsayi;
            }
            for (int i = 0; i < 10; i++)
            {
                listBox2.Items.Add(dizi2[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                dizitoplam[i] = dizi[i] + dizi2[i];
            }
            for (int i = 0; i < 10; i++)
            {
                listBox3.Items.Add(dizitoplam[i]);
            }
        }

    }
}
