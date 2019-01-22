using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriyel_Hesaplama_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayı, carpım = 1;
        baska:
            Console.Write("Faktöriyeli Hesaplanacak Sayıyı Giriniz => ");
            sayı = Int32.Parse(Console.ReadLine());
            if ((sayı < 0) || (sayı == 0))
            {
                Console.WriteLine("Başka bir sayı giriniz... \n");
                goto baska;
            }
            Console.WriteLine();
            for (int i = 1; i <= sayı; i++)
            {
                carpım = carpım * i;
                Console.WriteLine(carpım);
            }
            Console.ReadLine();
        }
    }
}
