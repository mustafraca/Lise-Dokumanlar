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
            // klavyeden girilen iki sayı arasında seçilen işleme göre gereken hesaplamayı yapan program
            string seçim;
            int sayı1, sayı2, sonuç;

            Console.WriteLine("1. Toplama: +");
            Console.WriteLine("2. Çıkarma: -");
            Console.WriteLine("3. Çarpma: *");
            Console.WriteLine("4. Bölme: /");
            Console.Write("İşleminizi Seçiniz: ");
            seçim = Convert.ToString(Console.ReadLine());

            if (seçim == "+")
            {
                Console.Write("1.Sayıyı Giriniz: ");
            sayı1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2.Sayıyı Giriniz: ");
                    sayı2 = Convert.ToInt32(Console.ReadLine());
            sonuç = sayı1+sayı2;
                    Console.Write("Sonuç: {0}",sonuç);
            }
            else if (seçim=="-")
            {
                    Console.Write("1.Sayıyı Giriniz: ");
            sayı1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2.Sayıyı Giriniz: ");
                    sayı2 = Convert.ToInt32(Console.ReadLine());
            sonuç = sayı1-sayı2;
                    Console.Write("Sonuç: {0}",sonuç);
            }
            else if (seçim =="*")
            {
                Console.Write("1.Sayıyı Giriniz: ");
                sayı1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Sayıyı Giriniz: ");
                sayı2 = Convert.ToInt32(Console.ReadLine());
                sonuç = sayı1 * sayı2;
                Console.Write("Sonuç: {0}", sonuç);
            }
            else if (seçim =="/")
            {
                Console.Write("1.Sayıyı Giriniz: ");
                sayı1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Sayıyı Giriniz: ");
                sayı2 = Convert.ToInt32(Console.ReadLine());
                sonuç = sayı1 / sayı2;
                Console.Write("Sonuç: {0}", sonuç);
            }
            Console.ReadKey();






        }
    }
}
