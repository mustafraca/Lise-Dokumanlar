using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Çalışma_9__Ödev_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen 10 adet sayıyı bir diziye kopyalayın.

            int[] sayilar = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Bir Sayı Giriniz: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Bu sayıların toplamını ve ortalamasını ekrana yazdırın.
            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                toplam += sayilar[i];
            } Console.WriteLine("\nDizideki Sayıların Toplamı: "+ toplam +"\nDizideki Sayıların Ortalaması: "+ toplam / 10);

            // 100'den Büyük sayıları ekrana yazdırın.
            Console.Write("\n\nDizideki 100'den Büyük Sayılar: ");
            for (int i = 0; i < 10; i++)
            {
                if (sayilar[i] > 100) { Console.Write("{0}, ", sayilar[i]); }
            }

            // Dizideki 100'den küçük sayıların adedi ekrana yazdırın.
            int adet = 0;
            for (int i = 0; i < 10; i++)
            {
                if (sayilar[i] < 100) { adet++; }
            } Console.WriteLine("\n\nDizideki 100'den Küçük Sayıların Adedi: "+ adet);

            // Dizideki en büyük ve en küçük sayıyı bulup ekrana yazdırın.
            int ebnegatif = 100, enbüyük = -34;
            for (int i = 0; i < 10; i++)
            {
                if (sayilar[i] < ebnegatif)
                { ebnegatif = sayilar[i]; }
                if (sayilar[i] > enbüyük)
                {
                    enbüyük = sayilar[i];
                }
            } Console.Write("\n\nDizideki En Küçük Sayı: "+ ebnegatif +"\nDizideki En Büyük Sayı: "+enbüyük);

            // Dizideki sayıları büyükten - küçüğe sıralayınız.
            int depo = 0; Console.Write("\n\nDizideki Bulunan Sayıların Büyükten Küçüğe Sıralanaşı: ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (sayilar[j] > sayilar[i])
                    { depo = sayilar[j]; sayilar[j] = sayilar[i]; sayilar[i] = depo; }

                }
            }
            for (int i = 0; i < 10; i++)
            { Console.Write("{0}, ", sayilar[i]); } 

            // Dizideki sayıları küçüğe - büyükten sıralayınız.
            int depo2 = 0; Console.Write("\n\nDizideki Bulunan Sayıların Küçükten Büyüğe Sıralanaşı: ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (sayilar[j] < sayilar[i])
                    { depo2 = sayilar[j]; sayilar[j] = sayilar[i]; sayilar[i] = depo2; }

                }
            }
            for (int i = 0; i < 10; i++)
            { Console.Write("{0}, ", sayilar[i]); } 

            // Klavyeden girilen sayıyı bu dizide arayan( bulursa "Vardır/Yoktur") mesajını veren program.
            Console.Write("\n\nAratacağınız Sayıyı Girin: ");
            int aranacaksayi = Convert.ToInt32(Console.ReadLine());
            bool x = false;
            for (int i = 0; i < 10; i++)
            { if (sayilar[i] == aranacaksayi) { x = true; } }
            if (x == true) { Console.Write("\nAradığınız Sayı Dizide Bulunmakta."); }
            else { Console.Write("\nAradığınız Sayı Dizide Bulunmamaktadır."); }
            
            // Klavyeden girilen sayıyı dizide arayan ve kaç adet olduğunu bulan program.
            int adet2 = 0;
            Console.Write("\n\nAradığınız Sayıyı Girin: ");
            int aranacaksayi2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            { if (aranacaksayi2 == sayilar[i]) { adet2++; } } Console.Write("\nDizide Arattırdığınız Sayının Adedi: "+ adet2); 

            // Her elemanın karesini alarak b dizisine aktaran, her elemanın kare kökünü alarak c dizisine aktaran, b ve c dizilerinin toplamını
            // d dizisini ekranda gösteren cosole uygulaması.
            int[] b = new int[10];
            for (int i = 0; i < 10; i++)
            { b[i] = sayilar[i] * sayilar[i]; }
            double[] c = new double[10]; double karekok = 0;
            for (int i = 0; i < 10; i++)
            { karekok = Math.Sqrt(sayilar[i]); c[i] = karekok; }
            double[] d = new double[10]; double bctoplam = 0;
            for (int i = 0; i < 10; i++)
            { bctoplam = b[i] + c[i]; }
            Console.Write("\n\nB ve C Dizilerinin Toplamı: "+ bctoplam);
            Console.ReadKey();
        }
    }
}
