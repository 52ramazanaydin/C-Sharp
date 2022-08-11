using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.


            Console.WriteLine("Pozitif bir sayı girin :");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("n adet pozitif sayı girin :");
            int nsayisi = Convert.ToInt32(Console.ReadLine());

            int[] dizi = new int[nsayisi];

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 == 0)
                {
                    Console.WriteLine("çift sayıdır " + dizi[i]);
                }
            }

        }
    }
}