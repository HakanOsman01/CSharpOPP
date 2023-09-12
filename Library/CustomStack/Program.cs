namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();
            stack.Push("Hello");
            stack.Push("World");
            stack.Push("Jorney");
            Console.WriteLine(stack.IsEmpty());
            string[] words = { "1", "2","3"};
            Stack<string>newStack=stack.AddRange(words);
            while (newStack.Count > 0)
            {
                Console.WriteLine(newStack.Pop());
            }
            
        }
    }
}