using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethod2
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRengi;

        public Araba(int _kapisayisi, string _arabamodel, string _arabarengi)
        {
            kapiSayisi = _kapisayisi;
            arabaModel = _arabamodel;
            arabaRengi = _arabarengi;

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
