using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortList_Sınıfı_Ornegi
{
    class Program
    {
        public static void EkranaYaz(SortedList sList)
        {
            foreach (DictionaryEntry to in sList)
                Console.WriteLine("{0,-12} : {0,-12}", to.Key, to.Value);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string[] Kelimeler = { "Araba", "Masa", "Defter", "Kitap", "Okul" };
            SortedList Sozluk = new SortedList();
            Sozluk.Add("Araba", "Car");
            Sozluk.Add("Masa", "Table");
            Sozluk.Add("Kalem", "Pencil");
            Sozluk["Kitap"] = "Book";
            Sozluk["Bilgisayar"] = "Computer";

            EkranaYaz(Sozluk);

            for (int i = 0; i < Kelimeler.Length; i++)
                if (Sozluk.ContainsKey(Kelimeler[i]))
                    Console.WriteLine(Kelimeler[i] + " = " + Sozluk[Kelimeler[i]]);
                else
                    Console.WriteLine(Kelimeler[i] + ", sözlükte bulunamadı... ");
            Console.WriteLine();
            Sozluk.Add("Doğru", "Line");
            EkranaYaz(Sozluk);
            Console.WriteLine();
            Console.WriteLine("Sözlükteki Kelimeler => ");
            ICollection anahtarlar = Sozluk.Keys;
            foreach (string str in anahtarlar)
                Console.Write(str + "-");
            Console.ReadLine();
        }
    }
}
