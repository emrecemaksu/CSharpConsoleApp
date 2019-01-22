using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue_Sınıfı_Ornegi
{
    class Program
    {
        public static void EkranaYaz(Queue Otobus)
        {
            IEnumerator numara = Otobus.GetEnumerator();
            while (numara.MoveNext())
                Console.WriteLine("\t" + numara.Current);
        }
        static void Main(string[] args)
        {
            Queue Otobus = new Queue();

            Otobus.Enqueue("Emre");
            Otobus.Enqueue("Cem");
            Otobus.Enqueue("Ecem");
            Otobus.Enqueue("Ferit");

            EkranaYaz(Otobus);
            string isim = (string)Otobus.Dequeue();
            Console.WriteLine("Otobüsten İlk Çıkan => {0} ", isim);
            isim = (string)Otobus.Dequeue();
            Console.WriteLine("Otobüsten Çıkan => {0} ", isim);
            isim = (string)Otobus.Peek();
            Console.WriteLine("Otobüsten Çıkacak Olan => {0} ", isim);
            Console.ReadLine();
        }
    }
}
