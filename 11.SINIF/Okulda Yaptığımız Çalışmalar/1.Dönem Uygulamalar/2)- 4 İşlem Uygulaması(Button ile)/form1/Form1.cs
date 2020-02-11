using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1,sayı2,sonuc;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayı1 + sayı2;
            label2.Text = sonuc.ToString();
            label1.Text = "+";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, sonuc;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayı1 - sayı2;
            label2.Text = sonuc.ToString();
            label1.Text = "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, sonuc;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayı1 / sayı2;
            label2.Text = sonuc.ToString();
            label1.Text = "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, sonuc;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayı1 * sayı2;
            label2.Text = sonuc.ToString();
            label1.Text = "*";
        }
    }
}
