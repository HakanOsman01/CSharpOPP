using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Stack_of_Strings
{
    public class CustomStack : Stack<string>
    {
        public bool IsEmpty() 
        {
            bool isEmpty = Count == 0;
            if(isEmpty)
            {
                return true;
            }
            return false;

        }
        public Stack<string> AddRange(IEnumerable<string>range)
        {
            foreach(var item in range)
            {
                Push(item);
            }
            return this;
        }

    }
}
