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
        int sayac = 0, kazandi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rasgele = new Random();
            Double sayi = rasgele.NextDouble();
            
            label2.Text = Convert.ToString((int)(rasgele.NextDouble() * 10));
            label3.Text = Convert.ToString((int)(rasgele.NextDouble() * 10));
            label4.Text = Convert.ToString((int)(rasgele.NextDouble() * 10));

            if (7 == Convert.ToInt16(label2.Text) | 7 == Convert.ToInt16(label3.Text) | 7 == Convert.ToInt16(label4.Text))
            {
                kazandi++;
                label5.Text = Convert.ToString(kazandi);
                pictureBox1.Visible = true;
            }
            else
            {
                sayac++;
                label7.Text = Convert.ToString(sayac);
                pictureBox1.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }      
    }
}
