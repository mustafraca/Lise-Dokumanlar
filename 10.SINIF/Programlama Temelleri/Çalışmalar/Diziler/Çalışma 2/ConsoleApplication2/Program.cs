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
            //10 elemanlı bir tam sayı dizisi tanımlayınız. Dizinin elemaları rasgele üretilen 3 basamaklı sayılar olsun. Dizide bulunan ÇİFT sayıları ekrana yazan program.

            int[] dizi = new int[10];

            Random rasgele = new Random();

            for (int i = 0; i < 10; i++)
            {
                dizi[i] = rasgele.Next(100, 999);
                Console.Write("{0}, ", dizi[i]);
            }
            Console.WriteLine("\n\nÇift Olan Sayılar: ");

            for (int i = 0; i < 10; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    Console.WriteLine(dizi[i]);
                }
            }
            Console.ReadKey();

            //veya
            //int[] dizi = new int[10];
            //Random rastgele = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    dizi[i] = rastgele.Next(100, 999);
                
            //    if (dizi[i] % 2 == 0)
            //    {
            //        Console.WriteLine(dizi[i]);
            //    }
            //}
            //Console.ReadKey();
        }
    }
}
