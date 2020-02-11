using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen ders notunun 5 lik sisteme dönüştürme.
            int x;
            Console.Write("Notunuzu Giriniz: ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x < 25)
                Console.Write("Notunuz: 0");
            else if (x < 45)
                Console.Write("Notunuz: 1");
            else if (x < 55)
                Console.Write("Notunuz: 2");
            else if (x < 70)
                Console.Write("Notunuz: 3");
            else if (x < 85)
                Console.Write("Notunuz: 4");
            else if (x <= 100)
                Console.Write("Notunuz: 5");
            Console.ReadKey();
        }
    }
}
