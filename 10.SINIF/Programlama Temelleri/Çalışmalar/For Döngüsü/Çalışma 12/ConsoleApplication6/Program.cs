using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
 class Program
 {
  static void Main(string[] args)
  {
     // *****      Görüntüsünü veren Program.
     // ****
     // ***
     // **
     // *
     int i, s;
     for (i = 5; i>=1; i--)
     {
         for (s = 2; s <= i; s++) Console.Write("*");
         Console.Write("\n");
     }
     Console.ReadKey();
  }
 }
}
