using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainTree
{
    public class Tree<T>
    {
        private Tree<T> parent;
        private List<Tree<T>> children;
        private T key;
        public Tree(T key)
        {
            this.key = key;
            children=new List<Tree<T>>();
        }
        public Tree(T key,params Tree<T>[]values)
            :this(key)
        {
            foreach(Tree<T> value in values)
            {
                this.children.Add(value);
                value.parent = this;
            }
        }
        public string GetTreeAsSrtring()
        {
            var sb=new StringBuilder();
            this.DfsTravelell(sb, this, 0);
            return sb.ToString().Trim();

        }

        private void DfsTravelell(StringBuilder sb, Tree<T> tree, int index)
        {
            sb.Append(' ', index)
            .AppendLine(tree.key.ToString());
            foreach (var child in tree.children)
            {
                DfsTravelell(sb, child, index + 2);
            }
        }
        public IEnumerable<T> GetLeafs()
        {
            Queue<Tree<T>>queue= new Queue<Tree<T>>(); 
            List<T> list= new List<T>();
            queue.Enqueue(this);
            while(queue.Count > 0)
            {
                Tree<T> node = queue.Dequeue();
                if (node.children.Count == 0)
                {
                    list.Add(node.key);
                }
                foreach (var currentChild in node.children)
                {
                    queue.Enqueue(currentChild);
                }
            }
            return list;
        }
    }

}
