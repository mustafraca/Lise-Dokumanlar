using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ÇokAmaçlıProgram
{
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }
        double ortalama, toplam, ko, ss, dt, y1, y2, y3, p1, p2, proje;
        private void button1_Click(object sender, EventArgs e)
        {
            ss = 6;
            y1 = Convert.ToInt16(textBox1.Text);
            y2 = Convert.ToInt16(textBox2.Text);
            y3 = Convert.ToInt16(textBox3.Text);
            p1 = Convert.ToInt16(textBox4.Text);
            p2 = Convert.ToInt16(textBox5.Text);
            proje = Convert.ToInt16(textBox6.Text);
            if (y1.ToString() == "-1")
            {
                ss--; y1 = 0;
            }
            if (y2.ToString() == "-1")
            {
                ss--; y2 = 0;
            }
            if (y3.ToString() == "-1")
            {
                ss--; y3 = 0;
            }
            if (p1.ToString() == "-1")
            {
                ss--; p1 = 0;
            }
            if (p2.ToString() == "-1")
            {
                ss--; p2 = 0;
            }
            if (proje.ToString() == "-1")
            {
                ss--; proje = 0;
            }
            ortalama = Convert.ToDouble((y1 + y2 + y3 + p1 + p2 + proje) / ss);
            label11.Text = ortalama.ToString();

            toplam += (ortalama * Convert.ToDouble(comboBox2.SelectedItem));
            label12.Text = toplam.ToString();
            dt += Convert.ToDouble(comboBox2.SelectedItem);
            textBox1.Text = "-1"; textBox2.Text = "-1"; textBox3.Text = "-1";
            textBox4.Text = "-1"; textBox5.Text = "-1"; textBox6.Text = "-1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ko = toplam / dt;
            MessageBox.Show("KARNE ORTALAMANIZ: " + ko);
        }

        private void Menü_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            textBox1.Text = "-1"; textBox2.Text = "-1"; textBox3.Text = "-1";
            textBox4.Text = "-1"; textBox5.Text = "-1"; textBox6.Text = "-1";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-1"; textBox2.Text = "-1"; textBox3.Text = "-1";
            textBox4.Text = "-1"; textBox5.Text = "-1"; textBox6.Text = "-1";
            ko = 0; ortalama = 0; toplam = 0; label11.Text = "0"; label12.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapım: -Mustafa ACAR-", "HAKKINDA");
        }

    }
}
