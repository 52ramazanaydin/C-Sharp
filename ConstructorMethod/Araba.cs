using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethod
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRengi;

        public Araba()//Constructor method
        {
            //ctor tab tab ile olusturulabilir.
            Console.WriteLine("Constructor method çalıştırılıyor..");
        }

        public void MotorCalistir()
        {
            Console.WriteLine("Motor Çalıştırılıyorr...!!");
        }

        public void kapilarKilitle()
        {
            Console.WriteLine("Kapılar Kilitleniyor..!");


        }
    }
}
