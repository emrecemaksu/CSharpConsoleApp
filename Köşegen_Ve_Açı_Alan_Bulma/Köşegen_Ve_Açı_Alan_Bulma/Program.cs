using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Köşegen_Ve_Açı_Alan_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cıkıs;
            double alan = 0;
            double kosegen1, kosegen2, acı;
            Console.Write("1. Köşegeni Yazınız :");
            kosegen1 = double.Parse(Console.ReadLine());
            Console.Write("2. Köşegeni Yazınız :");
            kosegen2 = double.Parse(Console.ReadLine());
            Console.Write("Açıyı Derece Olarak Giriniz :");
            acı = double.Parse(Console.ReadLine());
            alan = kosegen1 * kosegen2 * Math.Sin(Math.PI * acı / 180) / 2;
            Console.WriteLine("Köşegenli Dörtgenin Alanı : {0}", alan);
            Console.Write("Çıkmak İçin x'e Basınız :");
            cıkıs = Console.ReadKey();
            while (cıkıs.KeyChar != 'x') ;
        }
    }
}
