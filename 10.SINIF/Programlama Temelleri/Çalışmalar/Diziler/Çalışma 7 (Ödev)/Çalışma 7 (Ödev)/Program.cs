using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Çalışma_7__Ödev_
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] sayilar = {4,5,-15,22,-34,3,0,7,43,100}; Yanda verilen diziyi tanımlayınız.

            int[] sayilar = {4,5,-15,22,-34,3,0,7,43,100};
            // 1. Sayilar dizisi içerisindeki 3'e bölünebilen değerleri ekrana yazdırınız.
            Console.Write("Sayilar Dizisi İçerisindeki 3'e Bölünebilen Değerler: ");
            for (int i = 0; i < 10; i++)
            {
                if (sayilar[i] % 3 == 0)
                {
                    Console.Write("{0}, ",sayilar[i]);
                }
            }
            // 2. Sayilar dizisi içerisinde yer alan elemanlardan kaç tanesi ÇİFT, Kaç tanesi TEK sayı olduğunu bularak ekrana yazdırınız.
            int çiftadet = 0, tekadet = 0;
            for (int i = 0; i < 10; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    çiftadet++;
                }
                else
                {
                    tekadet++;
                }
            } Console.Write("\n\nDizide Bulunan ÇİFT Sayıların Adedi: "+ çiftadet +"\nDizide Bulunan TEK Sayıların Adedi: "+ tekadet);
            // 3. Sayilar dizisi içerisindeki en büyük sayıyı bularak ekrana yazdırınız.
            int enbüyüksayi = -34;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > enbüyüksayi)
                { enbüyüksayi = sayilar[i]; }
            } Console.Write("\n\nDizide Bulunan En Büyük Sayı: " + enbüyüksayi);
            // 4. Sayilar dizisi içerisindeki en büyük negatif sayıyı bularak ekrana yazdırınız.
            int ebnegatif = 100;
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] < ebnegatif)
                { ebnegatif = sayilar[i]; }
            } Console.Write("\n\nDizide Bulunan En Büyük Negatif Sayı: " + ebnegatif);
            // 5. Sayilar dizisi elemanlarını küçükten büyüğe doğru sıralayarak oluşan yeni sıralamayı ekrana yazdırınız.
            int depo = 0; Console.Write("\n\nDizideki Bulunan Sayıların Küçükten Büyüğe Sıralanaşı: ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (sayilar[j] < sayilar[i])
                    { depo = sayilar[j]; sayilar[j] = sayilar[i]; sayilar[i] = depo; }

                }
            }
            for (int i = 0; i < 10; i++)
            { Console.Write("{0}, ",sayilar[i]); } Console.ReadKey();   
        }
    }
}
