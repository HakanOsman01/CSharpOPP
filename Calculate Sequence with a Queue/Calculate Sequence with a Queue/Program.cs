using System;
using System.Collections.Generic;
using System.Linq;
namespace Calculate_Sequence_with_a_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Queue<int>queue=new Queue<int>();
            int N=int.Parse(Console.ReadLine());
            queue.Enqueue(N);
            List<int>list=new List<int>();
            list.Add(N);
            for (int i = 1; i <= 50; i+=3)
            {
                int firstNum = queue.Peek() + 1;

                queue.Enqueue(queue.Peek() + 1);

                list.Add(firstNum);

                int secondNum = 2 * queue.Peek() + 1;

                list.Add(secondNum);

                queue.Enqueue(2*queue.Peek()+1);

                int thirdNum = queue.Peek() + 2;

                list.Add(thirdNum);

                queue.Enqueue(queue.Peek()+2);

               
              
                queue.Dequeue();
                
               
            }
           
            list.RemoveAt(list.Count-1);
            list.RemoveAt(list.Count - 1);
            //Console.WriteLine(list.Count);
            Console.WriteLine($"{string.Join(" ",list)}");

        }
    }
}