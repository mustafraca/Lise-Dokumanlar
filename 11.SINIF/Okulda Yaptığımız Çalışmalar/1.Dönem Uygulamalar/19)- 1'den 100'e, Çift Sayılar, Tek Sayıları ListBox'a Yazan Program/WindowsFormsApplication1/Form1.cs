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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          listBox1.Items.Clear();
          for (int i = 0; i <= 100; i++)
          {
               listBox1.Items.Add(i);
          } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= 100; i += 2)
            {
                listBox1.Items.Add(i);
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i <= 100; i += 2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 100; i >=0; i--)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
