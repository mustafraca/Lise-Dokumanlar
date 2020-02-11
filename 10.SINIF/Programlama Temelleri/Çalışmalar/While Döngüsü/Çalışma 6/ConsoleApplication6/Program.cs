using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 ile 20 arasında rastgele üretilen bir sayıyı kullanıcıya 5 defada tahmin ettiren program.
            int i = 5;
            Random x = new Random();
            int tahmin = x.Next(1, 20);
            while (1 <= i)
            {
                Console.Write("Tahmininizi Giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == tahmin)
                {
                    Console.Write("Tebrikler Doğru Tahmin Ettiniz"); break;
                }
                else
                {
                    if (sayi < tahmin)
                    {
                        Console.WriteLine("Sayıyı Yükselt");
                    }
                    else
                    {
                        Console.WriteLine("Sayıyı Azalt");
                    }
                }
                i--;
                Console.WriteLine("Kalan Hak: "+i);
                if (i == 0)
                {
                    Console.Write("Tahmin Hakkınız Bitmiştir. Üretilen Sayı: " + tahmin);
                }
            }
            Console.ReadKey();
        }
    }
}
