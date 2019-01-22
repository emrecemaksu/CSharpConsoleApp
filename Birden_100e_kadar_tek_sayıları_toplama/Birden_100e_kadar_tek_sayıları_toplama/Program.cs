using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birden_100e_kadar_tek_sayıları_toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int Toplam = 0;
            for (int i = 1; i < 101; i += 2)
            {
                Toplam += i;
            }
            Console.WriteLine("1'den 100'e kadar tek sayıların toplamı : {0}", Toplam);
            Console.ReadLine();
        }
    }
}
