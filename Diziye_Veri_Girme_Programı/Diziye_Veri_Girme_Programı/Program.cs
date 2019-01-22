using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziye_Veri_Girme_Programı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eleman Sayısını Giriniz => ");
            int eleman = Int32.Parse(Console.ReadLine());
            int[] dizi = new int[eleman];
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("{0}. Elemanın Değerini Giriniz => ", i + 1);
                dizi[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("*************");
            for (int k = 0; k < dizi.Length; k++)
            {
                Console.WriteLine("{0}. İndisin Değeri => {1}", k, dizi[k]);
            }
            Console.ReadLine();
        }
    }
}
