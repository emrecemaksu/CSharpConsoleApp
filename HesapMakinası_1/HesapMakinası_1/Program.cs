using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinası_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float sayı1, sayı2;
            string Islem;
            Console.WriteLine("Birinci Sayıyı Girin :");
            sayı1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Girin : ");
            sayı2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("***************");
            Console.WriteLine("\nÇıkartma İşlemi İçin -'ye basın.. --> -");
            Console.WriteLine("Toplama İşlemi İçin +'ya basın.. --> +");
            Console.WriteLine("Çarpma İşlemi İçin *'ya basın.. --> *");
            Console.WriteLine("Bölme İşlemi İçin /'a basın.. --> / \n");
            Console.WriteLine("***************");

            Console.WriteLine("\nİşleminizi Seçin :");
            Islem = Console.ReadLine();

            if (Islem == "-")
            {
                float Cıkartma = sayı1 - sayı2;
                Console.WriteLine("Çıkartma İşleminin Sonucu : {0}", Cıkartma);
            }

            else if (Islem == "+")
            {
                float Toplama = sayı1 + sayı2;
                Console.WriteLine("Toplama İşleminin Sonucu : {0}", Toplama);
            }

            else if (Islem == "/")
            {
                float Bolme = sayı1 / sayı2;
                if (sayı2 == 0)
                {
                    Console.WriteLine("Bölen 0 olamaz...");
                }
                else if (sayı2 != 0)
                {
                    Console.WriteLine("Bölme İşleminin Sonucu : {0}", Bolme);
                }
            }

            else if (Islem == "*")
            {
                float Carpma = sayı1 * sayı2;
                Console.WriteLine("Çarpma İşleminin Sonucu :{0}", Carpma);
            }

            Console.ReadLine();
        }
    }
}
