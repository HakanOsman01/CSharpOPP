namespace InheritanceStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            Console.WriteLine(stack.IsEmpty());
            List<string>collection=new List<string> { "1","2","3"};
            Stack<string>newStack=stack.AddRange(collection);
            while(newStack.Count > 0)
            {
                Console.WriteLine(newStack.Pop());
            }
        }
    }
}