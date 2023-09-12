namespace _5._Stack_of_Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
           CustomStack stack= new CustomStack();
            stack.AddRange(new List<string> { "1", "2", "3", "4", "5" });
            while(!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}