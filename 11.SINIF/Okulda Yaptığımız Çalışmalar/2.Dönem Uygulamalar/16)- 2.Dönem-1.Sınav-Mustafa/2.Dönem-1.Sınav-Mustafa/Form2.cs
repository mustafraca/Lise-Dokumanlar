using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2.Dönem_1.Sınav_Mustafa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] isim = new string[5]; int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            isim[i] = textBox1.Text;
            listBox1.Items.Add(isim[i]);
            i++;
            textBox1.Text = "";
            textBox1.Focus();
            if (i == 5)
            {
                button1.Enabled = false;
                button2.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int y = 4; y >= 0; y--)
            {
                listBox2.Items.Add(isim[y]);
            }
        }
    }
}
