using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenarteArrayGenarator
{
    public class ArrayCreator
    {
       public static T[]Create<T>(int lenght,T item)
       {
            T[] arr = new T[lenght];
            for (int i = 0; i < lenght; i++)
            {
                arr[i] = item;
            }
            return arr;
       }

    }
}
