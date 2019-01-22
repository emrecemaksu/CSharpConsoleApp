using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serbest_Atış
{
    class Program
    {
        static void Main(string[] args)
        {
            const double g = 9.18;
            double yükseklik, ilk_hız, dikey_hız;
            double havada_kalma_süresi = 0, yatay_yol = 0, yere_çarpma_hızı = 0;
            Console.Write("Cismin İlk Hızı Giriniz :");
            ilk_hız = double.Parse(Console.ReadLine());
            Console.Write("Cismin Yüksekliği Giriniz :");
            yükseklik = double.Parse(Console.ReadLine());
            havada_kalma_süresi = Math.Sqrt((2 * yükseklik) / g);
            yatay_yol = ilk_hız * havada_kalma_süresi;
            dikey_hız = g * havada_kalma_süresi;
            yere_çarpma_hızı = Math.Sqrt(Math.Pow(ilk_hız, 2) * Math.Pow(dikey_hız, 2));
            Console.WriteLine("Cismin Havada Kalma Süresi : {0}", havada_kalma_süresi);
            Console.WriteLine("Cismin Yatayda Aldığı Yol : {0}", yatay_yol);
            Console.WriteLine("Cismin Dikeydeki Hızı : {0}", dikey_hız);
            Console.WriteLine("Cismin Yere Çarpma Hızı : {0}", yere_çarpma_hızı);
            Console.ReadLine();
        }
    }
}
