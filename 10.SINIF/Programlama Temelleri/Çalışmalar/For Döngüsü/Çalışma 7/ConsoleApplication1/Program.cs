using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
 class Program
 {
  static void Main(string[] args)
  {
     // 1 ile 100 Arasındaki Sayıların TOPLAMINI Ekrana Yazan Program.
     int i, toplam = 0;
     for (i = 1; i <= 100; i++)
     {
         toplam = toplam + i;
     }
     Console.Write("Toplam: {0}", toplam);
     Console.ReadKey();

    
  }
 }
}
