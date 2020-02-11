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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toplam = 0; double payda = 1; double pay = 1;

            for (int i = 0; i < 50; i++)
            {
                toplam += pay / payda;
                payda++;
                
            }
            
            MessageBox.Show("Sonuç: " + toplam);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.Show(); this.Hide();
        }
    }
}
