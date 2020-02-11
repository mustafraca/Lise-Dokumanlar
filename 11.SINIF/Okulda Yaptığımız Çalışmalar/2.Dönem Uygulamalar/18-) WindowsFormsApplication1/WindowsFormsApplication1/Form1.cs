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

        private void Form1_Load(object sender, EventArgs e)
        {
            System.IO.FileInfo d = new System.IO.FileInfo("ayarlar.dat");
            if (d.Exists==true)//dosya varsa
            {
                System.IO.TextReader dosya = System.IO.File.OpenText("ayarlar.dat");
                textBox1.Text = dosya.ReadLine();
                textBox1.ForeColor = Color.FromName(dosya.ReadLine());
                textBox1.Font = new Font(dosya.ReadLine(), float.Parse(dosya.ReadLine()), FontStyle.Bold, GraphicsUnit.Point);
                this.Text = dosya.ReadLine();
                textBox2.Text = this.Text;
                this.BackColor = Color.FromName(dosya.ReadLine());
                this.Width = int.Parse(dosya.ReadLine());
                this.Height = int.Parse(dosya.ReadLine());
                dosya.Close(); // dosyayı kapat
            }
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            System.IO.TextWriter dosya = System.IO.File.CreateText("ayarlar.txt");
            dosya.WriteLine(textBox1.Text);
            dosya.WriteLine(textBox1.ForeColor.ToKnownColor().ToString());
            dosya.WriteLine(textBox1.Font.Name);
            dosya.WriteLine(textBox1.Font.Size);
            dosya.WriteLine(this.Text);
            dosya.WriteLine(BackColor.ToKnownColor().ToString());
            dosya.WriteLine(this.Size.Width);
            dosya.WriteLine(this.Size.Height);
            dosya.Close(); // Dosyayı Kapat
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Yazı Rengini renk diyolog penceresinden seçilen renge ayarla
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Formun zemin Rengini renk diyolog penceresinden seçilen renge ayarla
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // yazı tipini font diyalog penceresinden seçilen fonta ayarla
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // form başlığını kullanıcıya sor
            this.Text = textBox2.Text;
        }
    }
}
