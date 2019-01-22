using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İki_Notun_Ortalaması_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int not1, not2;
            Console.WriteLine("Birinci Notu Giriniz:");
            not1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("İkinci Notu Giriniz:");
            not2 = Int32.Parse(Console.ReadLine());
            int Ort = (not1 + not2) / 2;
            Console.WriteLine("İki Notun Ortalaması:{0}", Ort);
            Console.ReadLine();
        }
    }
}
