using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElektronikMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\Mustafa\Okul Dosyaları\Veri Tabanı\Okulda Yaptığımız Çalışmalar\15)- Elektronik Market\Resimler\PC.jpg");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\Mustafa\Okul Dosyaları\Veri Tabanı\Okulda Yaptığımız Çalışmalar\15)- Elektronik Market\Resimler\MACHINTOSH.jpg");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"D:\Mustafa\Okul Dosyaları\Veri Tabanı\Okulda Yaptığımız Çalışmalar\15)- Elektronik Market\Resimler\LAPTOP.jpg");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:  pictureBox2.Image = Image.FromFile(@"D:\Mustafa\Okul Dosyaları\Veri Tabanı\Okulda Yaptığımız Çalışmalar\15)- Elektronik Market\Resimler\HARDDISK.jpg"); 
                    break;
                case 1:  pictureBox2.Image = Image.FromFile(@"D:\Mustafa\Okul Dosyaları\Veri Tabanı\Okulda Yaptığımız Çalışmalar\15)- Elektronik Market\Resimler\YAZICI.jpg"); 
                    break;
                case 2:  pictureBox2.Image = Image.FromFile(@"D:\Mustafa\Okul Dosyaları\Veri Tabanı\Okulda Yaptığımız Çalışmalar\15)- Elektronik Market\Resimler\UYDUANTENI.jpg"); 
                    break;
            }   
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(@"D:\Mustafa\Okul Dosyaları\Veri Tabanı\Okulda Yaptığımız Çalışmalar\15)- Elektronik Market\Resimler\ANSWMACH.WMF");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile(@"D:\Mustafa\Okul Dosyaları\Veri Tabanı\Okulda Yaptığımız Çalışmalar\15)- Elektronik Market\Resimler\HESAPM.jpg");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile(@"D:\Mustafa\Okul Dosyaları\Veri Tabanı\Okulda Yaptığımız Çalışmalar\15)- Elektronik Market\Resimler\FAX.jpg");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: pictureBox6.Image = Image.FromFile(@"D:\Mustafa\Okul Dosyaları\Veri Tabanı\Okulda Yaptığımız Çalışmalar\15)- Elektronik Market\Resimler\TL.jpg");
                    break;
                case 1: pictureBox6.Image = Image.FromFile(@"D:\Mustafa\Okul Dosyaları\Veri Tabanı\Okulda Yaptığımız Çalışmalar\15)- Elektronik Market\Resimler\DOLAR.jpg");
                    break;
                case 2: pictureBox6.Image = Image.FromFile(@"D:\Mustafa\Okul Dosyaları\Veri Tabanı\Okulda Yaptığımız Çalışmalar\15)- Elektronik Market\Resimler\EURO.jpg");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
