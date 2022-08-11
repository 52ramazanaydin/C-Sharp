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
            // Dizinin maximum elemanını bulan fonksiyon

            int[] sayidizisi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12312, 6756756, 1 };
            Console.WriteLine(Max(sayidizisi));
            static int Max(int[] sayilar)
            {
                int buyuk = sayilar[0];

                for (int i = 0; i < sayilar.Length; i++)
                {
                    if (buyuk < sayilar[i])
                    { buyuk = sayilar[i]; }
                }

                return buyuk;
            }



        }

    }
}