using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime saat;
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saat = DateTime.Now;
            label2.Text = saat.ToLongTimeString();
            if (textBox1.Text == saat.ToLongTimeString())
            {
                Form2 x = new Form2();
                x.Show();
                x.WindowState = FormWindowState.Maximized;
            } 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
