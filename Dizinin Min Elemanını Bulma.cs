using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DizininMinElemanınıBulma
{
    class Program
    {
        static void Main(string[] args)
                     
        {
            int[] sayidizisi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12312, 6756756, -15 };
            Console.WriteLine(Min(sayidizisi));
            static int Min(int[] sayilar)
            {
                int kucuk = sayilar[0];

                for (int i = 0; i < sayilar.Length; i++)
                {
                    if (kucuk > sayilar[i])
                    { kucuk = sayilar[i]; }
                }
                return kucuk;
            }



        }

    }
}