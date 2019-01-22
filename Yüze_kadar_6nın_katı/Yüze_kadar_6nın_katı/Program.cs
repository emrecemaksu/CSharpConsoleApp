using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yüze_kadar_6nın_katı
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sayılar = 0;
            for (int x = 0; x < 101; x += 6)
            {
                if (Sayılar % 7 == 0)
                    Console.WriteLine();
                Console.Write("{0,3}", x);
                Sayılar++;
            }
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
