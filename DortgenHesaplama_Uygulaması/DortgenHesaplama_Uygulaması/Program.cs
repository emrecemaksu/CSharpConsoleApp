using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortgenHesaplama_Uygulaması
{
    class Dortgen
    {
        public double En;
        public double Boy;
        public double Alan()
        {
            double Alan = En * Boy;
            return Alan;
        }
        public void EnBoyBelirle(double en, double boy)
        {
            if (en < 0 || boy < 0)
            {
                En = 0;
                Boy = 0;
            }
            else
            {
                En = en;
                Boy = boy;
            }
        }
        public void EnBoyAlanYaz()
        {
            Console.WriteLine("Dörtgenin Alanı => {0}", Alan());
            Console.WriteLine("Dörtgenin Eni => {0}", En);
            Console.WriteLine("Dörtgenin Boyu => {0}", Boy);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dortgen d1 = new Dortgen();
            d1.EnBoyBelirle(12, 45);
            d1.EnBoyAlanYaz();
            Console.WriteLine("\n*****************");
            Dortgen d2 = new Dortgen();
            d2.EnBoyBelirle(13, 12);
            d2.EnBoyAlanYaz();
            Console.ReadLine();
        }
    }
}
