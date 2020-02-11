using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication50
{
 class Program
 {
  static void Main(string[] args)
  {
   // Switch-Case Hesap Makinesi
   Console.WriteLine("1->Toplama: +");
   Console.WriteLine("2->Çıkarma: -");
   Console.WriteLine("3->Çarpma: *");
   Console.WriteLine("4->Bölme: /\n---------------");
   
   Console.Write("1.Sayıyı Giriniz: ");
   int x = Convert.ToInt32(Console.ReadLine());
   Console.Write("2.Sayıyı Giriniz: ");
   int y = Convert.ToInt32(Console.ReadLine());
   Console.Write("İşleminizi Seçiniz: ");
   string islem;
   islem = Console.ReadLine();
   Console.WriteLine("---------------");
   switch (islem)
   {
     case "+":
    Console.Write("Sonuç: {0}",x+y);
    break;
    case "-":
     Console.Write("Sonuç: {0}", x - y);
     break;
    case "*":
     Console.Write("Sonuç: {0}", x * y);
     break;
    case "/":
     Console.Write("Sonuç: {0}", x / y);
     break;
    default:
     Console.Write("Hatalı Giriş");
     break;
   }
   Console.ReadKey();
  }
 }
}
