using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DizilerdeElemanKontrolü
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının girdiği sayı dizide var mı kontrol et ? Varsa kaç tane var ekrana yaz, yoksa ekrana yok yaz.
            int[] sayilar = { 20, 30, 30, 40, 40, 40, 70, 80, 80, 80, 80, 100 };
            int adet = 0;
            int sayi;

            Console.WriteLine("aramak istediğiniz sayiyi girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayi == sayilar[i])
                {
                    adet++;

                }

            }

            if (adet == 0)
            {
                Console.WriteLine("sayi bu dizide yok");
            }

            else
            {
                Console.WriteLine("sayi bu dizide ," + adet + "tane var");
            }

        }

    }
}