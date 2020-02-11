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
            
            Console.WriteLine("1--Toplama: +");
            Console.WriteLine("2--Çıkarma: -");
            Console.WriteLine("3--Çarpma: *");
            Console.WriteLine("4--Bölme: /");
            Console.WriteLine("--------------------");
            Console.Write("1. Sayıyı Giriniz: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("İşleminizi Seçiniz: ");
            
            string islem = Console.ReadLine();
            Console.WriteLine("--------------------");
            switch (islem)
            {
            case "+":
                    Console.WriteLine("Sonuç:> Rakamla: {0}",x+y);
                Console.Write("        Harfle: ");
            int onlar, birler, yüzler, binler, onbinler, yüzbinler;
            yüzbinler =(x  +y) / 100000;
            onbinler=((x + y) % 100000) / 10000;
            binler = (((x + y) % 100000) % 10000) / 1000;
            yüzler = ((((x + y) % 100000) % 10000) % 1000) / 100;
            onlar = (((((x + y) % 100000) % 10000) % 1000) % 100) / 10;
            birler = (((((x + y) % 100000) % 10000) % 1000) % 100) % 10;
            switch (yüzbinler)
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
            switch (onbinler)
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
            switch (binler)
            {
                case 0:
                    Console.Write("Bin");
                    break;
                case 1:
                    Console.Write("BirBin");
                    break;
                case 2:
                    Console.Write("İkiBin");
                    break;
                case 3:
                    Console.Write("ÜçBin");
                    break;
                case 4:
                    Console.Write("DörtBin");
                    break;
                case 5:
                    Console.Write("BeşBin");
                    break;
                case 6:
                    Console.Write("AltıBin");
                    break;
                case 7:
                    Console.Write("YediBin");
                    break;
                case 8:
                    Console.Write("SekizBin");
                    break;
                case 9:
                    Console.Write("DokuzBin");
                    break;
            }
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
                    break;
            
            case "-":
                Console.WriteLine("Sonuç:> Rakamla: {0}",x-y);
                Console.Write("        Harfle: ");
            int onlar2, birler2, yüzler2, binler2, onbinler2, yüzbinler2;
            yüzbinler2 =(x - y) / 100000;
            onbinler2 =((x - y) % 100000) / 10000;
            binler2 = (((x - y) % 100000) % 10000) / 1000;
            yüzler2 = ((((x - y) % 100000) % 10000) % 1000) / 100;
            onlar2 = (((((x - y) % 100000) % 10000) % 1000) % 100) / 10;
            birler2 = (((((x - y) % 100000) % 10000) % 1000) % 100) % 10;
            switch (yüzbinler2)
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
            switch (onbinler2)
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
            switch (binler2)
            {
                case 0:
                    Console.Write("Bin");
                    break;
                case 1:
                    Console.Write("BirBin");
                    break;
                case 2:
                    Console.Write("İkiBin");
                    break;
                case 3:
                    Console.Write("ÜçBin");
                    break;
                case 4:
                    Console.Write("DörtBin");
                    break;
                case 5:
                    Console.Write("BeşBin");
                    break;
                case 6:
                    Console.Write("AltıBin");
                    break;
                case 7:
                    Console.Write("YediBin");
                    break;
                case 8:
                    Console.Write("SekizBin");
                    break;
                case 9:
                    Console.Write("DokuzBin");
                    break;
            }
            switch (yüzler2)
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
            switch (onlar2)
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
            switch (birler2)
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
                    break;
            case "*":
                Console.WriteLine("Sonuç:> Rakamla: {0}",x*y);
                Console.Write("        Harfle: ");
            int onlar3, birler3, yüzler3, binler3, onbinler3, yüzbinler3;
            yüzbinler3 =(x * y) / 100000;
            onbinler3 =((x * y) % 100000) / 10000;
            binler3 = (((x * y) % 100000) % 10000) / 1000;
            yüzler3 = ((((x * y) % 100000) % 10000) % 1000) / 100;
            onlar3 = (((((x * y) % 100000) % 10000) % 1000) % 100) / 10;
            birler3 = (((((x * y) % 100000) % 10000) % 1000) % 100) % 10;
            switch (yüzbinler3)
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
            switch (onbinler3)
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
            switch (binler3)
            {
                case 0:
                    Console.Write("Bin");
                    break;
                case 1:
                    Console.Write("BirBin");
                    break;
                case 2:
                    Console.Write("İkiBin");
                    break;
                case 3:
                    Console.Write("ÜçBin");
                    break;
                case 4:
                    Console.Write("DörtBin");
                    break;
                case 5:
                    Console.Write("BeşBin");
                    break;
                case 6:
                    Console.Write("AltıBin");
                    break;
                case 7:
                    Console.Write("YediBin");
                    break;
                case 8:
                    Console.Write("SekizBin");
                    break;
                case 9:
                    Console.Write("DokuzBin");
                    break;
            }
            switch (yüzler3)
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
            switch (onlar3)
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
            switch (birler3)
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
                    break;
            case "/": 
                Console.WriteLine("Sonuç:> Rakamla: {0}",x/y);
                Console.Write("        Harfle: ");
            int onlar4, birler4, yüzler4, binler4, onbinler4, yüzbinler4;
            yüzbinler4 =(x / y) / 100000;
            onbinler4 =((x / y) % 100000) / 10000;
            binler4 = (((x / y) % 100000) % 10000) / 1000;
            yüzler4 = ((((x / y) % 100000) % 10000) % 1000) / 100;
            onlar4 = (((((x / y) % 100000) % 10000) % 1000) % 100) / 10;
            birler4 = (((((x / y) % 100000) % 10000) % 1000) % 100) % 10;
            switch (yüzbinler4)
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
            switch (onbinler4)
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
            switch (binler4)
            {
                
                case 1:
                    Console.Write("BirBin");
                    break;
                case 2:
                    Console.Write("İkiBin");
                    break;
                case 3:
                    Console.Write("ÜçBin");
                    break;
                case 4:
                    Console.Write("DörtBin");
                    break;
                case 5:
                    Console.Write("BeşBin");
                    break;
                case 6:
                    Console.Write("AltıBin");
                    break;
                case 7:
                    Console.Write("YediBin");
                    break;
                case 8:
                    Console.Write("SekizBin");
                    break;
                case 9:
                    Console.Write("DokuzBin");
                    break;
            }
            switch (yüzler4)
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
            switch (onlar4)
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
            switch (birler4)
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
                    break;
            default:
                Console.Write("Hatalı Giriş");
                break;
            }
            Console.ReadKey();
        }
    }
}
