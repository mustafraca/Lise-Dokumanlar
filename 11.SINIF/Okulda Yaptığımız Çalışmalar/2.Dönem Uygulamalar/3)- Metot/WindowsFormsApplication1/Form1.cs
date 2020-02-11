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
        
        private void yazdır(string[] deger)
        {
            foreach (string yaz in deger)
            {
                listBox1.Items.Add(yaz);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] ekle = new string[4] {"İSTANBUL", "ANKARA", "KOCAELİ", "BURSA"};
            {
                yazdır(ekle);
            }

        }
        // VEYA
        //private void yazdır(string[] deger)
        //{
        //    listBox1.Items.AddRange(deger); TÜM DİZİ EKLER
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string[] ekle = new string[4] { "İSTANBUL", "ANKARA", "KOCAELİ", "BURSA" };
        //    {
        //        yazdır(ekle);
        //    }

        //}
        }
}

