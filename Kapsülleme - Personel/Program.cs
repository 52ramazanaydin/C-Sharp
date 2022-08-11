using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Kapsülleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.TCKİMLİKNO = "12345678910";
            Console.WriteLine("Tc Kimlik numaranız : " + P1.TCKİMLİKNO);

        }
    }

}