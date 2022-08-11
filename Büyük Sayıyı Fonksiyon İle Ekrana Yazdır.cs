using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BüyükSayıyıFonksiyonİleEkranaYazdır
{
    class Program
    {
        static void Main(string[] args)
                     
        {
            // Kullanıcıdan 2 tane sayı al büyük olanı ekrana yaz fonksiyon ile

            Console.WriteLine("Lütfen 2 tane sayı girin :");
            int xsayisi = Convert.ToInt32(Console.ReadLine());
            int ysayisi = Convert.ToInt32(Console.ReadLine());
            buyukOlanıBul(xsayisi, ysayisi);

            static void buyukOlanıBul(int sayi1, int sayi2)
            {
                if (sayi1 > sayi2)
                {
                    Console.WriteLine("Sayi1 büyüktür" + sayi1);
                }
                else
                {
                    Console.WriteLine("Sayi2 büyüktür" + sayi2);
                }
            }



        }

    }
}