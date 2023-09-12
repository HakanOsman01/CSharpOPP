namespace RecursiveGetSumEvenDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());




            int sum = GetMultyplayEvenDigiths(number);
            if (sum == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(sum);
            }
    
           
        }

        static int GetMultyplayEvenDigiths(int number)
        {

            int currentNumber = number;
            if (number == 0)
            {
                return 1;
            }
            int currentDigith = currentNumber % 10;
            if(currentDigith %2 ==0)
            {
                int sum = currentDigith * GetMultyplayEvenDigiths(number / 10);
               
                return sum;

            }
            return GetMultyplayEvenDigiths(number / 10);






        }
    }
}