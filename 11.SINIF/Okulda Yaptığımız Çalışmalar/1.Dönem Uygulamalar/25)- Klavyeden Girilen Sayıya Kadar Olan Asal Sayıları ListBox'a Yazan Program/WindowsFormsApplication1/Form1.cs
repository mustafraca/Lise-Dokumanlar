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
            int sayi = Convert.ToInt32(textBox1.Text);

            int i, j, s,syc; s = sayi; syc = 0; 

            for (i = 2; i <= s; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        syc = syc + 1;
                    }
                }
                if (syc < 3)
                {
                    listBox1.Items.Add(i.ToString());
                } syc = 0;
            }
        }
    }
}
