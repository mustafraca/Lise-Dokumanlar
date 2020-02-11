using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        string adres,sehir;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
            label1.Text = string.Concat(textBox1.Text, " ", textBox2.Text);
            

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            adres = textBox1.Text;
            if (adres.EndsWith("."))
            {
                MessageBox.Show("Adres Bloğu Doğru Tanımlanmıştır.");
            }
            else
            {
                MessageBox.Show("Adres Bloğunun Sonuna Nokta Karakterini Ekleyiniz. ");
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.Substring(2, 4).ToString();
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sehir = textBox1.Text;
            label1.Text = textBox1.Text.ToUpper();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sehir = textBox1.Text;
            label1.Text = textBox1.Text.ToLower();
           
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.Replace("ç", "ch");
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.Remove(1);
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.Insert(3, "FTW");
           
        }

     private void button9_Click(object sender, EventArgs e)
     {
     label1.Text = textBox1.Text.TrimStart();
    
     }

     private void button10_Click(object sender, EventArgs e)
     {
     label1.Text = textBox1.Text.TrimEnd();
     
     }

     private void button11_Click(object sender, EventArgs e)
     {
         textBox1.Text = "";
         textBox2.Text = "";
         label3.Text = "label3";
         label1.Text = "label1";
     }

     private void button12_Click(object sender, EventArgs e)
     {
         MessageBox.Show("İki TextBox'ı birleştirir ve aralarına boşluk ekler.");
     }

     private void button13_Click(object sender, EventArgs e)
     {
         MessageBox.Show("Adres bloğunun sonunda '.' karakteri olup olmadığını kontrol eder.");
     }

     private void button15_Click(object sender, EventArgs e)
     {
         MessageBox.Show("TextBox1'deki yazılan değerdeki karakterlerin hepsini büyüğe çevirir.");
     }

     private void button14_Click(object sender, EventArgs e)
     {
         MessageBox.Show("TextBox1'deki yazılan değerin 2.karakterinden itibaren 4 karakteri tutar.");
     }

     private void button16_Click(object sender, EventArgs e)
     {
         MessageBox.Show("TextBox1'deki yazılan değerdeki karakterlerin hepsini küçüğe çevirir.");
     }

     private void button21_Click(object sender, EventArgs e)
     {
         MessageBox.Show("TextBox1'deki yazılan değerin sonunda boşluk varsa bu boşlukları atmak için kullanılır.");
     }

     private void button20_Click(object sender, EventArgs e)
     {
         MessageBox.Show("TextBox1'deki yazılan değerin başında boşluk varsa bu boşlukları atmak için kullanılır.");
     }

     private void button19_Click(object sender, EventArgs e)
     {
         MessageBox.Show("TextBox1'deki yazılan değerin 3.karakterinden itibaren araya 'FTW' kelimesini ekler.");
     }

     private void button18_Click(object sender, EventArgs e)
     {
         MessageBox.Show("TextBox1'deki yazılan değerin 1. karakterine kadar tüm karakterleri siler.");
     }

     private void button17_Click(object sender, EventArgs e)
     {
         MessageBox.Show("TextBox1'deki yazılan değerdeki 'ç' karakterlerini 'ch' olarak değiştirir.");
     }
    }
}
