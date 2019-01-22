using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet_Ornegi
{
    class Program
    {
        private int mEn;
        private int mBoy;
        public int En
        {
            get
            {
                return mEn;
            }
            set
            {
                if (value < 0)
                    mEn = 0;
                else
                    mEn = value;
            }
        }
        public int Boy
        {
            get
            {
                return mBoy;
            }
            set
            {
                if (value < 0)
                    mBoy = 0;
                else
                    mBoy = value;
            }
        }
        public int Alan()
        {
            int Alan = En * Boy;
            return Alan;
        }
        public void EnBoyBelirle(int en, int boy)
        {
            if (en < 0 || boy < 0)
            {
                En = 0;
                Boy = 0;
            }
            else
            {
                En = en;
                Boy = boy;
            }
        }
        public void Yaz()
        {
            Console.WriteLine("*******************");
            Console.WriteLine("En :{0,5}", En);
            Console.WriteLine("Boy : {0,5}", Boy);
            Console.WriteLine("Alan : {0,5}", Alan());
            Console.WriteLine("*******************");
        }
        static void Main(string[] args)
        {
            Program d = new Program();
            d.EnBoyBelirle(20, 50);
            d.Yaz();
            Console.ReadLine();
        }
    }
}
