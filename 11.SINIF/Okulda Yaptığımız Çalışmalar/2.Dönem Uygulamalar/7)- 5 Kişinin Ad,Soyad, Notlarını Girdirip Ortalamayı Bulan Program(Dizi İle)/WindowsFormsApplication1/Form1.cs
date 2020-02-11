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
        string[] ad = new string[5];
        string[] soyad = new string[5];
        int[] not1 = new int[5];
        int[] not2 = new int[5];
        int[] not3 = new int[5];
        double[] ort = new double[5];
        int i = 0;
        string ad2; string soyad2;
        private void button1_Click(object sender, EventArgs e)
        {
            ad[i] = textBox1.Text;
            soyad[i] = textBox2.Text;
            not1[i] = Convert.ToInt32(textBox3.Text);
            not2[i] = Convert.ToInt32(textBox4.Text);
            not3[i] = Convert.ToInt32(textBox5.Text);
            ort[i] = (not1[i] + not2[i] + not3[i]) / 3;
            i++;
            if (i == 5)
            {
                button2.Enabled = true;
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int buyuk = 0; 
            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add(ad[i]+ " " + soyad[i] + ", 1.Not: " + not1[i] + ", 2.Not: " + not2[i] + ", 3.Not: " + not3[i] + ", Ortalama:" + ort[i]);
                if (ort[i] > buyuk)
                {
                    buyuk = Convert.ToInt32(ort[i]);
                    ad2 = ad[i];
                    soyad2 = soyad[i];
                }
            }
            MessageBox.Show(ad2 + " " +soyad2 + "  En Büyük Ortalama: " + buyuk);
        }
    }
}
