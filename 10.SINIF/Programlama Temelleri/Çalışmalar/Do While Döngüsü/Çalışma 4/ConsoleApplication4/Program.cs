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
      // Klavyeden Girilen Cinsiyet Bilgisine Göre (Kız İçin = 'k', Erkek İçin = 'e' Girilecek) "e" ve "k" 
      // Dışında Giriş Yapılana Kadar Girilen Kız ve Erkek Sayılarının Toplamını Bulan Program.
      int etop = 0; int ktop = 0; char bilgi; char erkek = 'e'; char kız = 'k';
      do
      {
          Console.Write("Cinsiyet Bilginizi Giriniz: ");
          bilgi = Convert.ToChar(Console.ReadLine());
          if (bilgi == erkek)
          {
              etop++;
          }
          else if (bilgi == kız)
          {
              ktop++;
          }
      }
      while (bilgi == erkek || bilgi == kız);
      Console.WriteLine("Girilen Kız Sayısı Toplamı: {0}\nGirilen Erkek Sayısı Toplamı: {1}", ktop, etop);
      Console.Write("Girilen Kız ve Erkek Sayısı Toplamı: {0}", ktop + etop);
      Console.ReadKey();
  }
 }
}
