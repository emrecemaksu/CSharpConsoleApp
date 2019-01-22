using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kokteyl_Sıralama_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet;
            int gecici = 0;
            bool degisim;
            Console.Write("Toplam Sayı Adetini Yazınız => ");
            adet = Int32.Parse(Console.ReadLine());
            int[] sayılar = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                Console.Write("{0}. Sayıyı Giriniz => ", i + 1);
                sayılar[i] = Int32.Parse(Console.ReadLine());
            }
            do
            {
                degisim = false;
                for (int j = 0; j <= sayılar.Length - 2; j++)
                {
                    if (sayılar[j + 1] < sayılar[j])
                    {
                        gecici = sayılar[j];
                        sayılar[j] = sayılar[j + 1];
                        sayılar[j + 1] = gecici;
                        degisim = true;
                    }
                }
                if (!degisim)
                {
                    break;
                }
                for (int k = sayılar.Length - 2; k >= 0; k--)
                {
                    if (sayılar[k + 1] < sayılar[k])
                    {
                        gecici = sayılar[k];
                        sayılar[k] = sayılar[k + 1];
                        sayılar[k + 1] = gecici;
                        degisim = true;
                    }
                }
            }
            while (degisim);
            Console.Write("Sayıların Küçükten Büyüğe Sıralanmış Hali => ");
            for (int p = 0; p < sayılar.Length; p++)
            {
                Console.Write("{0,3}", sayılar[p]);
            }
            Console.ReadLine();
        }
    }
}
