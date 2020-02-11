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
            int x = Convert.ToInt16(textBox1.Text);
            int y = Convert.ToInt16(textBox2.Text);
            int z = Convert.ToInt16(textBox3.Text);

            
            if (x == y & x == z & y == z)
            {
                MessageBox.Show("Eşkenar Üçgen");  label1.Text = ("Eşkenar Üçgen:");
                pictureBox2.Visible = true; pictureBox1.Visible = false; pictureBox3.Visible = false;
            }
             else if (x == y || y == z || z == x)
            {
                MessageBox.Show("İkizkenar Üçgen"); label1.Text = ("İkizkenar Üçgen:");
                pictureBox1.Visible = true; pictureBox2.Visible = false; pictureBox3.Visible = false;
            }
            else
            {
                MessageBox.Show("Çeşitkenar Üçgen"); label1.Text = ("Çeşitkenar Üçgen:");
                pictureBox3.Visible = true; pictureBox1.Visible = false; pictureBox2.Visible = false;

            }
        }
    }
}
