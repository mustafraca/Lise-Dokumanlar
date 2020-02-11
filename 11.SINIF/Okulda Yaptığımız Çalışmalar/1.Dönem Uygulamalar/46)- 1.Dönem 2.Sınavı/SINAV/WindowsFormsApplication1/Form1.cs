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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "mustafa")
            {
                MessageBox.Show("Girdiğiniz Parola Doğru. Giriş Yapılıyor.");
                Form2 x = new Form2();
                x.Show(); this.Hide();
                timer1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Parolayı Yanlış Girdiniz. Tekrar Deneyiniz.");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("15 Saniye İçerisinde Parola Girmediniz. Program Kapatılıyor.");
            timer1.Enabled = false;
            Close();
        }
    }
}
