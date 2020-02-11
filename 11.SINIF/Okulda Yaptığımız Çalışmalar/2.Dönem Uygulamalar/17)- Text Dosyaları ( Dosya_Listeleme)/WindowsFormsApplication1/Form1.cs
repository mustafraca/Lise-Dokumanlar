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
            System.IO.FileInfo d = new System.IO.FileInfo("Öğrenci.dat");
            if (d.Exists==true) // dosya varsa
            {
                System.IO.TextReader dosya = System.IO.File.OpenText("Öğrenci.dat");
                string adi, bölümü, sinifi;
                while ((adi=dosya.ReadLine())!=null)
                {
                    listBox1.Items.Add(adi);
                    bölümü = dosya.ReadLine();
                    listBox2.Items.Add(bölümü);
                    sinifi = dosya.ReadLine();
                    listBox3.Items.Add(sinifi);
                }
                dosya.Close(); // dosyayı kapat
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Text kutularındaki bilgileri listelere ekle
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            int i;
            System.IO.TextWriter dosya = System.IO.File.CreateText("Öğrenci.dat");
            for (i = 0; i < listBox1.Items.Count - 1; i++)
            {
               //Bilgileri dosyaya yaz
                dosya.WriteLine(listBox1.Items[i]);
                dosya.WriteLine(listBox2.Items[i]);
                dosya.WriteLine(listBox3.Items[i]);
            }
            dosya.Close(); // Dosyayı Kapat
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ind;
            ind = listBox1.SelectedIndex;
            if (ind < 0)
            {
                MessageBox.Show("Silinecek Elemanı Seçiniz");
            }
            else
            {
                listBox1.Items.RemoveAt(ind);
                listBox2.Items.RemoveAt(ind);
                listBox3.Items.RemoveAt(ind);
            }
        }
    }
}
