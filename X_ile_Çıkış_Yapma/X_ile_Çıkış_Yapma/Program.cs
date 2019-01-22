using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_ile_Çıkış_Yapma
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad;
            ConsoleKeyInfo h;
            Console.Write("\nMerhaba ");
            ad = Console.ReadLine();
            do
            {
                Console.Write("Çıkış Yapmak İçin x Tuşuna Basınız.. : ");
                h = Console.ReadKey();
            }
            while (h.KeyChar != 'x');
        }
    }
}
