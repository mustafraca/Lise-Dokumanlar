using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MatematikselFonksiyonlar
{
    public partial class Form1 : Form
    {
        int sayi, sayi2; double yuvarla;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("1. Sayıyı Giriniz: "));
            sayi2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("2. Sayıyı Giriniz: "));
            MessageBox.Show("Sonuç: " + Math.Max(sayi, sayi2).ToString()); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("1. Sayıyı Giriniz: "));
            sayi2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("2. Sayıyı Giriniz: "));
            MessageBox.Show("Sonuç: " + Math.Min(sayi, sayi2).ToString()); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Negatif Bir Sayı Giriniz: "));
            MessageBox.Show("Sonuç: " + Math.Abs(sayi).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Bir Sayı Giriniz: "));
            MessageBox.Show("Girdiğiniz değer için: " + Math.Sign(sayi).ToString() + " üretir.");  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            yuvarla = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Virgüllü Bir Sayı Giriniz: "));
            MessageBox.Show("Sonuç: " + Math.Floor(yuvarla).ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            yuvarla = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Virgüllü Bir Sayı Giriniz: "));
            MessageBox.Show("Sonuç: " + Math.Ceiling(yuvarla).ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sayi = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Bir Sayı Giriniz: "));
            sayi2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Girdiğiniz Sayının Kaçıncı Üstünü Almak İstiyorsunuz?"));
            MessageBox.Show("Girdiğiniz Sayı-Üst Sonucu: " + Math.Pow(sayi, sayi2).ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sayi = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Bir Sayı Giriniz: "));
            MessageBox.Show("Girdiğiniz sayının karekökü: " + Math.Sqrt(sayi).ToString()); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sayi = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("1. Sayıyı Giriniz: "));
            sayi2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("2. Sayıyı Giriniz: "));
            MessageBox.Show(sayi + " tabanında " + sayi2 + " sayısının logaritması: " + Math.Log(sayi2, sayi).ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sayi = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("1. Sayıyı Giriniz: "));
            sayi2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("2. Sayıyı Giriniz: "));
            MessageBox.Show("Verdiğiniz sayıların bölümünden kalan: " + Math.IEEERemainder(sayi, sayi2).ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult x;
            x = MessageBox.Show("Çıkmak İstiyor musunuz?", "Çıkmak Üzeresiniz", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (DialogResult.Yes == x)
            {
                Close();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu fonksiyon girdiğiniz iki değerden büyük olanı verir.");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu fonksiyon girdiğiniz iki değerden küçük olanı verir.");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu fonksiyon girdiğiniz sayının mutlak değerini bulmak için kullanılır. Mutlak değer fonksiyonu negatif sayıları pozitife çevirir.");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu fonksiyon sayının işaretini bulmak için kullanılır. Negatif sayılar için “-1”, pozitif sayılar için “+1”, sıfır için ”0” değeri üretir.");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu fonksiyon sayıyı aşağı doğru yuvarlatır.");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Fonksiyon Sayıyı yukarı doğru yuvarlatır.");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sayı, üst işlemini yapmak için bu metot kullanılır. Aynı işlem sayı^üst şeklindede yapılabilir.");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bir sayının karekökünü almak için kullanılır.");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log metodu iki parametre kullanarak herhangi bir sayının logaritması herhangi bir tabana alınabilir.");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu fonksiyon verilen iki sayının bölümünden sadece kalan değeri verir.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string kayanyazi = this.Text;
            int adet = kayanyazi.Length;

            string ilkkarakter, sonrasi;
            ilkkarakter = kayanyazi.Substring(0, 1);
            sonrasi = kayanyazi.Substring(1, adet - 1);
            this.Text = sonrasi + ilkkarakter;
        }
    }
}
