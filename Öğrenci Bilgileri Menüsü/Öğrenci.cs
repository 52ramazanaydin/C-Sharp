using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖğrenciBilgileriMenüsü
{
    public class Ogrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyisim;
        private int Vize1;
        private int Vize2;
        private int Final;
        private string Okulismi;

        public Ogrenci(int _ogrenciNo, string _isim, string _soyisim, int _Vize1, int _Vize2, int _Final, string _Okulismi)
        {
            ogrenciNo = _ogrenciNo;
            isim = _isim;
            soyisim = _soyisim;
            Vize1 = _Vize1;
            Vize2 = _Vize2;
            Final = _Final;
            Okulismi = _Okulismi;




        }
        public void OgrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrencinin Numarası : " + ogrenciNo);
            Console.WriteLine("Öğrencinin İsmi : " + isim);
            Console.WriteLine("Öğrencinin Soyismi : " + soyisim);
            Console.WriteLine("Öğrencinin Vize 1  : " + Vize1);
            Console.WriteLine("Öğrencinin Vize 2 : " + Vize2);
            Console.WriteLine("Öğrencinin Finali  : " + Final);
            Console.WriteLine("Öğrencinin Okul ismi : " + Okulismi);

        }

        public double ogrencinotuBul()
        {
            double ortalama = Vize1 * 0.2 + Vize2 * 0.2 + Final * 0.6;

            return ortalama;
        }

        public void okulGetir()
        {
            Console.WriteLine("Okulun İsmi" + Okulismi);
        }
    }
}
