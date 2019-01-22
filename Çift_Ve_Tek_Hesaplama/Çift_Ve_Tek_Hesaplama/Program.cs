using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çift_Ve_Tek_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayıyı Girin :");
            int sayı = Int32.Parse(Console.ReadLine());
            if (sayı % 2 == 1)
            {
                Console.WriteLine("Sayı Tektir...");
            }
            if (sayı % 2 == 0)
            {
                Console.WriteLine("Sayı Çifttir...");
            }
            Console.ReadLine();
        }
    }
}
