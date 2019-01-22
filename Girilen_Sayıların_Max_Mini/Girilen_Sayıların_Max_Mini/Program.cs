using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_Sayıların_Max_Mini
{
    class Program
    {
        static void Main(string[] args)
        {
            int Max = 100, Min = 0, sayı;
            Console.WriteLine("Sayı Adetini Giriniz :");
            int Adet = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < Adet; i++)
            {
                Console.WriteLine("{0} . sayıyı giriniz :", i + 1);
                sayı = Int32.Parse(Console.ReadLine());
                if (sayı < Max)
                {
                    Max = sayı;
                }
                if (sayı > Min)
                {
                    Min = sayı;
                }
            }
            Console.WriteLine("En Büyük Sayı : {0}", Min);
            Console.WriteLine("En Küçük Sayı : {0}", Max);
            Console.ReadLine();
        }
    }
}
