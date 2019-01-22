using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohm_Kanunu_Gerilim_Hesaplama_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            double iletkenin_direnci, akım;
            double gerilim = 0;
            Console.Write("İletkenin Direncini Giriniz => ");
            iletkenin_direnci = double.Parse(Console.ReadLine());
            Console.Write("İletkenden Geçen Akım Değerini Giriniz => ");
            akım = double.Parse(Console.ReadLine());
            gerilim = akım * iletkenin_direnci;
            Console.WriteLine("İletkenin Uçlarındaki Gerilim => {0}", gerilim);
            Console.ReadLine();
        }
    }
}
