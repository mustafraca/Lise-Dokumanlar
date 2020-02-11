using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        string ad, gk; int no, y1, y2, s, ort, kac, not;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kac = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Kaç Kişi Girilecek?"));
            for(int i = 1; i <= kac; i++)
            {
                ad = string.Concat(Microsoft.VisualBasic.Interaction.InputBox(i + ".Kişinin adını giriniz"));
                no = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(i + ".Kişinin okul numarasını giriniz"));
                y1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(i + ".Kişinin yazılı1 giriniz"));
                y2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(i + ".Kişinin yazılı2 giriniz"));
                s = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(i + ".Kişinin sözlü notunu giriniz"));

                ort = (y1 + y2 + s) / 3;

                if (ort < 25){not = 0; gk = "Kaldı";}
                else if (ort < 45){ not = 1; gk = "Kaldı";}
                else if (ort < 55){ not = 2; gk = "Geçti"; }
                else if (ort < 70) { not = 3; gk = "Geçti"; }
                else if (ort < 85) { not = 4; gk = "Geçti"; }
                else if (ort <= 100) { not = 5; gk = "Geçti"; }

                listBox1.Items.Add(ad + ", " + no + ", " + ort + ", " + not + ", " + gk);
                
            }
        }
    }
}
