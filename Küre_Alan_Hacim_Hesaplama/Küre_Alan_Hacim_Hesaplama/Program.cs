using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Küre_Alan_Hacim_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            double alan = 0, hacim = 0;
            double yarıcap;
            Console.Write("Yarıçapı Giriniz :");
            yarıcap = double.Parse(Console.ReadLine());
            alan = 4 * Math.PI * Math.Pow(yarıcap, 2);
            hacim = (4 * Math.PI * Math.Pow(yarıcap, 3)) / 3;
            Console.WriteLine("Kürenin Alanı : {0}", alan);
            Console.WriteLine("Kürenin Hacmi : {0}", hacim);
            Console.ReadLine();
        }
    }
}
