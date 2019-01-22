using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daire_Dilimin_Alanını_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            double yarıcap, acı;
            Double alan = 0;
            Console.Write("Dairenin Yarıçapını Giriniz => ");
            yarıcap = double.Parse(Console.ReadLine());
            Console.Write("Daire Diliminin Açısını Giriniz => ");
            acı = double.Parse(Console.ReadLine());
            alan = (Math.PI * Math.Pow(yarıcap, 2) * acı) / 360;
            Console.Write("Daire Diliminin Alanı => {0}", alan);
            Console.ReadLine();
        }
    }
}
