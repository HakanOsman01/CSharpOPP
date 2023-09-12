using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateStack
{
    public interface IAbstarctStack <T>: IEnumerable<T>
    {
        void Push(T item);
        T Pop();
        public int Count { get; }
        T Peek();
    }
}
