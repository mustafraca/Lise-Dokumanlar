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
            // 100 den 0 Kadar Sayıları Ekrana Yazan Program.
            int x;
            for (x = 100; x >= 0; x--)
            {
                Console.Write("{0} ",x);
            }
            Console.ReadKey();
        }
    }
}
