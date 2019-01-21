using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Sayının_Ortalaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0, ortalama = 0;
            int[] sayı = new int[10];
            int i = 0;
            for (; i < 10; i++)
            {
                Console.Write("{0}. Sayıyı Giriniz :", i + 1);
                sayı[i] = Int32.Parse(Console.ReadLine());
                toplam = toplam + sayı[i];
            }
            ortalama = toplam / 10;
            Console.WriteLine("10 Sayının Ortalaması : {0}", ortalama);
            Console.ReadLine();
        }
    }
}
