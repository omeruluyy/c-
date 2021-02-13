using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> sehirler1 = new Dictionary<string, int>();
            sehirler1.Add("Kayseri", 38);
            MyDict<string, int> sehirler2 = new MyDict<string, int>();
            sehirler2.Add("Kayseri", 38);
        }
    }
}
