using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MyDict<T, R>
    {
        T[] items1;
        R[] items2;

        public MyDict()
        {
            items1 = new T[0];
            items2 = new R[0];
        }
        public void Add(T item1, R item2)
        {
            T[] tempItems1 = items1;
            R[] tempItems2 = items2;
            for (int i = 0; i < tempItems1.Length; i++)
            {
                items1[i] = tempItems1[i];
                items2[i] = tempItems2[i];


            }
            items1[items1.Length - 1] = item1;
            items2[items2.Length - 1] = item2;


        }
    }
}
