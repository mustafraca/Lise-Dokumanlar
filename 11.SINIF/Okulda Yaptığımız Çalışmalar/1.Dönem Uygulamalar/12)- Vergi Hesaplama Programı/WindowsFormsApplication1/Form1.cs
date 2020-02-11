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
        int gelir = 0; 
        private void button1_Click(object sender, EventArgs e)
        {      
            if (Convert.ToInt32(textBox3.Text) <= 150)
            {
                gelir = Convert.ToInt32((Convert.ToInt32(textBox3.Text) / 100) * 25);                
            }
            else if (Convert.ToInt32(textBox3.Text) > 150 & Convert.ToInt32(textBox3.Text) <= 300)
            {
                gelir = Convert.ToInt32((Convert.ToInt32(textBox3.Text) / 100) * 30);                
            }
            else if (Convert.ToInt32(textBox3.Text) > 300 & Convert.ToInt32(textBox3.Text) <= 600)
            {
                gelir = Convert.ToInt32((Convert.ToInt32(textBox3.Text) / 100) * 35);                
            }
            else if (Convert.ToInt32(textBox3.Text) > 600 & Convert.ToInt32(textBox3.Text) <= 1200)
            {
                gelir = Convert.ToInt32((Convert.ToInt32(textBox3.Text) / 100) * 40);                
            }
            else if (Convert.ToInt32(textBox3.Text) > 1200 & Convert.ToInt32(textBox3.Text) <= 1200000)
            {
                gelir = Convert.ToInt32((Convert.ToInt32(textBox3.Text) / 100) * 50);
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + ", " + textBox2.Text + ", " + gelir);
            textBox1.Text = " "; textBox2.Text = " "; textBox3.Text = " ";
        }

    }
}
