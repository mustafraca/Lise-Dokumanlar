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
            // Elde edilen yıllık gelire göre ödenecek vergiyi hesaplayan bir programı yazınız.
            // Aşağıdaki vergi oranları uygulanacaktır.
            // İlk 10.000 TL İçin %2
            // İkinci 10.000 TL İçin %7
            // Üçüncü 10.000 TL İçin %15
            // Geri Kalan İçin %20
            // Program girdi olarak yıllık geliri isteyecek ona göre vergiyi hesaplayacaktır.
            
            Console.Write("Elde Ettiğiniz Yıllık Geliri Giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x <=10000)
                Console.Write("Alınacak Vergi: {0}", (x/100) * 2);
            else if (x <= 20000)
                Console.WriteLine("Alınacak Vergi: {0}", ((x-10000)/100) * 7 + 200);
            else if (x <=30000)
                Console.WriteLine("Alınacak Vergi: {0}", ((x-20000)/100) * 15 +200+700);
            else if (x >30000)
                Console.WriteLine("Alınacak Vergi: {0}",((x-30000)/100) * 20 +200+700+1500);
            Console.ReadKey();
        }
    }
}
