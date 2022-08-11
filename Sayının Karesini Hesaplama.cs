using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SayınınKaresiniHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {

            //kullanıcıdan sayı al karesini hesapla
            //karesi 25ten büyükse 25ten büyük yaz, küçükse kucuk yaz.


            Console.WriteLine("Karesini almak istediğiniz değeri girin :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int kare_deger = kareHesapla(sayi);
            if (kare_deger > 25)
            {
                Console.WriteLine("Kare 25'ten büyüktür ...Kare ==: " + kare_deger);
            }
            else
            {
                Console.WriteLine("25ten küçük" + kare_deger);
            }
            static int kareHesapla(int sayi1)
            {

                return sayi1 * sayi1;
            }



        }

    }
}