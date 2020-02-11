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
        double topla = 0, çıkar = 0, böl = 0, çarp = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            topla = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
            label4.Text = Convert.ToString(topla);
            pictureBox1.Image = Image.FromFile(@"E:\Veri Tabanı\Okulda Yaptığımız Çalışmalar\4)- 4 İşlem Uygulaması(RadioButton ile)\Resim\arti.bmp");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            çıkar = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
            label4.Text = Convert.ToString(çıkar);
            pictureBox1.Image = Image.FromFile(@"E:\Veri Tabanı\Okulda Yaptığımız Çalışmalar\4)- 4 İşlem Uygulaması(RadioButton ile)\Resim\eksi.bmp");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            çarp = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
            label4.Text = Convert.ToString(çarp);
            pictureBox1.Image = Image.FromFile(@"E:\Veri Tabanı\Okulda Yaptığımız Çalışmalar\4)- 4 İşlem Uygulaması(RadioButton ile)\Resim\çarpı.bmp");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            böl = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
            label4.Text = Convert.ToString(böl);
            pictureBox1.Image = Image.FromFile(@"E:\Veri Tabanı\Okulda Yaptığımız Çalışmalar\4)- 4 İşlem Uygulaması(RadioButton ile)\Resim\bölü.bmp");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
