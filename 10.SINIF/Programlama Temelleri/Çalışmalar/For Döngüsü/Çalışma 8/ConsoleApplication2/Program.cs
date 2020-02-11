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
    // Klavyeden Girilen n Değeri İçin 1+2+3+4+5+...+n İşlemini Yapan Program.
    Console.Write("N Değerini Giriniz: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int i, toplam = 0;
    for (i = 1; i <= n; i++)
    toplam = toplam + i;
    Console.Write("Toplam= {0}", toplam);
    Console.ReadKey();
    
  }
 }
}
