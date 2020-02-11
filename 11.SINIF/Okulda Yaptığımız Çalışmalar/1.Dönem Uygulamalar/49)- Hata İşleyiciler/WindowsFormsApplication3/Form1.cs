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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 son = new Form3();
            son.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 yheni = new Form4();
            yheni.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 yeni = new Form5();
            yeni.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 yeni = new Form6();
            yeni.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 yeni = new Form7();
            yeni.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dügme;
            dügme = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            if (dügme == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 yeni = new Form9();
            yeni.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form10 yeni = new Form10();
            yeni.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form11 yeni = new Form11();
            yeni.Show();
            this.Hide();
        }
    }
}
