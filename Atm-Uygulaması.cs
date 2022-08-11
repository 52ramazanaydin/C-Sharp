using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Kullanıcıya nasıl işlem yapacağını sor
 * 1- Bakiye Görüntüleme
 * 2-Para Çekme
 * 3- Para Yatırma
 * q Çıkış
 */

namespace MİNİATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean i = true;
            while (i)
            {
                int bakiye = 1000;
                Console.WriteLine("Atm'ye Hoşgeldiniz");
                Console.WriteLine("Yapmak İstediğiniz işlemi seçin");
                Console.WriteLine("1- Bakiye Görüntüleme");
                Console.WriteLine("2- Para Çekme");
                Console.WriteLine(" 3- Para Yatırma");
                Console.WriteLine("q Çıkış");


                String secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.WriteLine("Bakiyeniz :" + bakiye);

                }
                else if (secim == "2")
                {
                    Console.WriteLine("Çekeceğiniz Bakiyeyi girin :");
                    int cekilen_tutar = Convert.ToInt32(Console.ReadLine());
                    bakiye -= cekilen_tutar;
                    Console.WriteLine("Yeni Bakiyeniz :" + bakiye);

                }
                else if (secim == "3")
                {
                    Console.WriteLine("Ekleyeceğiniz Bakiyeyi girin :");
                    int eklenen_tutar = Convert.ToInt32(Console.ReadLine());
                    bakiye += eklenen_tutar;
                    Console.WriteLine("Yeni Bakiyeniz :" + bakiye);


                }


                else if (secim == "q")
                {
                    Console.WriteLine("Atm den çıkıs yapılıyor");
                    i = false;
                }
                else
                {
                    Console.WriteLine("Geçerli Bir Değer Girin:,..00");
                }

                


            }
        }
    }
}