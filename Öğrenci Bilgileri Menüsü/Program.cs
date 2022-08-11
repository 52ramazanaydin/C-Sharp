using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*              1 - Öğrenci bilgilerini göster .
                2 - Öğrenci ortalamasını göster .
                3 - Öğrenci okulunu göster .
                4 - Çıkış yap .
 * 
 */

namespace ÖğrenciBilgileriMenüsü
{
    class Program
    {

        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(123231, "Ramazan", "Aydın", 54, 65, 72, "İlkokul");

            Console.WriteLine("Uygulamamıza Hoşgeldiniz ... Yapmak istedğiniz işlemi seçin  : ");

            while (kontrol)
            {
                islemleriGoster();
                string secim = Console.ReadLine();
                Console.WriteLine("*************************************");

                switch (secim)
                {
                    case "1":
                        ogrenci1.OgrenciBilgileriGoster();
                        break;
                    case "2":
                        double ogrenciOrtalama = ogrenci1.ogrencinotuBul();
                        Console.WriteLine("Öğrenci ortalamasını göster : " + ogrenciOrtalama);
                        break;
                    case "3":
                        ogrenci1.okulGetir();
                        break;
                    case "4":
                        kontrol = false;
                        break;
                        Console.WriteLine("*************************************");

                }


            }


            static void islemleriGoster()

            {
                Console.WriteLine("1 - Öğrenci bilgilerini göster .");
                Console.WriteLine("2 - Öğrenci ortalamasını göster .");
                Console.WriteLine("3 - Öğrenci okulunu göster .");
                Console.WriteLine("4 - Çıkış yap .");
            }

        }

    }
}