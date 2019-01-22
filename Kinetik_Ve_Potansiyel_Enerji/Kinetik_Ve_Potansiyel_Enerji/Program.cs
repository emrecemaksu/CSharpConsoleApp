using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinetik_Ve_Potansiyel_Enerji
{
    class Program
    {
        static void Main(string[] args)
        {
            double kütle, hız, yükseklik;
            const double g = 9.18;
            double kinetik = 0, potansiyel = 0;
            Console.Write("Cismin Kütlesini Giriniz => ");
            kütle = double.Parse(Console.ReadLine());
            Console.Write("Cismin Hızını Giriniz => ");
            hız = double.Parse(Console.ReadLine());
            Console.Write("Cismin Yerden Yüksekliği Giriniz => ");
            yükseklik = double.Parse(Console.ReadLine());
            potansiyel = kütle * g * yükseklik;
            kinetik = (kütle * Math.Pow(hız, 2)) / 2;
            Console.WriteLine("Cismin Kinetik Enerjisi => {0}", kinetik);
            Console.WriteLine("Cismin Potansiyel Enerjisi => {0}", potansiyel);
            Console.ReadLine();
        }
    }
}
