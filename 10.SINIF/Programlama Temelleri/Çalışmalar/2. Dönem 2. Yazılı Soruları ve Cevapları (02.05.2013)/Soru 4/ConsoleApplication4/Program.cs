using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden Girilen 3 Sayıdan En Büyüğü ve En Küçüğünü Ekrana Yazdıran Program.
            Console.Write("Birinci Sayıyı Giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçüncü Sayıyı Giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                Console.WriteLine("En Büyük Sayı: " + sayi1);
            }
            else if (sayi2 > sayi3 && sayi2 > sayi1)
            {
                Console.WriteLine("En Büyük Sayı: " + sayi2);
            }
            else
            {
                Console.WriteLine("En Büyük Sayı: " + sayi3);
            }
            if (sayi1 < sayi2 && sayi1 < sayi3)
            {
                Console.Write("En Küçük Sayı: " + sayi1);
            }
            else if (sayi2 < sayi3 && sayi2 < sayi1)
            {
                Console.Write("En Küçük Sayı: " + sayi2);
            }
            else
            {
                Console.Write("En Küçük Sayı: " + sayi3);
            }
            Console.ReadKey();
        }
    }
}
