using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MesajKutuları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz", "FORM'a Giriş");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a;
            a = MessageBox.Show("Çıkmak İstediğinize Emin misiniz?", "UYARI!",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button3);
            if (a == DialogResult.Yes)
            {
                Close();  
            }
            else if (a == DialogResult.No)
            {
                MessageBox.Show("FORM'a Dönülüyor..", "UYARI!");
            }
        }
    }
}
