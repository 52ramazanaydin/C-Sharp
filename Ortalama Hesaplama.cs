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
            //notların ortalamasını alan ve harf notu veren sistem

            int i = 0;
            while (i < 3)
            {

                Console.Write("Lütfen ilk notunuzu girin : ");
                int ilk_not = Convert.ToInt32(Console.ReadLine());
                Console.Write("Lütfen ikinci notunuzu girin : ");
                int ikinci_not = Convert.ToInt32(Console.ReadLine());
                Console.Write("Lütfen üçüncü notunuzu girin : ");
                int ucuncu_not = Convert.ToInt32(Console.ReadLine());
                int sonuc = (ilk_not + ikinci_not + ucuncu_not);

                int avg = sonuc / 3;
                Console.WriteLine("Notların ortalaması: " + avg);
                if (avg <= 100 && avg >= 80)
                {
                    Console.WriteLine("A+");

                }
                else if (avg <= 80 && avg >= 60)
                {
                    Console.WriteLine("A-");

                }
                else if (avg <= 60 && avg >= 40)
                {
                    Console.WriteLine("B");

                }
                else
                {
                    Console.WriteLine("F");
                }
                i++;
            }
        }
    }
}
