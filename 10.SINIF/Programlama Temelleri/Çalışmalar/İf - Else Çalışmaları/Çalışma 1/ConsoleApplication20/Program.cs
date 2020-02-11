using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication20
{
 class Program
 {
  static void Main(string[] args)
  {

      
      // Ünlü şairimiz Mehmet Akif’in soyadı nedir? sorusunu kullanıcıya soran cevabını isteyen programı yazınız.
      Console.Write("Ünlü şairimiz Mehmet Akif'in soyadı nedir?\nCevabınız: ");
      string cevap = Console.ReadLine();
      if (((cevap=="Ersoy") || (cevap=="ERSOY")) || (cevap=="ersoy"))
      {
      Console.Write("Tebrikler bu sorumuz doğru cevap verdiniz...");
      }
      else
      {
      Console.WriteLine("Malesef yanlış cevap");
      }
      Console.ReadKey();



      
      
  }
 }
}
