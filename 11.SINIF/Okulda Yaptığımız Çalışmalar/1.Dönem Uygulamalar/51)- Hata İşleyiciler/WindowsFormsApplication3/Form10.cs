using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x, y, z, ort;
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);
                z = Convert.ToInt32(textBox3.Text);
                ort = (x + y + z) / 3;
                textBox4.Text = (ort).ToString();
            }
            catch (Exception hata)
            {
                
                MessageBox.Show("BİR HATA YAKALANDI:"+hata.Message);
            }
            finally
            {
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox1.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 eski = new Form1();
            eski.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string kayan = this.Text;
            int x = kayan.Length;
            string ilkkayan, sonkarakter;
            ilkkayan = kayan.Substring(0, 1);
            sonkarakter = kayan.Substring(1, x - 1);
            this.Text = sonkarakter + ilkkayan;
        }
    }
}
