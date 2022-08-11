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

            Personel p1 = new Personel(123321, "ramazannnn", "aydınnn");

            p1.bilgileriGoster();
            p1.ZamYap(1000);

        }
    }


}