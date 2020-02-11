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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {byte sayi = 19; label3.Text = Convert.ToString(sayi);}

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {sbyte sayi = -99; label3.Text = Convert.ToString(sayi);}

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {short sayi = -30000; label3.Text = Convert.ToString(sayi);}

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {ushort sayi = 65000; label3.Text = Convert.ToString(sayi);}

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {int sayi = -5666230; label3.Text = Convert.ToString(sayi);}

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {uint sayi = 655444565; label3.Text = Convert.ToString(sayi);}

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {long sayi = -123655989657898; label3.Text = Convert.ToString(sayi);}

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {ulong sayi = 12365597219; label3.Text = Convert.ToString(sayi);}

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {float sayi = -1237462; label3.Text = Convert.ToString(sayi);}

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {double sayi = 1239478.5567; label3.Text = Convert.ToString(sayi);}

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {decimal sayi = -12365598962; label3.Text = Convert.ToString(sayi);}

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {string deger = "MustafaAcar"; label3.Text = deger;}

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {char deger = 'M'; label3.Text = Convert.ToString(deger);}

        
    }
}
