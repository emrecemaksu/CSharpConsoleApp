using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace istanbul_dik_üçgen
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime = "istanbul";
            Console.WriteLine();
            for (int i = 0; i < kelime.Length; i++)
            {
                Console.WriteLine(kelime.Substring(0, i + 1));
            }
            Console.ReadLine();
        }
    }
}
