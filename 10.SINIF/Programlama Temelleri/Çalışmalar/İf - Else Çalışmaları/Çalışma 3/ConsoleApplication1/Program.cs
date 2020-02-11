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
            // Klavyeden yaşı ve mezuniyet bilgisi girilen bir kişinin işe alınıp alınamayacağını 
            // lise mezunu ve 18 yaşının üzerinde olma koşuluna göre programı yazınız

            int x;
            string y;

            Console.Write("Yaşınızı Giriniz: ");
            x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Mezun Olduğunuz Kurum(Lise,Üniversite,İlkokul): ");
            y = Console.ReadLine();

            if ((x >= 18) && (y=="lise") || (y=="üniversite"))
            {
                Console.Write("`\nİşe Alındınız");
            }
            else
            {
                Console.Write("\nİşe Giremezsiniz");
            }
            Console.ReadKey();


            
        }
    }
}
