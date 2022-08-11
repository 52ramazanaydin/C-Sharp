using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    public class Personel
    {
        public string name;
        public int id;
        public string surname;

        public static int yas;


        public static void isimSoyisimYaz()
        {
            Console.WriteLine("Ramazan AYDIN..");
        }

        public static void topla(int sayi1, int sayi2)
        {
            Console.WriteLine("iki sayinin toplamı : " + (sayi1 + sayi2));
        }
    }
}
