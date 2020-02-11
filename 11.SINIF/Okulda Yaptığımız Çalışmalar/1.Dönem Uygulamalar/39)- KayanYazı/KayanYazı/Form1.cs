using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KayanYazı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string kayanyazi2 = this.Text;
            int adet2 = kayanyazi2.Length;

            string ilkkarakter2, sonrasi2;
            ilkkarakter2 = kayanyazi2.Substring(0, 1);
            sonrasi2 = kayanyazi2.Substring(1, adet2 - 1);
            this.Text = sonrasi2 + ilkkarakter2;

            string kayanyazi = label2.Text;
            int adet = kayanyazi.Length;

            string ilkkarakter, sonrasi;
            ilkkarakter = kayanyazi.Substring(0, 1);
            sonrasi = kayanyazi.Substring(1, adet - 1);
            label2.Text = sonrasi + ilkkarakter;
        }
    }
}
