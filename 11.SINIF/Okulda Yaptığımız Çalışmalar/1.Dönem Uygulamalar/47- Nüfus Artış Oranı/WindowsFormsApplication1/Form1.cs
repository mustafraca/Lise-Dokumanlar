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
            int yil = 0;
            int x = Convert.ToInt16(textBox1.Text);
            int y = Convert.ToInt16(textBox2.Text);
            int z = Convert.ToInt16(textBox3.Text);
            while (x < y)
            {
                x += (x / 100) * z;
                yil++;
            } MessageBox.Show("Hedeflenen Nüfus " + yil + " Yıl İçerisinde Olacak.");
        }
    }
}
