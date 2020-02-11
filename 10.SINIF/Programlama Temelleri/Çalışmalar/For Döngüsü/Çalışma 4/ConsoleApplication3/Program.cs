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
            // Başlangıç ve Bitiş Değeri Klavyeden Girilen Sayıları Yazan Program.
            Console.Write("Başlangıç Değerini Giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş Değerini Giriniz: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int i;
            if (x < y)
                for (i = x; i <= y; i++)
                {

                    Console.Write("{0} ",i);
                }
            else
                for (i = y; i <= x; i++)
                {
                    Console.Write("{0} ", i);
                }


            Console.ReadKey();
        }
    }
}
