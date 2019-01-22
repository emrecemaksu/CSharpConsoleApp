using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeli_Uygulaması
{
    class Memeli
    {
        protected double mBoy;
        protected double mAgirlik;
        public double Boy
        {
            get { return mBoy; }
            set { mBoy = value; }
        }
        public double Agirlik
        {
            get { return mAgirlik; }
            set { mAgirlik = value; }
        }
        public Memeli(double boy, double agirlik)
        {
            this.mBoy = boy;
            this.mAgirlik = agirlik;
        }
        public void OzellikGoster()
        {
            Console.WriteLine("Boy = " + mBoy);
            Console.WriteLine("Ağırlık = " + mAgirlik);
        }
    }
    class Kedi : Memeli
    {
        public string Turu;
        public Kedi(string turu, int boy, int agirlik) : base(boy, agirlik)
        {
            this.Turu = turu;
        }
        public void TurGoster()
        {
            Console.WriteLine(Turu + " Kedisi");
        }
    }
    class Koyun : Memeli
    {
        public string Turu;
        public Koyun(string turu, int boy, int agirlik) : base(boy, agirlik)
        {
            this.Turu = turu;
        }
        public void TurGoster()
        {
            Console.WriteLine(Turu + " Koyun");
        }
    }
    class Program
    {
        public static void Goster(Memeli memeli)
        {
            Console.WriteLine("Boy = " + memeli.Boy);
            Console.WriteLine("Ağırlık = " + memeli.Agirlik + "\n");
        }
        static void Main(string[] args)
        {
            Memeli memeli1 = new Memeli(10, 35);
            Goster(memeli1);
            Kedi boncuk = new Kedi("Van", 5, 10);
            Goster(boncuk);
            Koyun doli = new Koyun("Ağrı", 52, 70);
            Console.ReadLine();
        }
    }
}
