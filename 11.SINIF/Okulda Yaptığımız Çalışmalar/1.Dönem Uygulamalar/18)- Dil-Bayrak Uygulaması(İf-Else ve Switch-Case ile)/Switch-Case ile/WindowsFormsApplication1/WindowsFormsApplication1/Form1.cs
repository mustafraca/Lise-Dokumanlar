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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0: label2.Text = "İNGİLİZCE"; pictureBox1.Image = Image.FromFile(@"C:\Mustafa Acar 392\Bayrak iconları\FLGUSA02.ico"); label3.Text = "HELLO"; break;
                case 1: label2.Text = "ALMANCA"; pictureBox1.Image = Image.FromFile(@"C:\Mustafa Acar 392\Bayrak iconları\FLGGERM.ico"); label3.Text = "WILLKOMMEN"; break;
                case 2: label2.Text = "FRANSIZCA"; pictureBox1.Image = Image.FromFile(@"C:\Mustafa Acar 392\Bayrak iconları\FLGFRAN.ico"); label3.Text = "SALUT"; break;
                case 3: label2.Text = "İSPANYOLCA"; pictureBox1.Image = Image.FromFile(@"C:\Mustafa Acar 392\Bayrak iconları\FLGSPAIN.ico"); label3.Text = "BIENVENIDOS"; break;
                case 4: label2.Text = "İTALYANCA"; pictureBox1.Image = Image.FromFile(@"C:\Mustafa Acar 392\Bayrak iconları\FLGITALY.ico"); label3.Text = "BENVENUTI"; break;
                case 5: label2.Text = "RUSÇA"; pictureBox1.Image = Image.FromFile(@"C:\Mustafa Acar 392\Bayrak iconları\FLGRUS.ico"); label3.Text = "DOBRO"; break;
                case 6: label2.Text = "ARAPÇA"; pictureBox1.Image = Image.FromFile(@"C:\Mustafa Acar 392\Bayrak iconları\FLGSKOR.ico"); label3.Text = "MERHABA"; break;


            }

        }
    }
}
