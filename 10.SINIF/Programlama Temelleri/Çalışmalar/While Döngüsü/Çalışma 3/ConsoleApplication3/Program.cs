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
            // Klavyeden girilen N değeri 1 tam sayı olmak üzere 1 ile N arasındaki 3'e ve 7'ye tam
            // bölünebilen sayıları ekrana yazdıran program.

            Console.Write("N Değerini Giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.Write("{0}, ",i);
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
