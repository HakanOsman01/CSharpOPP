using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateStack
{
    public class CustomStack<T> : IAbstarctStack<T>
    {
        private class Node
        {
            public Node Next { get; set; }
            public T Value { get;private set; }
            public Node(T value)
            {
               this.Value = value;  
            }
            public Node(T value, Node next)
                :this(value) 
            {
                this.Next= next;
            }
        }
        private Node top;
        public int Count { get;private set; }

        public IEnumerator<T> GetEnumerator()
        {
            var currentTop= this.top;
            while (currentTop.Next!= null)
            {
                yield return currentTop.Value;
                currentTop= currentTop.Next;
            }
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new ArgumentException("The Stack is empty");
            }
            return this.top.Value;  
        }

        public T Pop()
        {
            if(Count== 0)
            {
                throw new ArgumentException("The Stack is empty");
            }
            var oldTop=this.top;
            this.top = oldTop.Next;
            oldTop.Next = null;
            Count--;
            return oldTop.Value;
        }

        public void Push(T item)
        {
            Node node=new Node(item);
            if (Count == 0)
            {
                this.top = new Node(item);
            }
            var oldTop=this.top;
            node.Next = oldTop;
            this.top=node;
            Count++;
        }

        IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        
    }
}
