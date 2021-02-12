using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotIntro
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi :" + musteri.Ad);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi :" + musteri.Ad);


        }
        public void List(Musteri[] musteriList)
        {
            foreach (var item in musteriList)
            {
                Console.WriteLine(item.Ad);
                Console.WriteLine();
                
            }
        }
    }
}
