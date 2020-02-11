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
        int toplam, y;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); toplam = 0; label2.Visible = true;
            Random x = new Random();

            for (int i = 0; i < 11; i++)
            {
                y = (int)(x.NextDouble() * 100);
                listBox1.Items.Add(y); toplam += y;
            }
            label2.Text = Convert.ToString(toplam);
        }
    }
}
