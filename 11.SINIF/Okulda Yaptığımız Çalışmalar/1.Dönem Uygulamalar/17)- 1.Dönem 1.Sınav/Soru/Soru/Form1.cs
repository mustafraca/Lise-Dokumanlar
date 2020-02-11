
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Soru
{
    
    public partial class Form1 : Form
    {
        string sınıf, ad, geckal;
        int sozlu, no, y1, y2, ort, not;

        public Form1()
        {
            InitializeComponent();   
        }
    
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            y1 = Convert.ToInt16(textBox4.Text); y2 = Convert.ToInt16(textBox5.Text); sozlu = Convert.ToInt16(textBox6.Text);
            ort = (y1 + y2 + sozlu) / 3;
            textBox7.Text = Convert.ToString(ort);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(sınıf);
            switch (listBox1.SelectedIndex)
            {
                case 0: sınıf = "9-A"; break;
                case 1: sınıf = "9-B"; break;
                case 2: sınıf = "9-C"; break;
                case 3: sınıf = "10-A"; break;
                case 4: sınıf = "10-B"; break;
                case 5: sınıf = "10-C"; break;
                case 6: sınıf = "11-A"; break;
                case 7: sınıf = "11-B"; break;
                case 8: sınıf = "11-C"; break;
                case 9: sınıf = "12-A"; break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if (ort < 25) { not = 0; geckal = "KALDI";}
            else if (ort < 45) { not = 1; geckal = "KALDI";}
            else if (ort < 55) { not = 2; geckal = "GEÇTİ"; }
            else if (ort < 70) { not = 3;  geckal = "GEÇTİ";}
            else if (ort < 85) {not = 4;  geckal = "GEÇTİ";}
            else if (ort <= 100) { not = 5; geckal = "GEÇTİ"; }

            ad = textBox2.Text; no = Convert.ToInt16(textBox1.Text);
            listBox2.Items.Add(no + "              " + ad + "                               " + sınıf + "            " + comboBox1.SelectedItem + "                      " + not + "                   " +geckal);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Çıkmak İstiyor musunuz?", "UYARI!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (x == DialogResult.Yes)
            {
                Close();
            }
            else
            { MessageBox.Show("Forma Dönülüyor"); }
        }
    }
}
