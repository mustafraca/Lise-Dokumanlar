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
    public partial class Form4 : Form
    {
        int x,y;
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 eski = new Form1();
            eski.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt16(textBox1.Text);
                y = Convert.ToInt16(textBox2.Text);
                label4.Text = Convert.ToString(x + y);
                label5.Text = " ";
                textBox1.Text = " ";
                textBox2.Text = " ";

            }
            catch (FormatException fhata)
            {
                label5.Text = "HATA! Lütfen alanlara sayısal veriler giriniz.";
            }
            catch (OverflowException ohata)
            {
                label5.Text = "HATA! Alanlara çok büyük değerler giriyorsunuz.";
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
        }
    }

