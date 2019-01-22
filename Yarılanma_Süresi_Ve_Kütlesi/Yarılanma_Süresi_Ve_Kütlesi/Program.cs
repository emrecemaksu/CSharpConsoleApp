using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarılanma_Süresi_Ve_Kütlesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double kütle, yarılanma_süresi, süre;
            double kalan_kütle = 0, yarılanma_sayısı = 0;
            Console.Write("Radyoaktif Elementin Başlangıç Kütlesini Giriniz => ");
            kütle = double.Parse(Console.ReadLine());
            Console.Write("Elementin Yarılanma Süresini Giriniz => ");
            yarılanma_süresi = double.Parse(Console.ReadLine());
            Console.Write("Yarılanmak İçin Geçecek Süreyi Giriniz => ");
            süre = double.Parse(Console.ReadLine());
            yarılanma_sayısı = süre / yarılanma_süresi;
            kalan_kütle = kütle / Math.Pow(2, yarılanma_sayısı);
            Console.WriteLine("Yarılanma Sayısı => {0}", yarılanma_sayısı);
            Console.WriteLine("Elementin Kalan Kütlesi => {0}", kalan_kütle);
            Console.ReadLine();
        }
    }
}
