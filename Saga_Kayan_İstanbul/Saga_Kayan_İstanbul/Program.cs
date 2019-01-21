using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saga_Kayan_İstanbul
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.SetCursorPosition(3 * i, i);
                Console.Write("İstanbul");
            }
            Console.ReadLine();
        }
    }
}
