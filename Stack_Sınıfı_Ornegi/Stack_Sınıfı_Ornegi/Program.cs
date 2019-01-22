using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack_Sınıfı_Ornegi
{
    class Program
    {
        public static void EkranaYaz(Stack Tabaklar)
        {
            IEnumerator ie = Tabaklar.GetEnumerator();
            while (ie.MoveNext())
                Console.WriteLine("\t" + ie.Current);
        }
        static void Main(string[] args)
        {
            Stack Tabaklar = new Stack();
            Tabaklar.Push(5);
            Tabaklar.Push(15);
            Tabaklar.Push(88);
            Tabaklar.Push(7);

            Console.WriteLine("Yığınımızın İlk Hali => ");
            EkranaYaz(Tabaklar);
            // pop tabağı çıkartırız.
            int sayi = (int)Tabaklar.Pop();
            Console.WriteLine("\nTabaktan {0} sayısını aldık.", sayi);
            sayi = (int)Tabaklar.Pop();
            Console.WriteLine("\nTabaktan {0} sayısını aldık.", sayi);
            // peek tabağı çıkartmaz sadece en üstteki tabağı gösterir.
            sayi = (int)Tabaklar.Peek();
            Console.WriteLine("\nEn tepedeki tabak => {0} ", sayi);
            Console.ReadLine();
        }
    }
}
