using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextDosyaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Metin Dosyaları |*.txt|" + "Bütün Dosyalar|*.*";
            openFileDialog1.Title = "Açılacak Dosyayı Seçiniz:";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosyaadi = openFileDialog1.FileName;
                System.IO.TextReader dosya = System.IO.File.OpenText(dosyaadi);
                string x = dosya.ReadToEnd();
                dosya.Close();
                textBox1.Text = x;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Kaydetmek için bir ad giriniz:";
            saveFileDialog1.Filter = "Metin Dosyaları |*.txt|" + "Bütün Dosyalar|*.*";
            saveFileDialog1.DefaultExt = "txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosyaadi = saveFileDialog1.FileName;
                System.IO.TextWriter dosya = System.IO.File.CreateText(dosyaadi);
                dosya.Write(textBox1.Text);
                dosya.Close();
            }
        }
    }
}
