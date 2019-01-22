using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_I_R_Devre_Sorusu_Örneği
{
    class Program
    {
        static void Main(string[] args)
        {
            double gerilim, r1, r2, r3, r4;
            double akım = 0, r1_direnci = 0, r2_güc;
            Console.Write("Kaynağın Gerilimini Giriniz :");
            gerilim = double.Parse(Console.ReadLine());
            Console.Write("R1 Direncini Giriniz :");
            r1 = double.Parse(Console.ReadLine());
            Console.Write("R2 Direncini Giriniz :");
            r2 = double.Parse(Console.ReadLine());
            Console.Write("R3 Direncini Giriniz :");
            r3 = double.Parse(Console.ReadLine());
            Console.Write("R4 Direncini Giriniz :");
            r4 = double.Parse(Console.ReadLine());
            akım = gerilim / (r1 + r2 + r3 + r4);
            r1_direnci = r1 * akım;
            r2_güc = Math.Pow(akım, 2 * r2);
            Console.WriteLine("Devreden Geçen Akım : {0}", akım);
            Console.Write("R1 Direncinin Gerilimi : {0}", r1_direnci);
            Console.Write("R2 Direncindeki Harcanan Güç : {0}", r2_güc);
            Console.ReadLine();
        }
    }
}
