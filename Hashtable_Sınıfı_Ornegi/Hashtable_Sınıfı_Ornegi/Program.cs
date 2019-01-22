using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hashtable_Sınıfı_Ornegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable Almanca = new Hashtable();
            Almanca.Add("Araba", "Auto");
            Almanca.Add("Beyaz", "Weiss");
            Almanca.Add("Mutfak", "Küche");
            Almanca.Add("Sandalye", "Stuhl");
            Almanca["Dondurma"] = "Eis";
            Almanca["Kapı"] = "Tür";

            ICollection anahtarlar = Almanca.Keys;

            foreach (string anahtar in anahtarlar)
                Console.WriteLine(anahtar + " = " + Almanca[anahtar]);
            Console.WriteLine("Toplam Kelime => {0}", Almanca.Count);
            Console.WriteLine("\n*****************\n");

            IDictionaryEnumerator numara = Almanca.GetEnumerator();

            while (numara.MoveNext())
                Console.WriteLine(numara.Key + " = " + numara.Value);
            Console.WriteLine("Toplam Kelime => {0}", Almanca.Count);
            Console.ReadLine();

        }
    }
}
