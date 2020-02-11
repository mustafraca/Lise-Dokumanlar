using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sayısal loto için 6 adet 0 ile 49 arasında rastgele(random) sayılar üreten program.

            int i = 1;
            Random x = new Random();
            while (i <= 6)
            {
                Console.WriteLine("{0}", x.Next(1, 49));
                i++;
            }
            Console.ReadKey();
        }
    }
}
