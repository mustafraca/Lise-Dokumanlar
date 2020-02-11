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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double anapara = Convert.ToDouble(textBox1.Text);
            double faizorani = Convert.ToDouble(textBox2.Text) / 100;
            int vade = Convert.ToInt32(textBox3.Text);

            double günn = vade * 30;


            double faiz = (anapara * faizorani * günn) / 360;

            MessageBox.Show("Faiz Miktarı: " + faiz);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.Show(); this.Hide();
        }
    }
}
