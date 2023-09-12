using System.Text;

namespace NICEProfessorGanchev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            string binaryNumber=string.Empty;
            if (n % 2 == 0)
            {
                binaryNumber="0"+GetBinaryRepresentation(n);
            }
            else
            {
                binaryNumber = GetBinaryRepresentation(n);
            }
            Console.WriteLine(binaryNumber);



        }

        static string GetBinaryRepresentation(int n)
        {
             
            if (n == 1)
            {
                return "1";
            }
            
            string digith = string.Empty;
            if (n % 2 == 0)
            {
               digith= "0";
            }
            else
            {
                digith = "1";
            }
            string binaryNumber = GetBinaryRepresentation(n / 2) + digith;
            return binaryNumber;
           
        }
    }
}