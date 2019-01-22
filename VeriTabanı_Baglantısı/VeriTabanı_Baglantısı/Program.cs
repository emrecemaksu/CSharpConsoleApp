using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace VeriTabanı_Baglantısı
{
    class Program
    {
        static void Main(string[] args)
        {
            string kaynak = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=veri.mdb";
            OleDbConnection bagla = new OleDbConnection(kaynak);
            bagla.Open();
            string sorgu = "select Adı, Soyadı FROM Uyeler";
            OleDbCommand baglanti = new OleDbCommand(sorgu, bagla);
            Console.WriteLine(sorgu);
            Console.WriteLine("Bağlantı Sağlandı....");
            bagla.Close();
            Console.ReadLine();
        }
    }
}
