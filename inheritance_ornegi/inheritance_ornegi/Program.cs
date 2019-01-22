using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_ornegi
{
    class Memeli
    {
        public double Boy;
        public double Agirlik;
        public void OzellikGoster()
        {
            Console.WriteLine("Boy => " + Boy);
            Console.WriteLine("Ağırlık => " + Agirlik);
        }
    }
    class Kedi : Memeli
    {
        public string Turu;
        public void TurGoster()
        {
            Console.WriteLine("Tür => " + Turu);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kedi pati = new Kedi();
            pati.Agirlik = 3.46;
            pati.Boy = 30;
            pati.Turu = "Siyam";

            pati.OzellikGoster();
            pati.TurGoster();

            Console.WriteLine("******************");

            Kedi boncuk = new Kedi();
            boncuk.Agirlik = 3;
            boncuk.Boy = 25;
            boncuk.Turu = "Sokak Kedisi";

            boncuk.TurGoster();
            boncuk.OzellikGoster();
            Console.ReadLine();
        }
    }
}
