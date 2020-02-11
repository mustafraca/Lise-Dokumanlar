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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == "İNGİLİZCE")
            {
                label2.Text = "İNGİLİZCE"; pictureBox1.Image = Image.FromFile(@"C:\Mustafa Acar 392\Bayrak iconları\FLGUSA02.ico"); label3.Text = "HELLO";
            }
            else if (listBox1.SelectedItem == "ALMANCA")
            {
                label2.Text = "ALMANCA"; pictureBox1.Image = Image.FromFile(@"C:\Mustafa Acar 392\Bayrak iconları\FLGGERM.ico"); label3.Text = "WILLKOMMEN";
            }
            else if (listBox1.SelectedItem == "FRANSIZCA")
            {
                label2.Text = "FRANSIZCA"; pictureBox1.Image = Image.FromFile(@"C:\Mustafa Acar 392\Bayrak iconları\FLGFRAN.ico"); label3.Text = "SALUT";
            }
            else if (listBox1.SelectedItem == "İSPANYOLCA")
            {
                label2.Text = "İSPANYOLCA"; pictureBox1.Image = Image.FromFile(@"C:\Mustafa Acar 392\Bayrak iconları\FLGSPAIN.ico"); label3.Text = "BIENVENIDOS";
            }
            else if (listBox1.SelectedItem == "İTALYANCA")
            {
                label2.Text = "İTALYANCA"; pictureBox1.Image = Image.FromFile(@"C:\Mustafa Acar 392\Bayrak iconları\FLGITALY.ico"); label3.Text = "BENVENUTI";
            }
            else if (listBox1.SelectedItem == "RUSÇA")
            {
                label2.Text = "RUSÇA"; pictureBox1.Image = Image.FromFile(@"C:\Mustafa Acar 392\Bayrak iconları\FLGRUS.ico"); label3.Text = "DOBRO";
            }
            else if (listBox1.SelectedItem == "ARAPÇA")
            {
                label2.Text = "ARAPÇA"; pictureBox1.Image = Image.FromFile(@"C:\Mustafa Acar 392\Bayrak iconları\FLGSKOR.ico"); label3.Text = "MERHABA";
            }
        }
    }
}
