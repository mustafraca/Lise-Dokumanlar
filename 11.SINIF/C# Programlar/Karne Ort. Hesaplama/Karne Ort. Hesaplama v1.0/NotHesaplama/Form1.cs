using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotHesaplama
{
    public partial class Form1 : Form
    {
        double ortalama, toplam, ko, ss, dt, y1, y2, y3, p1, p2, proje;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ss = 6;
            y1 = Convert.ToDouble(textBox1.Text);
            y2 = Convert.ToDouble(textBox2.Text);
            y3 = Convert.ToDouble(textBox3.Text);
            p1 = Convert.ToDouble(textBox4.Text);
            p2 = Convert.ToDouble(textBox5.Text);
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
            label10.Text = ortalama.ToString();

            toplam += (ortalama * Convert.ToDouble(comboBox2.SelectedItem));
            label11.Text = toplam.ToString();
            dt += Convert.ToDouble(comboBox2.SelectedItem);
            textBox1.Text = "-1"; textBox2.Text = "-1"; textBox3.Text = "-1";
            textBox4.Text = "-1"; textBox5.Text = "-1"; textBox6.Text = "-1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ko = toplam / dt;
            MessageBox.Show("KARNE ORTALAMANIZ: " + ko);
            this.Text = "Karne Ortalaması Hesaplama";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            webBrowser1.Navigate("https://e-okul.meb.gov.tr/IlkOgretim/Veli/IOV00001.aspx");
            textBox1.Text = "-1"; textBox2.Text = "-1"; textBox3.Text = "-1";
            textBox4.Text = "-1"; textBox5.Text = "-1"; textBox6.Text = "-1";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string kayanyazi = this.Text;
            int adet = kayanyazi.Length;

            string ilkkarakter, sonrasi;
            ilkkarakter = kayanyazi.Substring(0, 1);
            sonrasi = kayanyazi.Substring(1, adet - 1);
            this.Text = sonrasi + ilkkarakter;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-1"; textBox2.Text = "-1"; textBox3.Text = "-1";
            textBox4.Text = "-1"; textBox5.Text = "-1"; textBox6.Text = "-1";
            ortalama = 0; toplam = 0; ko = 0; label10.Text = "0"; label11.Text = "0";
            
        }
    }
}
