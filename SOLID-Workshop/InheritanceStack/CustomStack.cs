using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceStack
{
    public class CustomStack : Stack<string>
    {
        public bool IsEmpty() => this.Count == 0;
        public Stack<string> AddRange(ICollection<string>collecton)
        {
            foreach (var item in collecton)
            {
                this.Push(item);
            }
            return this;
        }


    }
}
