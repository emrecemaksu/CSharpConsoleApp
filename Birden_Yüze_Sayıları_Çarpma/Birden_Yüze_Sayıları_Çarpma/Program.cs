using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birden_Yüze_Sayıları_Çarpma
{
    class Program
    {
        static void Main(string[] args)
        {
            double carpım = 1;
            for (int i = 1; i < 101; i++)
            {
                carpım = carpım * i;
                Console.WriteLine(carpım);
            }
            Console.ReadLine();
        }
    }
}
