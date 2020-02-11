using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2.Dönem_1.Sınav_Mustafa
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[] ad = new string[5];
        string[] soyad = new string[5];
        int y = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            ad[y] = textBox1.Text;
            soyad[y] = textBox2.Text;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
            y++;
            if (y == 5)
            {
                button1.Enabled = false;
                MessageBox.Show("5 Kişi Girildi.");
                button2.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string arama = string.Concat(Microsoft.VisualBasic.Interaction.InputBox("Kişi Adı:"));
            for (int i = 0; i < 5; i++)
            {
                if (arama == ad[i] + soyad[i] || arama == ad[i] + " " + soyad[i])
                {
                    textBox1.Text = ad[i];
                    textBox2.Text = soyad[i];
                    MessageBox.Show("Kişi Bulundu. Textboxlara yazıldı");
                    break;
                }
                else
                {
                    if (i == 5)
                    {
                        MessageBox.Show("Aradığınız Kişi Bulunamadı");
                    }
                }
            }
        }
    }
}
