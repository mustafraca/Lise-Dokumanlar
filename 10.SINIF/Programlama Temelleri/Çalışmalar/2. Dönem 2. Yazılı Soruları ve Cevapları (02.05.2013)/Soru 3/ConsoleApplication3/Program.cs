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
            int i = 100;
            while (i < 1000)
            {
                int y = i / 100;
                int o = (i % 100) / 10;
                int b = (i % 100) % 10;

                int top = ((y * y) * y) + ((o * o) * o) + ((b * b) * b);

                if (i == top)
                {
                    Console.Write("{0}, ", i);
                }
                i += 1;
            }
            Console.ReadKey();


        }
    }
}
