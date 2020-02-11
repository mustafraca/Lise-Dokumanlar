using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static int toplam(int x, int y)
        {
            int sonuc;
            sonuc = x + y;
            return sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ilk, son;
            ilk = Convert.ToInt32(textBox1.Text);
            son = Convert.ToInt32(textBox2.Text);

            MessageBox.Show(toplam(ilk, son).ToString());
        }
    }
}
