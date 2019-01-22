using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w_ile_harf_harf_istanbul
{
    class Program
    {
        static void Main(string[] args)
        {
            string sehir = "istanbul";
            for (int i = 0; i <= sehir.Length - 1; i++)
            {
                Console.SetCursorPosition(i + 1, i + 1);
                Console.Write(sehir[i]);
                Console.SetCursorPosition(16 - i, i + 1);
                Console.Write(sehir[i]);
                Console.SetCursorPosition(9, i + 1);
                Console.Write(sehir[i]);
            }
            Console.ReadLine();
        }
    }
}
