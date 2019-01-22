using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İki_Kenar_Bir_Derece_Alan_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo h;
            double kenar1, kenar2, acı, alan = 0;
            Console.Write("1. Kenarı Giriniz :");
            kenar1 = double.Parse(Console.ReadLine());
            Console.Write("2. Kenarı Giriniz :");
            kenar2 = double.Parse(Console.ReadLine());
            Console.Write("Açıyı Giriniz :");
            acı = double.Parse(Console.ReadLine());
            alan = ((kenar1 * kenar2) * Math.Sin(Math.PI * acı / 180)) / 2;
            Console.WriteLine("Üçgenin Alanı : {0}", alan);
            Console.Write("Çıkış Yapmak İçin x'e Basınız... :");
            h = Console.ReadKey();
            while (h.KeyChar != 'x') ;
        }
    }
}
