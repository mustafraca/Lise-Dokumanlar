using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
 class Program
 {
  static void Main(string[] args)
  {
      // Klavyeden 1 Girilene Kadar Klavyeden Girilen Sayıların Toplamını ve Sayıları Ekrana Yazan Program.
      int toplam = 0;
      int x;
      do
      {
          Console.Write("Bir Sayı Giriniz : ");
          x = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Girilen Sayı: {0}", x);
          toplam += x;
      }
      while (x != 1);
      Console.Write("Girilen Sayıların Toplamı : {0}",toplam);
      Console.ReadKey(); 
  }
 }
}
