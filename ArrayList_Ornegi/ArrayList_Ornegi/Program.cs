using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList_Ornegi
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Liste = new ArrayList();

            Liste.Add("Emre Cem Aksu");
            Liste.Add(10);
            Liste.Add('A');
            Liste.Add(false);
            EkranaYaz(Liste);
            Console.WriteLine();
            Liste.Remove(10);
            Liste.Add(11);
            Liste.Add("Microsoft");
            Liste.Remove('A');

            EkranaYaz(Liste);
            Console.WriteLine("\nListe Kapasitesi => {0}", Liste.Capacity);
            Console.ReadLine();
        }

        public static void EkranaYaz(ArrayList Getir)
        {
            foreach (object j in Getir)
                Console.Write(j.ToString() + " ");
        }
    }
}
