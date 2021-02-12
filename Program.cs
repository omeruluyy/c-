using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Musteri musteri1 = new Musteri()
            {
                Ad="Mustafa",
                SoyAd="Şengül",
                Id=123
            };
            Musteri musteri2 = new Musteri()
            {
                Ad = "MMC",
                SoyAd = "Bayrish",
                Id = 123
            };
            Musteri[] musteriList = new Musteri[] { musteri1 ,musteri2};


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.List(musteriList);

            Console.ReadLine();

        }
    }
}
