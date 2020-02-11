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
            // Bir işyeri çalışanlarına maaşları dışında prim dağıtmaktadır.Prim hesabını aşağıdaki tabloya göre yapıldığı varsayılarak
            // kullanıcıya aldığı maaş ve ürettiği ürünmiktarını sorup alacağı toplam ücreti hesaplayan program
            int x, y;
            Console.Write("Maaşınızı Giriniz: ");
            x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Parça Sayısını Giriniz: ");
            y = Convert.ToInt16(Console.ReadLine());

            if (y <= 10)
                Console.Write("Toplam maaşınız: {0}", x + (y * 5));
            else if (y <= 25)
                Console.Write("Toplam maaşınız: {0}", x + (y * 11));
            else if (y <= 40)
                Console.Write("Toplam maaşınız: {0}", x + (y * 17));
            else if (y >= 41)
                Console.Write("Toplam maaşınız: {0}", x + (y * 30));

            Console.ReadKey();
        }
    }
}
