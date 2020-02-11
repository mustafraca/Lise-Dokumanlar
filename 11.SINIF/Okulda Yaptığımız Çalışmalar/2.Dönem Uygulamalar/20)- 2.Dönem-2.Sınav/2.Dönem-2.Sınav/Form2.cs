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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Metin Dosyaları | *.txt |" + "Bütün Dosyalar | *.*";
            openFileDialog1.Title = "Açılacak Dosyayı Seçiniz:";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosyaadı = openFileDialog1.FileName;
                System.IO.TextReader dosya = System.IO.File.OpenText(dosyaadı);
                string x = dosya.ReadToEnd();
                dosya.Close();
                textBox1.Text = x;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyaları | *.txt |" + "Bütün Dosyalar | *.*";
            saveFileDialog1.Title = "Kaydetmek İçin Bir Ad Giriniz:";
            saveFileDialog1.DefaultExt = "txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosyaadı = saveFileDialog1.FileName;
                System.IO.TextWriter dosya = System.IO.File.CreateText(dosyaadı);
                dosya.Write(textBox1.Text);
                dosya.Close();
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 anamenu = new Form1();
            anamenu.Show(); this.Hide();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }
    }
}
