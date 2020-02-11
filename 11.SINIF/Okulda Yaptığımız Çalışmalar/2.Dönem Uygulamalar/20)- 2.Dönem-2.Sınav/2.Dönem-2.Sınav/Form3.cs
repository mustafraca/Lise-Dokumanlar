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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            System.IO.FileInfo d = new System.IO.FileInfo("ogrenci.dat");

            if (d.Exists == true)
            {
                System.IO.TextReader dosya = System.IO.File.OpenText("ogrenci.dat");
                string adi, tc, yas;

                while ((adi = dosya.ReadLine()) != null)
                {
                    listBox1.Items.Add(adi);
                    tc = dosya.ReadLine();
                    listBox2.Items.Add(tc);
                    yas = dosya.ReadLine();
                    listBox3.Items.Add(yas);
                }
                dosya.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Silinecek Kişiyi Seçiniz.");
            }
            else
            {
                listBox1.Items.RemoveAt(index);
                listBox2.Items.RemoveAt(index);
                listBox3.Items.RemoveAt(index);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.TextWriter dosya = System.IO.File.CreateText("ogrenci.dat");

            for (int i = 0; i < listBox1.Items.Count - 1; i++)
            {
                dosya.WriteLine(listBox1.Items[i]);
                dosya.WriteLine(listBox2.Items[i]);
                dosya.WriteLine(listBox3.Items[i]);
            }
            dosya.Close();

            Form1 anamenu = new Form1();
            anamenu.Show(); this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.TextWriter dosya = System.IO.File.CreateText("ogrenci.dat");

            for (int i = 0; i < listBox1.Items.Count - 1; i++)
            {
                dosya.WriteLine(listBox1.Items[i]);
                dosya.WriteLine(listBox2.Items[i]);
                dosya.WriteLine(listBox3.Items[i]);
            }
            dosya.Close();
        }
    }
}
