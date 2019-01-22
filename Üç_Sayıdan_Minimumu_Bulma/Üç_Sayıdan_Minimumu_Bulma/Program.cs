using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Üç_Sayıdan_Minimumu_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı1, sayı2, sayı3;
            Console.WriteLine("İlk Sayıyı Girin :");
            sayı1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Gir :");
            sayı2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Üçüncü Sayıyı Gİr :");
            sayı3 = Int32.Parse(Console.ReadLine());
            if (sayı1 < sayı2)
                if (sayı1 < sayı3)
                    Console.WriteLine("En Küçük Sayı : {0}", sayı1);
            if (sayı2 < sayı3)
                if (sayı2 < sayı1)
                    Console.WriteLine("En Küçük Sayı : {0}", sayı2);
            if (sayı3 < sayı1)
                if (sayı3 < sayı2)
                    Console.WriteLine("En Küçük Sayı : {0}", sayı3);
            Console.ReadLine();
        }
    }
}
