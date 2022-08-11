using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ÇiftSayıTekSayıKontrolü
{
    class Program
    {
        static void Main(string[] args)
        {
              /*Kullanıcıdan 10 tane sayı al
              * 1 Kaç tane tek çift var  
              * 2 Tek değerlerin toplamı çift değerlerin toplamı
              * 3 çift büyükse çiftlerin toplamı büyük , tek büyükse teklerin toplamı büyük yazdır.
              */

            Console.WriteLine("Lütfen 10 adet sayı girin :");
            int cift_adet_toplam = 0;
            int tek_adet_toplam = 0;
            int cift_sayi_toplam = 0;
            int tek_sayi_toplam = 0;

            int[] sayilar = new int[10];
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                {
                    cift_adet_toplam++;
                    cift_sayi_toplam += sayilar[i];
                }
                else
                {
                    tek_adet_toplam++;
                    tek_sayi_toplam += sayilar[i];
                }
            }

            Console.WriteLine(cift_adet_toplam + " tane çift sayi var");
            Console.WriteLine(tek_adet_toplam + " tane tek sayi var");

            Console.WriteLine("çift sayıların toplamı = " + cift_sayi_toplam);
            Console.WriteLine("tek sayıların toplamı = " + tek_sayi_toplam);



            if (cift_sayi_toplam > tek_sayi_toplam)
            {
                Console.WriteLine("Çift sayıların toplamı tek sayıların toplamından büyüktür.");
            }

            else if ((cift_sayi_toplam == tek_sayi_toplam))
            {
                Console.WriteLine("Çift sayıların toplamı tek sayıların toplamına eşittir.");
            }

            else
            {
                Console.WriteLine("Çift sayıların toplamı tek sayıların toplamından küçüktür.");
            }

        }

    }
}