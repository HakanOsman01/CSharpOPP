namespace SoftuinIoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddTransite<Program, Program>();

        }
    }
}