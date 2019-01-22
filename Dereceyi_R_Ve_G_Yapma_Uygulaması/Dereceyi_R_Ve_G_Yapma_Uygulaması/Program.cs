using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dereceyi_R_Ve_G_Yapma_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo h;
            double derece, grad = 0, radyan = 0;
            Console.Write("Açının Derecesini Giriniz => ");
            derece = double.Parse(Console.ReadLine());
            grad = (derece * 3.14) / 180;
            radyan = (derece * 200) / 180;
            Console.WriteLine("Derecenin Grad Eşiti => {0} 'dır...", grad);
            Console.WriteLine("Derecenin Radyan Eşiti => {0} 'dır...", radyan);
            Console.WriteLine("Çıkmak İçin x'e Basınız... => ");
            h = Console.ReadKey();
            while (h.KeyChar != 'x') ;
        }
    }
}
