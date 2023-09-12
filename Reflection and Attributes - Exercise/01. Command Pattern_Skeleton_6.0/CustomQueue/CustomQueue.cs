
namespace CustomQueue
{
    public class CustomQueue<T>
    {
         private   Node<T> Head { get;set; }
         private  Node<T> Tail { get; set; }

        public int Count { get; private set; }
        public T Peek()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException("Emprty Queue");
            }
            T value = Head.Value;
            return value;

        }
        public T Dequeue()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException("Emprty Queue");
            }
            else
            {
                Node<T> head = this.Head;
                T valueHead= head.Value;
                this.Head = head.Next;
                head.Next = null;
                Count--;
                return valueHead;
                
            }
           
        }
        public void Enqueue(T value)
        {
            Node<T> addNode = new Node<T>(value);
            if (Count == 0)
            {
                this.Head =addNode;
                this.Tail= addNode;
            }
            else
            {
                this.Tail.Next=addNode;
                this.Tail = addNode;


            }
            Count++;
        }
        class Node<T>
        {
            public Node(T value)
            {
                this.Value = value;
            }
            public T Value { get; set; }
            public Node<T> Next { get;set; }
        }
       
    }
}
