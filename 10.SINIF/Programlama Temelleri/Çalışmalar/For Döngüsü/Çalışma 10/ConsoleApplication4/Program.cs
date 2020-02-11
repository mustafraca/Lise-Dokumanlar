using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
 class Program
 {
  static void Main(string[] args)
  {
   // Klavyeden Girilen Başlangıç ve Bitiş Değerleri Arasındaki TEK Sayıları Ekrana Yazan Program.
   Console.Write("Başlangıç Değerini Giriniz: ");
   int x = Convert.ToInt32(Console.ReadLine());
   Console.Write("Bitiş Değerini Giriniz: ");
   int y = Convert.ToInt32(Console.ReadLine());
   
   int i;
   Console.Write("Tek Sayılar: ");
   for (i = x; i <= y; i++)
   {
    if (i % 2 == 1)
    Console.Write(" {0}", i);
   }
   Console.ReadKey();


  }
 }
}
