namespace CustomQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
           // Queue<int>normalQue = new Queue<int>();
            
           CustomQueue<int>queue = new CustomQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            int firstElement=queue.Dequeue();
            int secondElement=queue.Dequeue();
            int thirdElement=queue.Dequeue();
            Console.WriteLine($"{firstElement}-{secondElement}-{thirdElement}");
            queue.ForEach(x=>Console.Write($"{x} "));
            
          
        }
    }
}