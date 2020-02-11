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
        int gsayi, eb, ek;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            gsayi = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("1.Sayıyı Giriniz:"));
            listBox1.Items.Add(gsayi);
            eb = gsayi - 1; ek = gsayi;
            for (int i = 2; i < 11; i++)
            {
                gsayi = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(i + ".Sayıyı Giriniz:"));
                listBox1.Items.Add(gsayi);
                
                if (gsayi > eb)
                {
                    eb = gsayi;
                }
                else
                {
                    if (gsayi < ek)
                    {
                        ek = gsayi;
                    }
                }
            } listBox1.Items.Add("En Küçük: " + ek + " En Büyük: " + eb);
        }
    }
}
