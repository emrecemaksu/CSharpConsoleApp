using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kenar_Açı_Kenar_Kenar_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cıkıs;
            double kenar3 = 0;
            double kenar1, kenar2, acı;
            Console.Write("1. Kenarı Giriniz :");
            kenar1 = double.Parse(Console.ReadLine());
            Console.Write("2. Kenarı Giriniz :");
            kenar2 = double.Parse(Console.ReadLine());
            Console.Write("Açı Değerini Derece Olarak Giriniz :");
            acı = double.Parse(Console.ReadLine());
            kenar3 = Math.Sqrt(Math.Pow(kenar1, 2) + Math.Pow(kenar2, 2) - 2 * kenar2 * kenar1 * Math.Cos(acı * Math.PI / 180));
            Console.WriteLine("3. Kenar : {0}'dır...", kenar3);
            Console.Write("Çıkmak İçin x'e Basınız.. :");
            cıkıs = Console.ReadKey();
            while (cıkıs.KeyChar != 'x') ;
        }
    }
}
