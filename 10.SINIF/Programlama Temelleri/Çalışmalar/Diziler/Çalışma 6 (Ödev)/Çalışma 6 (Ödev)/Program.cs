using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Çalışma_6__Ödev_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 20 Kişilik bir sınıftaki öğrenci adlarını tutabilecek bir dizi tanımlayınız.
            // Klavyeden girilen isimleri tanımladığınız bu diziye atayınız.

            string[] sınıf = new string[20];

            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}. İsmi Giriniz: ", i + 1);
                sınıf[i] = Console.ReadLine();
            } Console.Clear();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}", sınıf[i]);
            } Console.ReadKey();
        }
    }
}
