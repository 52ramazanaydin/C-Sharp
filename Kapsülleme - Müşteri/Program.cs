using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Kapsülleme
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Property(Özellik)
            Musteri musteri1 = new Musteri();
            musteri1.KİLO = 85;  // Değer ataması var o yüzden set çalışır.

            Console.WriteLine(musteri1.KİLO); // get çalışır.
        }
    }

}