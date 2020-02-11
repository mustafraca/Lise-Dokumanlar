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
        double toplam, payda, pay;
        private void button1_Click(object sender, EventArgs e)
        {
            toplam = 0; payda = 1; pay = 1;
            int n = Convert.ToInt16(textBox1.Text);
            int x = 1;
            while (payda <= n)
            {
                if (x % 2 == 0)
                {
                    toplam -= pay / payda;
                    payda += 2;
                }
                else
                {
                    toplam += pay / payda;
                    payda += 2;
                }
                x++;   
            } MessageBox.Show("Toplam: " + toplam);
        }
    }
}
