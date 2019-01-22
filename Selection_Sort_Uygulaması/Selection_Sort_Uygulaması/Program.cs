using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet, gecici;
            Console.Write("Sıralayacağınız sayı adetini giriniz => ");
            adet = Int32.Parse(Console.ReadLine());
            int[] sayılar = new int[adet];
            for (int f = 0; f < sayılar.Length; f++)
            {
                Console.Write("{0} Sayı Değeri => ", f + 1);
                sayılar[f] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < sayılar.Length - 1; i++)
            {
                for (int k = i + 1; k < sayılar.Length; k++)
                {
                    if (sayılar[k] < sayılar[i])
                    {
                        gecici = sayılar[i];
                        sayılar[i] = sayılar[k];
                        sayılar[k] = gecici;
                    }
                }
            }
            Console.WriteLine("\n********************\n");
            Console.WriteLine("Dizinin Sıralı hali => \n");
            for (int j = 0; j < sayılar.Length; j++)
            {
                Console.WriteLine(sayılar[j]);
            }
            Console.ReadLine();
        }
    }
}
