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
        bool yon = false;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled =! timer1.Enabled;
            if (timer1.Enabled == true)
            {
                button1.Text = "Durdur";
            }
            else
            {
                button1.Text = "Başlat";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int deger = progressBar1.Value;
            
            if (yon == false)
            {
                if (deger >= 100)
                {
                    yon = true;
                }
                else
                {
                    deger++;
                    progressBar1.Value = deger;
                }
            }
            else
            {
                if (deger <=0)
                {
                    yon = false;
                }
                else
                {
                    deger--;
                    progressBar1.Value = deger; this.Opacity += 1;
                }
            }
            label1.Text = "%" + deger.ToString() + " Gönderildi";
        }
    }
}
