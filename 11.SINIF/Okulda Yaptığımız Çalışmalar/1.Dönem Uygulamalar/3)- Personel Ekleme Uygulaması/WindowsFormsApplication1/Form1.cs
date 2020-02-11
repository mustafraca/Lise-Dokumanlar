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
            listBox1.Items.Add(textBox1.Text+ ", " + textBox2.Text + ", "+textBox3.Text + ", " +comboBox1.SelectedItem);
            textBox1.Clear ();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = (""); // Veya textBox1.Text = (""); işlemide aynı işi yapar..
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            listBox1.Text.Remove(listBox1.SelectedItem);                        
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            listBox1.Items.Add("Adı Soyadı" + ", " + "Doğum Yeri" + ", " + "Doğum Tarihi" + ", " + "Meslek");
        }
    }
}
