using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazıyı_sola_kaydırma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yazıyı Giriniz => ");
            string yazi = Console.ReadLine();
            for (int i = 70; i >= 1; i--)
            {
                Console.SetCursorPosition(i, 15);
                Console.Write(yazi);
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
            }
            Console.ReadLine();
        }
    }
}
