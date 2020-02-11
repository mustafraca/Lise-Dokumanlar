using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(textBox3.Text) < 25)
            {
                MessageBox.Show(textBox1.Text + " Numaralı " + textBox2.Text + " Notunuz= 0, KALDINIZ!");
            }
            else if (Convert.ToInt16(textBox3.Text) < 45)
            {
                MessageBox.Show(textBox1.Text + " Numaralı " + textBox2.Text + " Notunuz= 1, KALDINIZ!");
            }
            else if (Convert.ToInt16(textBox3.Text) < 55)
            {
                MessageBox.Show(textBox1.Text + " Numaralı " + textBox2.Text + " Notunuz= 2, GEÇTİNİZ");
            }
            else if (Convert.ToInt16(textBox3.Text) < 70)
            {
                MessageBox.Show(textBox1.Text + " Numaralı " + textBox2.Text + " Notunuz= 3, GEÇTİNİZ"); 
            }
            else if (Convert.ToInt16(textBox3.Text) < 85)
            {
                MessageBox.Show(textBox1.Text + " Numaralı " + textBox2.Text + " Notunuz= 4, GEÇTİNİZ");
            }
            else if (Convert.ToInt16(textBox3.Text) <= 100)
            {
                MessageBox.Show(textBox1.Text + " Numaralı " + textBox2.Text + " Notunuz= 5, GEÇTİNİZ");
            }
            else if (Convert.ToInt16(textBox3.Text) < 0)
            {
                MessageBox.Show("HATALI GİRİŞ, TEKRAR DENEYİN..");
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ, TEKRAR DENEYİN..");
            }

            





        }
    }
}
