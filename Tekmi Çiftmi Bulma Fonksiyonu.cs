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
            static void tekmi_ciftmi(int sayi1)
            {
                if (sayi1 % 2 == 0)
                {
                    Console.WriteLine("sayi çifttir ...");
                }
                else
                {
                    Console.WriteLine("sayi tektir ...");
                }

            }
            Console.Write("Sayıyı girin : ");
             int sayi = Convert.ToInt32(Console.ReadLine());
            tekmi_ciftmi(sayi);


        }

    }
}