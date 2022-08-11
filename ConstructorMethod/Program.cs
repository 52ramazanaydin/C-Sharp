using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConstructorMethod
{
    class Program
    {
        static void Main(string[] args)
                     
        {
            Araba araba1 = new Araba();

            araba1.kapiSayisi = 4;
            araba1.arabaRengi = "Mavi";
            araba1.arabaModel = "Honda";

            araba1.MotorCalistir();
            araba1.kapilarKilitle();

            Console.WriteLine("Arabanın kapı sayısı : " + araba1.kapiSayisi);
            Console.WriteLine("Arabanın rengi : " + araba1.arabaRengi);
            Console.WriteLine("Arabanın modeli : " + araba1.arabaModel);




        }

    }
}