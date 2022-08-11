using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrtalamaHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan sayı al 0 dan aldığımız sayıya kadar topla 
            //  girdiği sayıya böl. Ortalama 50den büyükse BÜYÜK DEğilse KÜÇÜK yaz

            Console.WriteLine("Sayıyı girin :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            double ortalama = 0;
            int topla = 0;

            for (int i = 0; i < sayi; i++)
            {
                topla += i;
            }


            ortalama = topla / sayi;
            if (ortalama > 50)
            {
                Console.WriteLine("Ortalama 50'den büyüktür ..");
                Console.WriteLine("Ortalama : " + ortalama);
            }
            else
            {

                Console.WriteLine("Ortalama 50'den küçüktür ..");
                Console.WriteLine("Ortalama : " + ortalama);
            }
        }

    }
}