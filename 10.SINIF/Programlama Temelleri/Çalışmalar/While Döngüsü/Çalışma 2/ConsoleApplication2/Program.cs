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
            // Klavyeden girilen 5 adet tam sayının tek mi çift mi olduğunu ekrana yazan program.

            int i = 0;

            while (i < 5)
            {
                Console.Write("Bir Sayı Giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Girilen Sayı Çift");
                }
                else
                {
                    Console.WriteLine("Girilen Sayı Tek");
                }
                i += 1;
            }
            Console.ReadKey();
        }
    }
}
