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
            listBox1.Items.Clear();

            if (Convert.ToString(textBox1.Text) == "" || Convert.ToString(textBox2.Text) == "")
            {
                MessageBox.Show("Kutucuğa Sayı Girmediniz!", "UYARI!");
            }
            else
            {
                if (Convert.ToInt32(textBox1.Text) < Convert.ToInt32(textBox2.Text))
                {
                    for (int i = Convert.ToInt32(textBox1.Text); i <= Convert.ToInt32(textBox2.Text); i++)
                    {
                        listBox1.Items.Add(i);
                    }
                }
                else if (Convert.ToInt32(textBox1.Text) > Convert.ToInt32(textBox2.Text))
                {
                    for (int i = Convert.ToInt32(textBox2.Text); i <= Convert.ToInt32(textBox1.Text); i++)
                    {
                        listBox1.Items.Add(i);
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz Sayılar Birbirine Eşit!", "UYARI!");
                }
            }
            
        }
    }
}
