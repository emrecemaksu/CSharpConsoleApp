using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_seklinde_istanbul
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.SetCursorPosition((2 * i) + 1, i);
                Console.Write("İstanbul");
                Console.SetCursorPosition(44 - (i * 2), i);
                Console.Write("İstanbul");
            }
            Console.ReadLine();
        }
    }
}
