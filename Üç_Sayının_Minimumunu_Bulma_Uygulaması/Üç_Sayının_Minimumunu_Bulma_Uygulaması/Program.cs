using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Üç_Sayının_Minimumunu_Bulma_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 100;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0}. Sayıyı Giriniz :", i + 1);
                int sayı = Int32.Parse(Console.ReadLine());
                if (sayı < min)
                {
                    min = sayı;
                }
            }

            Console.WriteLine("En Küçük Sayı : {0}", min);
            Console.ReadLine();
        }
    }
}
