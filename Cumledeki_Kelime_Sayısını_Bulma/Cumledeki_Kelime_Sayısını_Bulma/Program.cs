using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cumledeki_Kelime_Sayısını_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sımge = { ' ', ',', '-', ';', ':' };
            int sayı = 0;
            string cumle;
            Console.Write("Cümle => ");
            cumle = Console.ReadLine();
            for (int i = 0; i < cumle.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (sımge[j] == cumle[i])
                    {
                        sayı++;
                    }
                }
            }
            Console.Write("\nCümlede {0} Adet Kelime Vardır.", sayı + 1);
            Console.ReadLine();
        }
    }
}
