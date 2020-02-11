using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 den 100 e Kadar Sayıları Yazan Program.
            byte i;
            for (i = 1; i <= 100; i++)
            {

                Console.Write(i);
            }
            Console.ReadKey();
        }
    }
}
