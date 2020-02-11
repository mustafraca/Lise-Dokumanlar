using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Çalışma_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir dizi tanımlayınız. Klavyeden girilen n değeri kadar tanımladığınız dizinin elemanı olsun. N değeri kadar 
            // klavyeden girilen bilgileri temizleyip tekrar ekrana bilgileri yazan program.

            Console.Write("N değeri : ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] liste = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Bilgi Giriniz : ");
                liste[i] = Console.ReadLine();
            } Console.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(liste[i]);
            }
            Console.ReadKey();

            
            
        }
    }
}
