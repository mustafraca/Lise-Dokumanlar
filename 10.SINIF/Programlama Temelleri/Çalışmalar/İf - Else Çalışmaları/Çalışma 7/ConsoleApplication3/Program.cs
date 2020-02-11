using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int V, R, T;
            Console.Write("Gerilim Değerini Giriniz: ");
            V = Convert.ToInt32(Console.ReadLine());
            Console.Write("Direnç Değerini Giriniz: ");
            R = Convert.ToInt32(Console.ReadLine());
            Console.Write("Saat Miktarını Giriniz: ");
            T = Convert.ToInt32(Console.ReadLine());
            int I = V / R;
            Console.Write("A) Güç Miktarı: {0}",V*I);
            int W = (V*I)*T;
            Console.Write("\nB) Toplam İş: {0}",(V*I)*T);
            Console.ReadKey();


        }
    }
}
