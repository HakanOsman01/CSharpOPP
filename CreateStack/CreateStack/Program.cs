namespace CreateStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CustomStack<int>stack=new CustomStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine($"{string.Join(' ',stack)}");
            int number=stack.Peek();
            Console.WriteLine(number);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}