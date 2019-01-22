using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birden_100e_kadar_sayıları_toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int Toplam = 0;
            for (int i = 1; i < 101; ++i)
            {
                Toplam += i;
            }
            Console.WriteLine("1 ile 100 arasındaki Sayıların Toplamı = {0}", Toplam);
            Console.ReadLine();
        }
    }
}
