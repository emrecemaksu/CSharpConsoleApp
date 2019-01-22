using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struck_Örneği_1
{
    class Program
    {
        public struct Karmasık
        {
            public int a, b;
            public Karmasık(int Gerçel, int Sanal)
            {
                a = Gerçel;
                b = Sanal;
            }
        }

        static void Main(string[] args)
        {
            Karmasık sayi1 = new Karmasık();
            Karmasık sayı2 = new Karmasık(1, 2);
            Console.Write("1. Karmaşık Sayı :");
            Console.WriteLine("z= {0} + j{1}", sayi1.a, sayi1.b);
            Console.Write("2. Karmaşık Sayı :");
            Console.WriteLine("z= {0} + j{1}", sayı2.a, sayı2.b);
            Console.ReadLine();
        }
    }
}
