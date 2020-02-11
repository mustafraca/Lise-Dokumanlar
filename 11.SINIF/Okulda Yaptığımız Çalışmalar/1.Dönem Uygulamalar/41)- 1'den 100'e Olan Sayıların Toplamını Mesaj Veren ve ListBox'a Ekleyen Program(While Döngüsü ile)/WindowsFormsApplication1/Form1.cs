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

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0; int sayac = 0;

            while (sayac <= 100)
            {
                listBox1.Items.Add(sayac);
                sayac++;
                toplam += sayac;
            } 
            listBox1.Items.Add("SAYILARIN TOPLAMI: " + toplam);
            MessageBox.Show("SAYILARIN TOPLAMI: " + toplam);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
