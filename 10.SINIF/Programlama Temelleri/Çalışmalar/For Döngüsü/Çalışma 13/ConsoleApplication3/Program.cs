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
            // *
            // **
            // ***
            // ****
            // *****
            // ****** --> KLAVYEDEN GİRİLEN N ADET YILDIZ.
            // *****
            // ****
            // ***
            // **
            // *

            Console.Write("N Değerini Giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                 Console.Write("*");
                Console.Write("\n");
            }
            for (int y = x - 1; y >= 1; y--)
            {
                for (int z = y; z >= 1; z--) Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
