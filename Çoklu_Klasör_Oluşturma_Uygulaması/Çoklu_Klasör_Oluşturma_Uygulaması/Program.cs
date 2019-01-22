using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Çoklu_Klasör_Oluşturma_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            string adi;
            Console.Write("Kaç Klasör Oluşturulacaktır => ");
            sayi = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                Console.Write("Klasör Adını Giriniz => ");
                adi = Console.ReadLine();
                Directory.CreateDirectory(adi);
            }
            Console.ReadLine();
        }
    }
}
