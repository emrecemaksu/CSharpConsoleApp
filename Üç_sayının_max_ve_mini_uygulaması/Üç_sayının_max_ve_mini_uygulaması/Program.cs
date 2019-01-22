using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Üç_sayının_max_ve_mini_uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı1, sayı2, sayı3;
            Console.WriteLine("İlk Sayıyı Giriniz :");
            sayı1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Giriniz :");
            sayı2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Üçüncü Sayıyı Giriniz :");
            sayı3 = Int32.Parse(Console.ReadLine());
            if ((sayı1 > sayı2) && (sayı1 > sayı3) && (sayı2 < sayı3))
            {
                Console.WriteLine("En Büyük Sayı {0} 'dır...", sayı1);
                Console.WriteLine("En Küçük Sayı {0} 'dır...", sayı2);
            }
            else if ((sayı1 > sayı2) && (sayı1 > sayı3) && (sayı3 < sayı2))
            {
                Console.WriteLine("En Büyük Sayı {0} 'dır...", sayı1);
                Console.WriteLine("En Küçük Sayı {0} 'dır...", sayı3);
            }
            else if ((sayı2 > sayı1) && (sayı2 > sayı3) && (sayı1 > sayı3))
            {
                Console.WriteLine("En Büyük Sayı {0} 'dır...", sayı2);
                Console.WriteLine("En Küçük Sayı {0} 'dır...", sayı3);
            }
            else if ((sayı2 > sayı1) && (sayı2 > sayı3) && (sayı1 < sayı3))
            {
                Console.WriteLine("En Büyük Sayı {0} 'dır...", sayı2);
                Console.WriteLine("En Küçük Sayı {0} 'dır...", sayı1);
            }
            else if ((sayı3 > sayı2) && (sayı3 > sayı1) && (sayı1 < sayı2))
            {
                Console.WriteLine("En Büyük Sayı {0} 'dır...", sayı3);
                Console.WriteLine("En Küçük Sayı {0} 'dır...", sayı1);
            }
            else if ((sayı3 > sayı2) && (sayı3 > sayı1) && (sayı1 > sayı2))
            {
                Console.WriteLine("En Büyük Sayı {0} 'dır...", sayı3);
                Console.WriteLine("En Küçük Sayı {0} 'dır...", sayı2);
            }
            else if ((sayı1 == sayı2) && (sayı2 == sayı3))
            {
                Console.WriteLine("Bütün Sayılar Birbirine Eşittir...");
            }
            Console.ReadLine();
        }
    }
}
