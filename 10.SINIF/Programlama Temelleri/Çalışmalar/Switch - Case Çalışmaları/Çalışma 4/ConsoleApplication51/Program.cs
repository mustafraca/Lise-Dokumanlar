using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication51
{
 class Program
 {
  static void Main(string[] args)
  {
    // 0-9 Arasında Klavyeden Girilen Sayıyı Okuma
   int x;
   Console.Write("0-9 Arasında Bir Sayı Giriniz: ");
   x = Convert.ToInt16(Console.ReadLine());
   switch (x)
   {
    case 0:
     Console.Write("Sıfır");
     break;
    case 1:
     Console.Write("Bir");
     break;
    case 2:
     Console.Write("İki");
     break;
    case 3:
     Console.Write("Üç");
     break;
    case 4:
     Console.Write("Dört");
     break;
    case 5:
     Console.Write("Beş");
     break;
    case 6:
     Console.Write("Altı");
     break;
    case 7:
     Console.Write("Yedi");
     break;
    case 8:
     Console.Write("Sekiz");
     break;
    case 9:
     Console.Write("Dokuz");
     break;
    default:
     Console.Write("Hatalı Giriş");
     break;
   }
   Console.ReadKey();
  }
 }
}
