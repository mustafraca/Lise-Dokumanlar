using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0, y = 1, z = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 3; i < 20; i++)
            {
                z = x + y;
                listBox1.Items.Add(z);
                x = y;
                y = z;
            }
        }
    }
}
