using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizinin_İndislerini_Toplayan_Uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            Console.Write("Dizinin Toplam İndis Sayısını Giriniz => ");
            int indis = Int32.Parse(Console.ReadLine());
            int[] Dizi = new int[indis];
            for (int i = 0; i < Dizi.Length; i++)
            {
                Console.Write("\n{0}. İndisin Değerini Giriniz => ", i);
                Dizi[i] = Int32.Parse(Console.ReadLine());
                toplam += Dizi[i];
            }
            Console.WriteLine("\n***************\n");
            Console.Write("Dizi İndisleri Toplamı => {0}", toplam);
            Console.ReadLine();
        }
    }
}
