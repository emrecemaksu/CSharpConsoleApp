using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelimeyi_Kaç_Adet_Yazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime;
            int sayı;
            Console.WriteLine("Kelimeyi Yaz :");
            kelime = Console.ReadLine();
            Console.WriteLine("Kelime Adetini Yaz :");
            sayı = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < sayı; i++)
            {
                Console.WriteLine(kelime);
            }
            Console.ReadLine();
        }
    }
}
