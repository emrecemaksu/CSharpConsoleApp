using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziyi_Tersine_Cevirme_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizinin Eleman Sayısını Girin => ");
            int eleman = Int32.Parse(Console.ReadLine());
            int[] Duz = new int[eleman];
            int[] Ters = new int[eleman];
            Console.WriteLine();
            for (int i = 0; i < Duz.Length; i++)
            {
                Console.Write("{0} İndisin Değeri => ", i);
                Duz[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n************\n");
            for (int k = 0; k < Duz.Length; k++)
            {
                Ters[k] = Duz[Duz.Length - 1 - k];
                Console.WriteLine("{0}. İndisin Ters Çevrilmiş Değeri => {1}", k, Ters[k]);
            }
            Console.ReadLine();
        }
    }
}
