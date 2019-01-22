using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İki_Dizi_İndislerini_Toplama_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X, Y, Z dizisinin indis sayısını giriniz => ");
            int indis = Int32.Parse(Console.ReadLine());
            int[] X = new int[indis];
            int[] Y = new int[indis];
            int[] Z = new int[indis];
            Console.WriteLine();
            for (int i = 0; i < X.Length; i++)
            {
                Console.Write("X dizisinin {0}. indisinin değeri => ", i);
                X[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n************\n");
            for (int j = 0; j < Y.Length; j++)
            {
                Console.Write("Y dizisinin {0}. indisinin değeri => ", j);
                Y[j] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n************\n");
            for (int k = 0; k < Z.Length; k++)
            {
                Z[k] = X[k] + Y[k];
                Console.WriteLine("Z dizisinin {0}. indisinin değeri => {1} + {2} = {3}", k, X[k], Y[k], Z[k]);
            }
            Console.ReadLine();
        }
    }
}
