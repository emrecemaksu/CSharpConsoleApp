using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hipotenüs
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cıkıs;
            double hipotenus = 0;
            double kenar1, kenar2;
            Console.Write("Birinci Kenarı Giriniz :");
            kenar1 = double.Parse(Console.ReadLine());
            Console.Write("İkinci Kenarı Giriniz :");
            kenar2 = double.Parse(Console.ReadLine());
            hipotenus = Math.Sqrt((kenar2 * kenar2) + (kenar1 * kenar1));
            Console.WriteLine("Üçgenin Hipotenüs Uzunluğu : {0}", hipotenus);
            Console.Write("Çıkış İçin x'e basınız... :");
            cıkıs = Console.ReadKey();
            while (cıkıs.KeyChar != 'x') ;
        }
    }
}
