using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ÇiftSayıTekSayıKontrolü
{
    class Program
    {
        static void Main(string[] args)
        {
            ToplamaYap(7, 8);
            Carpma_yap(2, 5, 2);
            isim_soyisim_yazdır("Ramazan", "Aydın");

            static void ToplamaYap(int x, int y)
            {

                Console.WriteLine("Toplama sonucu :" + (x + y));
            }
            static void Carpma_yap(int x, int y, int z)
            {
                Console.WriteLine("Çarpma Sonucu :" + (x * y * z));
            }
            static void isim_soyisim_yazdır(string isim, string soyisim)
            {
                Console.WriteLine("Ad Soyad :" + isim + " " + soyisim);
            }

        }

    }
}