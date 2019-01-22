using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U_Formülü_Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            double kenar1, kenar2, kenar3;
            double u = 0, alan = 0;
            Console.Write("Birinci Kenarı Giriniz => ");
            kenar1 = double.Parse(Console.ReadLine());
            Console.Write("İkinci Kenarı Giriniz => ");
            kenar2 = double.Parse(Console.ReadLine());
            Console.Write("Üçüncü Kenarı Giriniz => ");
            kenar3 = double.Parse(Console.ReadLine());
            u = (kenar1 + kenar2 + kenar3) / 2;
            alan = Math.Sqrt(u * ((u - kenar1) * (u - kenar2) * (u - kenar3)));
            Console.WriteLine("Üç Kenarı Bilinen Üçgenin Alanı => {0}", alan);
            Console.ReadLine();
        }
    }
}
