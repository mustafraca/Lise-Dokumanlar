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
    public partial class Form3 : Form
    {
         int x, y;
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);
                MessageBox.Show("Sonuç: " + (x + y));
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Oluştu:" + hata.Message);
            }
            finally
            {
                textBox1.Clear();
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 eski = new Form1();
            eski.Show();
            this.Close();
        }
    }
}
