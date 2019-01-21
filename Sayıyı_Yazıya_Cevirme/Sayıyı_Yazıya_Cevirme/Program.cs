using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayıyı_Yazıya_Cevirme
{
    class Program
    {
        static void Main(string[] args)
        {
            var birler = new[] { "sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            var onlar = new[] { "sıfır", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
        baska:
        git:
            Console.Write("Tam Sayıyı Giriniz => ");
            int sayı = Int32.Parse(Console.ReadLine());
            if (sayı > 1000000000)
            {
                Console.WriteLine("Sayı 1000000000 'dan büyüktür başka bir sayı giriniz... ");
                goto baska;
            }
            if (sayı < 0)
            {
                Console.WriteLine("Sayı eksidir. Lütfen başka bir sayı giriniz...");
                goto git;
            }
            Console.WriteLine();
            if (sayı == 0)
            {
                Console.WriteLine("Sıfır ");
                goto git2;
            }
            string yazı = " ";
            if ((sayı / 1000000) > 0)
            {
                yazı += (birler[sayı / 1000000]) + " milyon ";
                sayı %= 1000000;
            }
            if ((sayı / 100000) > 0)
            {
                yazı += (birler[sayı / 100000]) + " yüz ";
                sayı %= 100000;
            }
            if ((sayı / 10000) > 0)
            {
                yazı += (onlar[sayı / 10000]) + " ";
                sayı %= 10000;
            }
            if ((sayı / 1000) > 0)
            {
                yazı += (birler[sayı / 1000]) + " bin ";
                sayı %= 1000;
            }
            if ((sayı / 100) > 0)
            {
                yazı += (birler[sayı / 100]) + " yüz ";
                sayı %= 100;
            }
            if (sayı > 0)
            {
                if (sayı < 10)
                    yazı += birler[sayı];
                else
                {
                    yazı += onlar[sayı / 10];
                    if ((sayı % 10) > 0)
                        yazı += " " + birler[sayı % 10];
                }
            }
            Console.Write("Tam Sayının Yazı İle Yazılmış Hali => {0}", yazı);
        git2:
            Console.ReadLine();
        }
    }
}

