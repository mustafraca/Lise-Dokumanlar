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
        Form2 x = new Form2();
        static public string[] adsoyad = new string[10];
        static public int[] not = new int[10];
        public int i;
        private void button1_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 10; i++)
            {
                adsoyad[i] = string.Concat(Microsoft.VisualBasic.Interaction.InputBox(i+1 + ".Ad-Soyadı Giriniz: "));
                not[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(i+1 + ".Notu Giriniz: "));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x.Show();
            
        }

    }
}
