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
        int gsayi, faktoriyel;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gsayi = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Sayı Giriniz:"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            faktoriyel = 1;

            for (int i = 1; i <= gsayi; i++)
            {
                faktoriyel *=i;
            } MessageBox.Show("  " + faktoriyel.ToString(), "Girdiğiniz Sayının Faktoriyeli");
        }
    }
}
