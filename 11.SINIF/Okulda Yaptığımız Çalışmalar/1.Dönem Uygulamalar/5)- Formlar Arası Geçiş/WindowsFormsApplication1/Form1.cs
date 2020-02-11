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
            Form2 x = new Form2();
            x.Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            c.Show(); this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 v = new Form4();
            v.Show(); this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
