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

            int donendeger = toplamDondur(5, 12);
            Console.WriteLine(donendeger);
            string Donenisim = isimSoyisimDondur("Ramazan..", "Aydın..");
            Console.WriteLine(Donenisim);

            static int toplamDondur(int x, int y)
            {
                int sonuc = x + y;
                return sonuc;
            }

            static string isimSoyisimDondur(string isim, string soyisim)
            {

                return isim + " " + soyisim;
            }



        }

    }
}