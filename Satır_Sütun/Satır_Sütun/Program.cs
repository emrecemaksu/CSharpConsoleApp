using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satır_Sütun
{
    class Program
    {
        static void Main(string[] args)
        {
            int Satır, Sütun;
            Console.Write("Satır Sayısını Girin :");
            Satır = Int32.Parse(Console.ReadLine());
            Console.Write("Sütun Sayısını Girin :");
            Sütun = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < Sütun; ++i)
            {
                for (int x = 0; x < Satır; ++x)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
