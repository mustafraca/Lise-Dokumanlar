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
      // Klavyeden Girilen Başlangıç ve Bitiş Değerleri Arasındaki Çift Sayıları Ekrana Yazdıran Programı 
      // Do While Döngüsü Kullanarak Yazınız.
      Console.Write("Başlangıç Değerini Giriniz: ");
      int baslangıc = Convert.ToInt32(Console.ReadLine());
      Console.Write("Bitiş Değerini Giriniz: ");
      int bitis = Convert.ToInt32(Console.ReadLine());
      do
      {

          if (baslangıc % 2 == 0)
          {
              Console.Write("{0}, ", baslangıc);
          }
          baslangıc++;
      }
      while (baslangıc <= bitis);
      Console.ReadKey();

     

     
     
  }
 }
}
