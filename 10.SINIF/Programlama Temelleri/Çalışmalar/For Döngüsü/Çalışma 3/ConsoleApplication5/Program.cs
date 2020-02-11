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
            // A Harfinden Klavyeden Girilen Harfe Kadar Yazan Program.
            Console.Write("Bitiş Harfini Giriniz: ");
            char x = Convert.ToChar(Console.ReadLine());
            char i;
            for (i = 'a'; i <= x; i++)
            {
                Console.Write("{0} ",i);
            }

            Console.ReadKey();
        }
    }
}
