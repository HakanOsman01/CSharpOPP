﻿namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()=>this.Count==0;
        public Stack<string> AddRange(ICollection<string>collection)
        {
            foreach(var item in collection)
            {
                this.Push(item);
            }
            return this;
        }
    }
}
