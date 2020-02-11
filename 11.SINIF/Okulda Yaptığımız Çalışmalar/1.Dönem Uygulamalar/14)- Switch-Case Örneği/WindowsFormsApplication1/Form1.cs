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

        private void button1_Click(object sender, EventArgs e)
        {
            string sehir = textBox1.Text;
            switch (sehir)
            {
                case "ANKARA":
                    { MessageBox.Show("Personel Ankara'da Oturmaktadır."); break; }
                case "İZMİR":
                    { MessageBox.Show("Personel İzmir'de Oturmaktadır."); break; }
                case "İSTANBUL":
                    { MessageBox.Show("Personel İstanbul'da Oturmaktadır."); break; }
                case "İZMİT":
                    { MessageBox.Show("Personel İZMİT'de(KANDIRA) Oturmaktadır."); break; }
                case "HAKKARİ":
                    { MessageBox.Show("Personel Hakkari'de (♥♥) Oturmaktadır."); break; }
                case "GİRESUN":
                    { MessageBox.Show("Personel GİRESUN'da (♥♥) Oturmaktadır."); break; }
                default:
                    { MessageBox.Show("Personel Büyükşehirde Oturmamakta."); break; }
            }
        }
    }
}
