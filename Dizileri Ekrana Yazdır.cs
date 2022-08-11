using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DizileriEkranaYazdır
{
    class Program
    {
        static void Main(string[] args)
        {
            // dizinin elemanını kullanıcıdan al ekrana yazdır 
            int[] sayilar = new int[4];
            for (int i = 0; i < sayilar.Length; i++)
            {


                Console.WriteLine("Dizinin " + (i + 1) + ".inci değerini girin");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("**************************");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();
        }

    }
}