using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication49
{
 class Program
 {
  static void Main(string[] args)
  {
     
     Console.Write("Bir Ay Giriniz: ");
     string ay = Console.ReadLine();
     string x = ay.ToUpper(); 
     // "ToUpper" Klavyeden Girilen Yazıyı Tamamen Büyük Harfe Çevirir. ÖR: Klavyeden Girilen "HaZiRaN" Yazısını "HAZİRAN" Yazısına Çevirir.
     // "ToLower" Klavyeden Girilen Yazıyı Tamamen Küçük Harfe Çevirir. ÖR: Klavyeden Girilen "HAZiraN" Yazısını "haziran" Yazısına Çevirir.
     switch (x)
     {
        case "ARALIK":
        case "OCAK":
        case "ŞUBAT":
                Console.Write("Kış");
                break;
        case "MART":
        case "NİSAN":
        case "MAYIS":
                Console.Write("İlkbahar");
                break;
        case "HAZİRAN":
        case "TEMMUZ":
        case "AĞUSTOS":
                Console.Write("Yaz");
                break;   
        case "EYLÜL":
        case "EKİM":
        case "KASIM":
                Console.Write("Sonbahar");
                break;
        default:
             Console.Write("Yanlış Değer Girdiniz");
             break;
        }
        Console.ReadKey();
  }
 }
}
