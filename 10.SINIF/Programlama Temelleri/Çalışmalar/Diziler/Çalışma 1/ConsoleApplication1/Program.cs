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
            //7 elemanlı gunler isimli bir dizi tanımlayınız. Dizinin elemanmlarını klavyeden giriniz ve ekranı temizledikten sonra tekrar dizinin elemanlartını listeletiniz.
            
            string[] gunler = new string[7]; //Dizi tanımlanıyor

            for (int i = 0; i < 7; i++) //Dizinin elemalarını giriyoruz
            {
                Console.Write("{0}. Günü Gir: ", i + 1);
                gunler[i] = Console.ReadLine();
            }
            Console.Clear(); //Ekran temizleniyor

            //Dizinin elemanları ekrana yazılacak
            for (int i = 0; i < 7; i++)
            {
                Console.Write("{0}, ", gunler[i]);
            } Console.ReadKey();
        }
    }
}
