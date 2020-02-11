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

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0; double ortalama = 0; int eb = 0; int ek = 0;


            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sayi3 = Convert.ToInt32(textBox3.Text);

            toplam = sayi1 + sayi2 + sayi3;
            label8.Text = toplam.ToString();

            ortalama = (Convert.ToDouble(sayi1) + Convert.ToDouble(sayi2) + Convert.ToDouble(sayi3)) / 3;
            
            label9.Text = ortalama.ToString();
            

            eb = Math.Max(sayi1, sayi2);
            int eb2 = Math.Max(eb, sayi3);
            label10.Text = eb2.ToString();

            ek = Math.Min(sayi1, sayi2);
            int ek2 = Math.Min(ek, sayi3);
            label11.Text = ek2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); 
            textBox2.Clear();

            textBox3.Clear(); 
            label8.Text = "";
            
            label9.Text = "";
            label10.Text = ""; 
            label11.Text = "";
            
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("1.kutu boş sayı giriniz.");
                textBox1.Focus();
                textBox2.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("2.kutu boş sayı giriniz.");
                textBox2.Focus();
                textBox3.Text = "";
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.Show(); this.Hide();
        }
    }
}
