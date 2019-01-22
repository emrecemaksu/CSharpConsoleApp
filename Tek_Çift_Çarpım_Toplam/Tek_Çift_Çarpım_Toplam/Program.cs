using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tek_Çift_Çarpım_Toplam
{
    class Program
    {
        static void Main(string[] args)
        {
            double toplam_cift = 0, carpım_cift = 1;
            double toplam_tek = 0, carpım_tek = 1;
            for (int i = 0; i < 100; i += 2)
            {
                toplam_cift = toplam_cift + i;
            }
            for (int j = 2; j < 100; j += 2)
            {
                carpım_cift = carpım_cift * j;
            }
            for (int k = 1; k < 100; k += 2)
            {
                toplam_tek = toplam_tek + k;
            }
            for (int h = 1; h < 100; h += 2)
            {
                carpım_tek = carpım_tek * h;
            }
            Console.WriteLine("Çift Sayı Toplamları : {0}", toplam_cift);
            Console.WriteLine("Çift Sayı Çarpımları : {0}", carpım_cift);
            Console.WriteLine("Tek Sayı Toplamları : {0}", toplam_tek);
            Console.WriteLine("Tek Sayı Çarpımları : {0}", carpım_tek);
            Console.ReadLine();
        }
    }
}
