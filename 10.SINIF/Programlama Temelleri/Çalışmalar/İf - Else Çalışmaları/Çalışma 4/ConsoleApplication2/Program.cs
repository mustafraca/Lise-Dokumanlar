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
            // Trafik ışığının rengi klavyeden girildiğinde geç,dur, bekle yazan program.
            string x;
            Console.Write("Isık Rengini Giriniz: ");
            x = Console.ReadLine();

            if (x == "kırmızı")

                Console.Write("Dur");

            else if (x == "sarı")

                Console.Write("Bekle");

            else if (x == "yeşil")

                Console.Write("Geç");

            Console.ReadLine();


        }
    }
}
