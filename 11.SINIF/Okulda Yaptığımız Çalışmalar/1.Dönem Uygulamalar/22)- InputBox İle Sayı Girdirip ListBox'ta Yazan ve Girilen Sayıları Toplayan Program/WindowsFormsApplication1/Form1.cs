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
        int sayi, toplam, index;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 10; i++)
            {
                sayi = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(i+1 + ".Sayıyı Giriniz: " + "Sayı Girişi" + ""));
                listBox1.Items.Add(sayi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                toplam += Convert.ToInt32(listBox1.Items[i]);
                
            } label1.Text = Convert.ToString(toplam);
        }
    }
}
