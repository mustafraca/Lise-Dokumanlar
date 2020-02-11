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
      // 0 ile 100 Arasındaki Çift Sayıları Ekrana Yazdıran Program.
      int i;
      Console.Write("Çift Sayılar: ");
      for (i = 0; i <= 100; i++)
      {
         if (i % 2 == 0)
         Console.Write(" {0}",i);
     }
     Console.ReadKey();
  }
 }
}
