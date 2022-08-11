using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Kapsülleme
{
    class Program
    {
        static void Main(string[] args)
        {

            Personel.isimSoyisimYaz();
            Personel.topla(89, 85);

            Personel p1 = new Personel();
            p1.id = 123321;
            p1.name = "ramo";
            p1.surname = "asdasda";
            Personel.yas = 23;

            Console.WriteLine("id :" + p1.id);
            Console.WriteLine("id :" + p1.name);
            Console.WriteLine("id :" + p1.surname);
            Console.WriteLine("id :" + Personel.yas);
        }
    }

}