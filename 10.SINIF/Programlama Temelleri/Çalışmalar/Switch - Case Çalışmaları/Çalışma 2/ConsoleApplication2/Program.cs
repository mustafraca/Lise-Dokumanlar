using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden seçilen üçgen,kare veya dikdörtgenin alanını ve çevresini hesaplayan program.
            Console.WriteLine("1--Üçgen\n2--Kare\n3--Dikdörtgen");
            int x;
            Console.Write("Yukarıdaki çokgenlerden hangisiyle işlem yapmak istiyorsunuz: ");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    int a, b, c, d;
                    Console.Write("Tabanı Giriniz: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("1. Kenarı Giriniz: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. Kenarı Giriniz: ");
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Yüksekliği Giriniz: ");
                    d = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Üçgenin Çevresi: {0}", a + b + c);
                    Console.Write("Üçgenin Alanı: {0}", (a * d) / 2);
                    break;
                case 2:
                    int e;
                    Console.Write("Bir Kenarı Giriniz: ");
                    e = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Karenin Çevresi: {0}",e*4);
                    Console.Write("Karenin Alanı: {0}",e*e);
                    break;
                case 3:
                    int z, y;
                    Console.Write("Uzun Kenarı Giriniz: ");
                    z = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Kısa Kenarı Giriniz: ");
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Dikdörtgenin Çevresi: {0}",(z*2)+(y*2));
                    Console.Write("Dikdörtgenin Alanı: {0}",z*y);
                    break;
            }
            Console.ReadKey();

        }
    }
}
