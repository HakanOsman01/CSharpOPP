using System;
namespace GeneratorsForPasswords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a= 'a';
            //int b = 'b';
            // Console.WriteLine(a%96);
            // Console.WriteLine(b%96);
            int n = int.Parse(Console.ReadLine());
            int l=int.Parse(Console.ReadLine());
            for (int firtSymbol = 1; firtSymbol <= n; firtSymbol++)
            {
                for (int secondSymbol = 1; secondSymbol <= n; secondSymbol++)
                {
                    for (int thirdSymbol = 0; thirdSymbol <l; thirdSymbol++)
                    {
                        //int currentLetter = 'a' + thirdSymbol;
                        for(int fourthSymbol = 0; fourthSymbol <l; fourthSymbol++)
                        {
                            for (int fiveSymbol = 1; fiveSymbol <= n; fiveSymbol++)
                            {
                                if(fiveSymbol> firtSymbol && fiveSymbol > secondSymbol)
                                {
                                    int symbolOne = 'a' + thirdSymbol;
                                    int symbolTwo = 'a' + fourthSymbol;
                                    Console.Write($"{firtSymbol}{secondSymbol}" +
                                        $"{(char)symbolOne}{(char)symbolTwo}{fiveSymbol} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}