using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Tree<T>
    {
        private T value;
        private Tree<T> parent;
        private List<Tree<T>> children;
        public Tree(T value)
        {
            this.value = value;
            this.children = new List<Tree<T>>();
        }
        public Tree(T value,params Tree<T>[] allchildrens)
            :this(value)
        {
            foreach (var child in allchildrens)
            {
                child.parent = this;
                children.Add(child);
                
            }
        }
        public IEnumerable<T> OrderBfs()
        {
            Queue<Tree<T>>queue=new Queue<Tree<T>>();
            List<T>results=new List<T>();
            queue.Enqueue(this);
            while (queue.Count >0)
            {
                var currentNode=queue.Dequeue();
                results.Add(currentNode.value);
                foreach (var child in currentNode.children)
                {
                    queue.Enqueue(child);
                }

            }
            return results;
        }
        private void OrderDfs(Tree<T> node,List<T>result)
        {
            foreach (var child in node.children)
            {
                OrderDfs(child,result);
            }
            result.Add(node.value);
        }
        public IEnumerable<T> GetByDfs()
        {
            List<T>result=new List<T>();
            this.OrderDfs(this,result);
            return result;

        
        }
        public IEnumerable<T> GetLeafs()
        {
            Queue<Tree<T>> queue = new Queue<Tree<T>>();
            List<T> results = new List<T>();
            queue.Enqueue(this);
            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                if (currentNode.children.Count == 0)
                {
                    results.Add(currentNode.value);
                }
               
                foreach (var child in currentNode.children)
                {
                    queue.Enqueue(child);
                }

            }
            return results;

        }
        
    }
}
