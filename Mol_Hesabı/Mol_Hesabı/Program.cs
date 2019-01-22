using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mol_Hesabı
{
    class Program
    {
        static void Main(string[] args)
        {
            double kütle, molekül_ağırlığı;
            double mol_sayısı = 0;
            Console.Write("Molekül Kütlesini Giriniz (m) => ");
            kütle = double.Parse(Console.ReadLine());
            Console.Write("Molekülün 1 Molünün Ağırlığı (Ma) => ");
            molekül_ağırlığı = double.Parse(Console.ReadLine());
            mol_sayısı = kütle / molekül_ağırlığı;
            Console.WriteLine("Mol Sayısı => {0}", mol_sayısı);
            Console.ReadLine();
        }
    }
}
