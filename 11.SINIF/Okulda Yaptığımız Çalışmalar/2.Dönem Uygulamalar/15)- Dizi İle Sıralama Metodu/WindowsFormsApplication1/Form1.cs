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
        int[] sayi = new int[5];
        int takas;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                sayi[i]=int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Sayı Gir:"));
                listBox1.Items.Add(sayi[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Sıralama Seçeneği Seçmediniz!");
                listBox2.Items.Clear();
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int k = i + 1; k < 5; k++)
                    {
                        if (radioButton1.Checked == true)
                        {
                            if (sayi[i] > sayi[k])
                            {
                                takas = sayi[i];
                                sayi[i] = sayi[k];
                                sayi[k] = takas;
                            }
                        }
                        if (radioButton2.Checked == true)
                        {
                            if (sayi[i] < sayi[k])
                            {
                                takas = sayi[i];
                                sayi[i] = sayi[k];
                                sayi[k] = takas;
                            }
                        }
                    }
                }
                for (int i = 0; i < 5; i++)
                {
                    listBox2.Items.Add(sayi[i]);
                }
                MessageBox.Show("Sıralama Yapıldı");
            }
        }
    }
}
