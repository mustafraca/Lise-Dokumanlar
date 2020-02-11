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
        int ascii, gsayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ascii = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Sayı Aralığı Giriniz: "));
            gsayi = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Sayı Giriniz: "));
                for (int i = 0; i <= ascii; i++) 
                {
                    if (gsayi == i)
                    {
                        MessageBox.Show(Convert.ToString(i) + " = " + (char)i);
                    }
                }
            
        }
    }
}
