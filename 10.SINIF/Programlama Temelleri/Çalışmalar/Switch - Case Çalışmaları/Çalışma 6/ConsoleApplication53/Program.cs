using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication53
{
 class Program
 {
  static void Main(string[] args)
  {
      Console.Write("Üç Basamaklı Bir Sayı Giriniz: ");
      int x = Convert.ToInt32(Console.ReadLine());
      
      int onlar,birler,yüzler; 
      yüzler =x/100;
      onlar =(x % 100)/10;
      birler = (x % 100) % 10;
      
      switch (yüzler)
      {
         case 1:
              Console.Write("Yüz");
              break;
         case 2:
              Console.Write("İkiYüz");
              break;
         case 3:
              Console.Write("ÜçYüz");
              break;
         case 4:
              Console.Write("DörtYüz");
              break;
         case 5:
              Console.Write("BeşYüz");
              break;
         case 6:
              Console.Write("AltıYüz");
              break;
         case 7:
              Console.Write("YediYüz");
              break;
         case 8:
              Console.Write("SekizYüz");
              break;
         case 9:
              Console.Write("DokuzYüz");
              break;
        }
        switch (onlar)
        {
         case 1:
              Console.Write("On");
              break;
         case 2:
              Console.Write("Yirmi");
              break;
         case 3:
              Console.Write("Otuz");
              break;
         case 4:
              Console.Write("Kırk");
              break;
         case 5:
              Console.Write("Elli");
              break;
         case 6:
              Console.Write("Altmış");
              break;
         case 7:
              Console.Write("Yetmiş");
              break;
         case 8:
              Console.Write("Seksen");
              break;
         case 9:
              Console.Write("Doksan");
              break;
        }
        switch (birler)
        {
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
        }
        Console.ReadKey();
          
               
              
              
              
  }
 }
}
