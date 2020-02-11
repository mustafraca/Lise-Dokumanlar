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
      // Klavyeden Girilen N Değerini Kadar 1..N Arasındaki 3'e ve 5'e Tam Bölünebilen Sayıları ve
      // Sayıların Küplerini Ekrana Yazan Program.
      int i = 1;
      Console.Write("Bitiş Değerini Giriniz: ");
      int bitis = Convert.ToInt32(Console.ReadLine());
      do
      {
          if (i % 3 == 0 && i % 5 == 0)
          {
              Console.WriteLine("Sayı: {0} Kübü: {1}", i, Math.Pow(i, 3));
          }
      i++;
      }
      while (i <= bitis);
      Console.ReadKey();
  }
 }
}
