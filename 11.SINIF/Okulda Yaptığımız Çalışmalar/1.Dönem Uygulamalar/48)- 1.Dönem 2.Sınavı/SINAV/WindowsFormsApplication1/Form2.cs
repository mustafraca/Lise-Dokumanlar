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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime zamantarih = DateTime.Now;
            label1.Text = zamantarih.ToLongDateString();
            label2.Text = zamantarih.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 x = new Form3();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("N Değerini Giriniz:"));
            int toplam = 1; int sayac = 1;
            while (sayac <= n)
	        {
                toplam = toplam * sayac; sayac++;
            } MessageBox.Show("Toplam Değer: " + toplam);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int m = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("N Değerini Giriniz:"));
            int sayac = 1; int toplam = 0;
            while (sayac <= m)
            {
                toplam += sayac * sayac; sayac++;
            } MessageBox.Show("Toplam Değer: " + toplam);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 x = new Form4();
            x.Show();
        }
    }
}
