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
            // Klavyeden Girilen Sayı Kadar Ekrana Fibonacci Sayı Dizisi Yazan Program.
            Console.Write("Kaç Adet Fibonacci Sayısı Görüntülensin: ");
            int adet = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;

            Console.Write(a +" "+ b + " ");
            for (int i = 3; i <= adet; i++)
            {
                int c = a + b;
                Console.Write(c + " ");

                

            }
            Console.ReadKey();
        }
    }
}
