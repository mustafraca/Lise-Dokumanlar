using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
 class Program
 {
  static void Main(string[] args)
  {
     // 1 ile n Arasındaki Çift Sayıların TOPLAMINI, Tek Sayıların KARELERİNİ Ekrana Listeleyen Program.
     
      Console.Write("N Değerini Giriniz: ");
     
      int n = Convert.ToInt32(Console.ReadLine());
      int i, toplam=0;
      for (i = 1; i <= n; i++)
      {
         
          if (i % 2 == 0)
             toplam = toplam + i;

         
          else
             Console.Write("Tek Sayıların Karesi: {0}\n", Math.Pow(i, 2));
      }
       Console.Write("\nÇift Sayıların Toplamı: {0}",toplam);
       Console.ReadKey();
       
  }
 }
}
