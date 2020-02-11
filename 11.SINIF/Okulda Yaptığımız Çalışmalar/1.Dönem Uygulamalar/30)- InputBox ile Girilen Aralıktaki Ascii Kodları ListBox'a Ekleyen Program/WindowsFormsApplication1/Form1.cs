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
        int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            x = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Başlangıç Değeri Girin:"));
            y = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Bitiş Değeri Girin:"));

            for (int i = x; i <= y; i++)
            {
                listBox1.Items.Add(i + "=" + ((char)i).ToString());
            }
        }
    }
}
