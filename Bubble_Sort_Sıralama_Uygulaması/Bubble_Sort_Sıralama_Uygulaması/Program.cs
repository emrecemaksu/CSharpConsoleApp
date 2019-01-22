using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort_Sıralama_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet;
            int gecici = 0;
            Console.Write("Sayı Adetini Giriniz => ");
            adet = Int32.Parse(Console.ReadLine());
            int[] sayılar = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                Console.Write("{0}. Sayıyı Giriniz => ", i + 1);
                sayılar[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n**************\n");
            Console.Write("Sayıların Küçükten Büyüğe Sıralaması => ");
            for (int j = 0; j < sayılar.Length; j++)
            {
                for (int k = 0; k < sayılar.Length - 1; k++)
                {
                    if (sayılar[k + 1] < sayılar[k])
                    {
                        gecici = sayılar[k];
                        sayılar[k] = sayılar[k + 1];
                        sayılar[k + 1] = gecici;
                    }
                }
            }
            for (int p = 0; p < sayılar.Length; p++)
            {
                Console.Write("{0,3}", sayılar[p]);
            }
            Console.ReadLine();
        }
    }
}
