using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öklit_Teoremleri_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            double k, p;
            double h = 0, b = 0, c = 0;
            Console.Write("k Kenarını Girin => ");
            k = double.Parse(Console.ReadLine());
            Console.Write("p Kenarını Gİrin => ");
            p = double.Parse(Console.ReadLine());
            h = Math.Sqrt(p * k);
            b = Math.Sqrt(k * (p + k));
            c = Math.Sqrt(p * (p + k));
            Console.WriteLine("h Kenarının Uzunluğu => {0}", h);
            Console.WriteLine("b Kenarının Uzunluğu => {0}", b);
            Console.WriteLine("c Kenarının Uzunluğu => {0}", c);
            Console.ReadLine();
        }
    }
}
