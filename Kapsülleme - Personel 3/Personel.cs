using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    public class Personel
    {
        public int Personelid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public static int maas { get; set; }

        static Personel()
        {
            maas = 2000;

        }
        public Personel(int _Personelid, string _Name, string _Surname)
        {
            Personelid = _Personelid;
            Name = _Name;
            Surname = _Surname;


        }

        public void bilgileriGoster()
        {
            Console.WriteLine("Kullanıcı bilgiler");
            Console.WriteLine("id : " + Personelid);
            Console.WriteLine("name : " + Name);
            Console.WriteLine("Surname : " + Surname);
            Console.WriteLine("Maas : " + maas);

        }
        public void ZamYap(int zamMiktari)
        {
            Console.WriteLine("Yeni maaş" + (maas + zamMiktari));
        }

    }
}
