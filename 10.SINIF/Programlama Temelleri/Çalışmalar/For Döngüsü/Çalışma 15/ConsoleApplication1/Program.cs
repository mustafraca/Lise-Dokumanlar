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
            // For Döngüsü ile Çarpım Tablosu
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} ve Katları", i);
                Console.WriteLine("---------------");
                for (int s = 1; s < 10; s++)
                {
                    Console.Write("{0}*{1}={2}\t\n", s, i, i * s);
                }
                Console.WriteLine();
            }
            Console.ReadKey();



        }
    }
}
