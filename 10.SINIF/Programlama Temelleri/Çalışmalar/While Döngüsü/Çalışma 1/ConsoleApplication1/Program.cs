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
            // 0 ile 100 arasındaki 5 ve 5'in katı olan sayıları ekrana while döngüsü ile yazan program.

            int i = 0;

            while (i <= 100)
            {
                Console.Write("{0}\n",i);
                i += 5;
            }
            Console.ReadKey();
        }
    }
}
