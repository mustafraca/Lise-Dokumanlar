using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dizi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isim = new string[10];
        
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                isim[i] = string.Concat(Microsoft.VisualBasic.Interaction.InputBox("İsim Gir:"));
                listBox1.Items.Add(isim[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 1;
            for (int i = 0; i < 10; i++)
            {
                if (isim[i].Substring(0, 1) == "A" || isim[i].Substring(0, 1) == "a")
                {
                    x++;
                }
            }
            string[] aisim = new string[x];
            int y = 0;
            for (int i = 0; i < 10; i++)
            {
                if (isim[i].Substring(0, 1) == "A" || isim[i].Substring(0, 1) == "a")
                {
                    aisim[y] = isim[i];
                    listBox2.Items.Add(aisim[y]);
                    y++;
                }
            }
        }
    }
}
