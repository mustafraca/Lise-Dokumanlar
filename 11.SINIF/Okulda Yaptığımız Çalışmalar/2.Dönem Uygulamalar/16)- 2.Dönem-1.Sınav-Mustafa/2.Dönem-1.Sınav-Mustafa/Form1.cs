using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2.Dönem_1.Sınav_Mustafa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime zaman = DateTime.Now;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string metin = label2.Text;
            int adet = metin.Length;

            string ilk, sonra;
            ilk = metin.Substring(0, 1);
            sonra = metin.Substring(1, adet - 1);
            label2.Text = sonra + ilk;
        }

        private void tarihToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = zaman.ToLongDateString();
        }

        private void saatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = zaman.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void soru1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double toplam = 0; double ortalama = 0;
            int[] dizi = new int[10];
            for (int i = 0; i < 10; i++)
            {
                dizi[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(i + 1 + ".Sayıyı Giriniz:"));
                toplam += dizi[i];
            }
            ortalama = toplam / 10;
            MessageBox.Show("Toplam Sayı: " + toplam + ", Ortalama: " + ortalama);
        }

        private void soru2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
        }

        private void soru3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 yeni2 = new Form3();
            yeni2.Show();
        }
    }
}
