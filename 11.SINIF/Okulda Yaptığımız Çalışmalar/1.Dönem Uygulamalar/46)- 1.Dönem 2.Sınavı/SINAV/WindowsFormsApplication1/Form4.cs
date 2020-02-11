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
            int m = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            for (int i = m; i < n; i++)
            {
                int onlar = (((i % 10000) % 1000) % 100) / 10;
                if (onlar == 3 || onlar == 5 || onlar == 8)
                {
                    listBox1.Items.Add(i);
                }
                
            }
        }
    }
}
