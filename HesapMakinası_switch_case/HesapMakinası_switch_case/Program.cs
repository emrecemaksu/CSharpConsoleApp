using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinası_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı1, sayı2;
            string Islem;
            Console.WriteLine("İlk Sayıyı Girin :");
            sayı1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Girin :");
            sayı2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("*******************");
            Console.WriteLine("\nToplama İşlemi İçin +'ya basınız.. --> +");
            Console.WriteLine("Çıkartma İşlemi İçin -'ye basınız.. --> -");
            Console.WriteLine("Çarpma İşlemi İçin *'ya basınız.. --> *");
            Console.WriteLine("Bölme İşlemi İçin /'ye basınız.. --> / \n");
            Console.WriteLine("*******************");

            Console.WriteLine("İşleminizi Girin :");
            Islem = Console.ReadLine();

            switch (Islem)
            {
                case "*":
                    float Carpım = sayı1 * sayı2;
                    Console.WriteLine("Çarpım İşleminin Sonucu :{0}", Carpım);
                    break;

                case "/":
                    switch (sayı2)
                    {
                        case 0:
                            Console.WriteLine("Bölen 0 Olamaz...");
                            break;
                        case 1:
                            float Bolme = sayı1 / sayı2;
                            Console.WriteLine("Bölme İşleminin Sonucu :{0}", Bolme);
                            break;
                    }
                    break;

                case "+":
                    float Toplam = sayı1 + sayı2;
                    Console.WriteLine("Toplama İşleminin Sonucu : {0}", Toplam);
                    break;

                case "-":
                    float Cıkartma = sayı1 - sayı2;
                    Console.WriteLine("Çıkartma İşleminin Sonucu : {0}", Cıkartma);
                    break;
            }
            Console.ReadLine();
        }
    }
}
