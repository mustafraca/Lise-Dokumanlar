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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            double modalma = Convert.ToDouble(textBox1.Text) % Convert.ToDouble(textBox2.Text);
            MessageBox.Show("Sonuç: " + modalma);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int z = Convert.ToInt32(Math.Pow(x, y));
            MessageBox.Show("Sonuç: " + z);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) > Convert.ToInt32(textBox2.Text))
            {
                MessageBox.Show("1.Sayı 2.Sayıdan Büyüktür.");
            }
            else
            {
                MessageBox.Show("1.Sayı 2.Sayıdan Büyük Değil.");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) < Convert.ToInt32(textBox2.Text))
            {
                MessageBox.Show("2.Sayı 1.Sayıdan Küçüktür. \nPrograma Dönülüyor.");
            }
            else
            {
                MessageBox.Show("2.Sayı 1.Sayıdan Küçük Değil. \nPrograma Dönülüyor.");
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) == Convert.ToInt32(textBox2.Text))
            {
                MessageBox.Show("Sayılar Birbirine Eşittir.");
            }
            else
            {
                MessageBox.Show("Sayılar Birbirne Eşit Değil. \nPrograma Dönülüyor.");
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) != Convert.ToInt32(textBox2.Text))
            {
                MessageBox.Show("Sayılar Birbirine Eşit Değil.");
            }
            else
            {
                MessageBox.Show("Sayılar Birbirne Eşit. \nPrograma Dönülüyor.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cıkıs;
            cıkıs = MessageBox.Show("Programdan Çıkmak İstiyor musunuz?", "UYARI!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (cıkıs == DialogResult.Yes)
            {
                Close();
            }
            else if (cıkıs == DialogResult.No)
            {
                MessageBox.Show("Güzel Bir Karar Verdiniz.Programa Dönülüyor.");
            }
        }
    }
}
