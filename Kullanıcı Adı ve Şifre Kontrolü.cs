using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı giriş sayfası uygulaması yap.
            //Kullanıcı adı ve şifresini doğru girerse Tebrikler başarılı giriş yaptnız
            //yanlış girerse hata ver. ve 3 hak verelim kullanıcı yanlış girdiği sürece döngü devam etsin.

            Console.WriteLine("Ramazan'ın Web Sitesine Hoşgeldiniz : ...");

            Console.WriteLine("Kullanıcı Adınızı ve şifrenizi girin: ");
            Console.Write("Kullanıcı adi :");
            string kullanici_adi = Console.ReadLine();
            Console.Write("şifre :");
            string sifre = Console.ReadLine();

            if (kullanici_adi == "Ramazan" && sifre == "123321")
            {
                Console.WriteLine("Tebrikler başarılı giriş yaptınız");
            }
            else
            {
                int i = 0;
                while (i < 2)
                {
                    Console.WriteLine("Kullanıcı adınızı veya şifrenizi yanlış girdiniz");

                    Console.WriteLine("Kullanıcı Adınızı ve şifrenizi girin: ");
                    Console.Write("Kullanıcı adi :");
                    kullanici_adi = Console.ReadLine();
                    Console.Write("şifre :");
                    sifre = Console.ReadLine();
                    if (kullanici_adi == "Ramazan" && sifre == "123321")
                    {
                        Console.WriteLine("Tebrikler başarılı giriş yaptnız");
                        break;
                    }
                    else
                    {
                        Console.Write("Kullanıcı adınızı veya şifrenizi yanlış girdiniz");
                    }

                    i++;

                }

            }

        }
    }
}
