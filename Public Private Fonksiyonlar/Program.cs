using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PublicPrivateMethod
{
    class Program
    {

        static void Main(string[] args)
        {
            Araba araba1 = new Araba(4, "Honda", "Mavi");



            araba1.MotorCalistir();
            araba1.kapilarKilitle();

            Console.WriteLine("Arabanın kapı sayısı : " + araba1.kapiSayisi);
            Console.WriteLine("Arabanın rengi : " + araba1.arabaModel);
            Console.WriteLine("Arabanın modeli : " + araba1.arabaRengi);
        }

    }
}
