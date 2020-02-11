using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AsciiKod
{
    public partial class Form1 : Form
    {
        int ascii, ascii2, gsayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ascii = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Taban Sayısını Giriniz: "));
            ascii2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Tavan Sayısını Giriniz: "));

            gsayi = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Sayı Giriniz: "));

            if (gsayi >= ascii && gsayi <= ascii2)
            {
                for (int i = ascii; i <= ascii2; i++)
                {
                    if (gsayi == i)
                    {
                        MessageBox.Show(Convert.ToString(i) + " = " + (char)i);
                    }
                }
            }
            else
            {
                MessageBox.Show("Sayı Aralığı Dışında Sayı Girdiniz.");
            }
                
            
        }
    }
}
