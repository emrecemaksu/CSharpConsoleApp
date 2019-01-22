using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrediHesabim_Uygulaması
{
    class KrediHesabim
    {
        public ulong HesapNo;
        public string AdSoyad;
        public double Limit;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //hesap1 adlı Nesne Tanımlıyoruz...
            KrediHesabim hesap1 = new KrediHesabim();
            //Sınıf üyelerine değerlerini atıyoruz....
            hesap1.AdSoyad = "Emre Cem Aksu";
            hesap1.HesapNo = 1011121314;
            hesap1.Limit = 1000;
            //Nesnenin özelliklerini ekrana yazdırıyoruz...
            Console.WriteLine("Kredi Kartı Sahibi => {0}", hesap1.AdSoyad);
            Console.WriteLine("Hesap Numarası => {0}", hesap1.HesapNo);
            Console.WriteLine("Hesabın Limiti => {0}", hesap1.Limit);
            Console.ReadLine();
        }
    }
}
