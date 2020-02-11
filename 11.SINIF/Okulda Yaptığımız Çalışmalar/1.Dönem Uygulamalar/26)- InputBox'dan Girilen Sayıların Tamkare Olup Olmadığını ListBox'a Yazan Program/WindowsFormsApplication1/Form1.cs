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
        int kac, gsayi; double kok;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kac = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Kaç Sayı Girilecek:"));

            for (int i = 1; i <= kac; i++)
            {
                gsayi = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(i + ".Sayı Giriniz: "));

                kok = Math.Sqrt(gsayi);
                if (Convert.ToInt32(kok) * Convert.ToInt32(kok) == gsayi)
                {
                    listBox1.Items.Add("Girdiğiniz " + gsayi + " Sayısı Tamkaredir");
                }
                else
                {
                    listBox1.Items.Add("Girdiğiniz " + gsayi + " Sayısı Tamkare Değildir");
                }
            }     
        }
    }
}
