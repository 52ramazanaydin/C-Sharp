using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Kapsülleme
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Kapsulleme get ve set metotları ile yapılır ya da property ile yapılır .

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.setIsim("Ramazan");
            Console.WriteLine(ogrenci1.getIsim());
        }
    }
}