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
        int n, m; double sonuc, j;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sonuc = 0; j = 2;

            n = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("N Değerini Giriniz:", "N Değeri"));
            m = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("M Değerini Giriniz:", "M Değeri"));
            
            for (double i = 1; i <= n; i += 2)
            {
                sonuc += i / j;
                if (j == m)
                {
                    MessageBox.Show("Sonuç: " + sonuc, "Sonuç", MessageBoxButtons.OK);
                    Close();
                }
                j += 2;
            }
            
        }
    }
}
