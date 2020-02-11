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
            double alan;
            alan = Convert.ToInt16(textBox1.Text) * (Math.PI * Convert.ToInt16(textBox1.Text));
            MessageBox.Show("Alan: " + alan,"SONUÇ");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matematikteki pi sayısını ifade eder. Bu fonksiyon değildir. Parametre içermez. Değeri yaklaşık ‘22/7’dir. Math.PI şeklinde kullanılır.", "BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matematikteki E sayısını ifade eder. Buda pi gibi parametre içermez. Yaklaşık değeri ‘2.71’dir. Math.E şeklinde kullanılır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double hesap = Math.E * Convert.ToInt16(textBox2.Text);
            MessageBox.Show("Sonuç: "+hesap,"SONUÇ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parametre olarak girilen değişkeni veya sayıyı E’nin kuvveti olarak hesaplar. Math.Exp(Değer) şeklinde kullanılır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            int deger = Convert.ToInt16(textBox3.Text);
            double sonuc;
            sonuc = Math.Exp(deger);
            MessageBox.Show(""+sonuc);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Round metodu sayıyı en yakın tam sayıya yuvarlatır. Yani 5.2 sayısını 5, 5.7 sayısını 6 olarak yuvarlatır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            decimal x = Convert.ToDecimal(textBox4.Text);
            MessageBox.Show("Sonuç: " + Math.Round(x), "SONUÇ");
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sayının virgülden sonrasının atılmasını sağlar.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            decimal x = Convert.ToDecimal(textBox5.Text);
            MessageBox.Show("Sonuç: " + Math.Truncate(x),"SONUÇ");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int s;
            int x = Convert.ToInt16(textBox6.Text);
            int y = Convert.ToInt16(textBox11.Text);
           // MessageBox.Show(Math.DivRem(11, 5, out s).ToString());
            MessageBox.Show(Math.DivRem(x, y, out s).ToString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.Acos(Convert.ToDouble(textBox7.Text)).ToString());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sayının ters kosinüsünü hesaplar. Sayı -1 ile +1 arasında olmalıdır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cos fonksiyonu verilen derecenin kosinüsünü hesaplar.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox9.Text);

            MessageBox.Show("Sonuç: " + Math.Cos(Math.PI * x / 180), "SONUÇ");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tan sayının tanjantını hesaplar.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sin sayının sinüsünü hesaplar.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox10.Text);
            MessageBox.Show("Sonuç: "+ Math.Sin(Math.PI * x / 180), "SONUÇ");

        }

        private void button15_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox8.Text);
            MessageBox.Show("Sonuç: " + Math.Tan(Math.PI * x / 180), "SONUÇ");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Verilen iki değeri böler ve geriye bölüm değerini döndürür.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
