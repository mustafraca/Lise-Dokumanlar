using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char e = 'e';
            int puan = 0;
            int dc = 0, yc = 0;

            Random x = new Random();
            int sayi1 = x.Next(1, 100);
            Random y = new Random();
            int sayi2 = y.Next(1, 100);

            while (e == 'e' || e == 'E')
            {                               
                Console.WriteLine("1.Tutulan Sayı: " + sayi1 + " 2.Tutulan Sayı: " + sayi2);
                Console.Write("Bu Sayıların Toplamı Kaçtır: ");
                int g = Convert.ToInt32(Console.ReadLine());

                if (g == sayi1 + sayi2)
                {
                    Console.WriteLine("Tebrikler Doğru Bildiniz.");
                    puan += 5;
                    dc += 1;
                }
                else
                {
                    Console.WriteLine("Üzgünüm Bilemediniz.");
                    puan -= 2;
                    yc += 1;
                }
                Console.WriteLine("Toplam Puan: " + puan);
                Console.Write("Tekrar Oynamak İstiyormusunuz(e/E)?");
                e = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Doğru Cevap Sayısı: " + dc);
            Console.Write("Yanlış Cevap Sayısı: " + yc);
            Console.ReadKey();

        }
    }
}
