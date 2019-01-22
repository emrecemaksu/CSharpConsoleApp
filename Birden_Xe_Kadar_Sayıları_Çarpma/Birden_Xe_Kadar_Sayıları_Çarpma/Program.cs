using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birden_Xe_Kadar_Sayıları_Çarpma
{
    class Program
    {
        static void Main(string[] args)
        {
            double adet, carpım = 1;
            Console.WriteLine("Çarpılacak Sayıyı Gİriniz :");
            adet = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < adet; i++)
            {
                carpım = carpım * i;
                Console.WriteLine(carpım);
            }
            Console.ReadLine();
        }
    }
}
