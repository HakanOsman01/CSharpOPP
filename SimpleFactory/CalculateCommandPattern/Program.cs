using CalculateCommandPattern.Commands;

namespace CalculateCommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            while (true)
            {
                Thread.Sleep(1000);
                calculator.Execute(new PlusCommand(5));
                Console.WriteLine(calculator);
            }
        }
    }
}