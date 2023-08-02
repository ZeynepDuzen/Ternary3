using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** Ternary ile yazi - tura ornegi *** 

            int para = 1; // 1 :tura, 0 :yazi

            Console.WriteLine("Yazi mi(y) tura mi(t) : ");
            string giris = Console.ReadLine();
            int sonuc = giris == "y" ? 0 : giris == "t" ? 1 : -1;

            if (sonuc == -1)
            {
                Console.WriteLine("Lütfen y veya t giriniz : ");
            }
            else
            {
                Console.WriteLine(sonuc == para ? "Tebrikler" : "Bilemediniz");
            }

            Console.Read();
        }
    }
}
