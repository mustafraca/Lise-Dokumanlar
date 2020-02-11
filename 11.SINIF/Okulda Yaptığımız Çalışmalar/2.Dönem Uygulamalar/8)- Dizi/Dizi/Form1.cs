using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int[] dizi = new int[10];
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                dizi[i] = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Sayı Gir"));
                listBox1.Items.Add(dizi[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 9; i >= 0; i--)
            {
                listBox2.Items.Add(dizi[i]);
            }
            
        }
    }
}
