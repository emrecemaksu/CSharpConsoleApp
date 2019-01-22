using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Büyük_Olan_Sayıyı_Bulma_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sayı1, Sayı2;
            Console.Write("Birinci Sayıyı Giriniz:");
            Sayı1 = Int32.Parse(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz:");
            Sayı2 = Int32.Parse(Console.ReadLine());
            if (Sayı1 < Sayı2)
            {
                Console.WriteLine("{0} Sayısı {1} Sayısından Daha Büyüktür...", Sayı2, Sayı1);
            }
            else if (Sayı2 < Sayı1)
            {
                Console.WriteLine("{0} Sayısı {1} Sayısından Daha Büyüktür...", Sayı1, Sayı2);
            }
            Console.ReadLine();
        }
    }
}
