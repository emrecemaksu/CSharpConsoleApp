using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yüzde_18_Kdvli_Fiyat_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fiyat;
            Console.WriteLine("Fiyat Giriniz:");
            Fiyat = Int32.Parse(Console.ReadLine());
            int KDVliFiyat = Fiyat + (Fiyat * 18 / 100);
            Console.WriteLine("%18 KDV'li Fiyat:{0}", KDVliFiyat);
            Console.ReadLine();
        }
    }
}
