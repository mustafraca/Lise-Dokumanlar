using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hipotenüs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int hipotenus(double x, double y)
        {
            double sonuc;
            sonuc = Math.Sqrt((x * x) + (y * y));
            return Convert.ToInt32(sonuc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ilk, son;
            ilk = Convert.ToDouble(textBox1.Text);
            son = Convert.ToDouble(textBox2.Text);

            MessageBox.Show(hipotenus(ilk, son).ToString());
        }
    }
}
