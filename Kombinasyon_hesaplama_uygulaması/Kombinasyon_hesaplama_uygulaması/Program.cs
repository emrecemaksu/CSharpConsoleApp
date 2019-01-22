using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kombinasyon_hesaplama_uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r;
            int n_fak = 1, r_fak = 1, f = 0, f_fak = 1, sonuc = 0;
            Console.Write("Kümenin eleman sayısını giriniz => ");
            n = Int32.Parse(Console.ReadLine());
            Console.Write("Alt kümenin istenilen eleman sayısını giriniz => ");
            r = Int32.Parse(Console.ReadLine());
            f = n - r;
            for (int i = 1; i <= n; i++)
            {
                n_fak = n_fak * i;
            }
            for (int j = 1; j <= r; j++)
            {
                r_fak = r_fak * j;
            }
            for (int k = 1; k <= f; k++)
            {
                f_fak = f_fak * k;
            }
            sonuc = n_fak / (r_fak * f_fak);
            Console.Write("C({0},{1}) => {2}", n, r, sonuc);
            Console.ReadLine();
        }
    }
}
