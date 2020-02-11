using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] ad = new string[3];
        string[] soyad = new string[3];
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                ad[i] = (Microsoft.VisualBasic.Interaction.InputBox("Ad Girin:"));
                soyad[i] = (Microsoft.VisualBasic.Interaction.InputBox("Soyad Girin:"));
                listBox1.Items.Add(ad[i]);
                listBox2.Items.Add(soyad[i]);
                listBox3.Items.Add(string.Concat(ad[i] , " " , soyad[i]));
            }
        }
    }
}
