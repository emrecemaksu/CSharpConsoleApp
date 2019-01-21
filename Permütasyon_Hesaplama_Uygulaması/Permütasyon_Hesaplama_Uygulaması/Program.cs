using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permütasyon_Hesaplama_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r;
            int k = 0, n_fak = 1, k_fak = 1, sonuc = 0;
            Console.Write("Kümenin eleman sayısını giriniz => ");
            n = Int32.Parse(Console.ReadLine());
            Console.Write("Sıralama için seçilecek eleman sayısını giriniz => ");
            r = Int32.Parse(Console.ReadLine());
            k = n - r;
            for (int i = 1; i <= n; i++)
            {
                n_fak = n_fak * i;
            }
            for (int j = 1; j <= k; j++)
            {
                k_fak = k_fak * j;
            }
            sonuc = n_fak / k_fak;
            Console.Write("P({0},{1}) => {2}", n, r, sonuc);
            Console.ReadLine();
        }
    }
}
