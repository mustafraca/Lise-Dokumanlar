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
            Form2 xyeni = new Form2();
            xyeni.Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 yyeni = new Form3();
            yyeni.Show(); this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 zyeni = new Form4();
            zyeni.Show(); this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
