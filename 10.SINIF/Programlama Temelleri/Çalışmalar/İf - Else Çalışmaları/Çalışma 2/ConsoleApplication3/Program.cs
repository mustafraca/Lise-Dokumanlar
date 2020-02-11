using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden Girilen Not Ortalamasına Göre Öğrencinin Geçme Kalma Durumu.
            int ort;
            Console.Write("Not Ortalamanızı Giriniz: ");
            ort = Convert.ToInt32(Console.ReadLine());

            if (ort >= 45)
            {
                Console.WriteLine("Tebrikler Geçtiniz");
            }
            else
            {
                Console.WriteLine("Maalesef Geçemediniz");
                
            }
            Console.ReadKey();
        }
    }
}
