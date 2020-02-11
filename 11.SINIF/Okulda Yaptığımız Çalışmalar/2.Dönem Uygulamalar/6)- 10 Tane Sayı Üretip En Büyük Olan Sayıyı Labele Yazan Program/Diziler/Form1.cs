using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rasgele = new Random();
        int buyuk = 0;
        int[] sayi = new int[10];
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                sayi[i] = rasgele.Next(1, 100);
                listBox1.Items.Add(sayi[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (sayi[i] > buyuk)
                {
                    buyuk = sayi[i];
                }
            }
            label2.Text = buyuk.ToString();
        }
    }
}
