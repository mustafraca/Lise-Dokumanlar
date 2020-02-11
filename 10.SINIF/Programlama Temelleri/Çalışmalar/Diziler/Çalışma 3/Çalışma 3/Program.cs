using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Çalışma_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // "Ali,Ayşe,Fatma,Mehmet,Güneş,Azra,Ufuk,Yavuz" elemanlarından oluşan 8 elemanlı bir dizide klavyeden girilen ismi araştırıp, 
            //  varsa "GİRDİĞİNİZ İSİM DİZİDE VAR" mesajını yazan program.

            string[] isimler = new string[8] { "ali", "ayşe", "fatma", "mehmet", "güneş", "azra", "ufuk", "yavuz" };
            Console.Write("İsim Giriniz : ");
            string isim = Console.ReadLine();
            isim = isim.ToLower();
            bool x = false;

            for (int i = 0; i < 8; i++)
            {
                if (isimler[i] == isim)
                { x = true; }
            }
            if (x == true) { Console.Write("Girdiğiniz İsim Dizide Bulunmakta."); }
            else { Console.Write("Girdiğiniz İsim Dizide Bulunmamaktadır."); }
            Console.ReadKey();
        }
    }
}
