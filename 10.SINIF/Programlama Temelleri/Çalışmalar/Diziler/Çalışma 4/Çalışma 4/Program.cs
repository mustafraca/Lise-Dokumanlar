using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Çalışma_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 12 Elemanlı bir aylar dizisi tanımlayınız ve dizinin elemanlarını sabit olarak diziye atayınız. Klavyeden girilen sayının
            // karşıtı olan ayı ekrana yazan program.

            string[] aylar = new string[12] { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };

            Console.Write("Bir Sayı Giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 12; i++)
            {
                if (i == sayi - 1)
                { 
                    Console.Write("{0}. Ay --> {1}", i + 1, aylar[i]); 
                }
            } Console.ReadKey();
        }
    }
}
