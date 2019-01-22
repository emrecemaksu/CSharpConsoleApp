using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Üçgenin_Alanını_Bulma_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo h;
            double alan = 0;
            double taban_uzunluğu, yukseklik;
            Console.Write("Taban Uzunluğunu Yazınız :");
            taban_uzunluğu = Double.Parse(Console.ReadLine());
            Console.Write("Yüksekliği Yazınız :");
            yukseklik = double.Parse(Console.ReadLine());
            alan = (taban_uzunluğu * yukseklik) / 2;
            Console.WriteLine("Üçgenin Alanı : {0}", alan);
            Console.WriteLine("Çıkmak İçin x'e basınız... :");
            h = Console.ReadKey();
            while (h.KeyChar != 'x') ;
        }
    }
}
