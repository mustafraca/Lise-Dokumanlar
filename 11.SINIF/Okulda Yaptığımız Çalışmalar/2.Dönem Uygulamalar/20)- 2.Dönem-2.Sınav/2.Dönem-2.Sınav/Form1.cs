using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2.Dönem_2.Sınav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string kayanyazi = label1.Text;
            int adet = kayanyazi.Length;

            string ilk, sonra;
            ilk = kayanyazi.Substring(0, 1);
            sonra = kayanyazi.Substring(1, adet - 1);
            label1.Text = sonra + ilk;
        }

        private void kayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show(); this.Hide();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 yeni2 = new Form3();
            yeni2.Show(); this.Hide();
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.ForeColor = colorDialog1.Color;
            }
        }

        private void yazıTipiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
            }
        }

        private void arkaPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}
