using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> codeByLetter = new Dictionary<string, char>()
            {
                {".-",'A' },
                {"-...",'B' },
                {"-.-.",'C' },
                {"-..",'D' },
                {".",'E' },
                {"..-.",'F' },
                {"--.",'G' },
                {"....",'H' },
                {"..",'I' },
                {".---",'J' },
                {"-.-",'K' },
                {".-..",'L' },
                {"--",'M' },
                {"-.",'N' },
                {"---",'O' },
                {".--.",'P' },
                {"--.-",'Q' },
                {".-.",'R' },
                {"...",'S' },
                {"-",'T' },
                {"..-",'U' },
                {"...-",'V' },
                {".--",'W' },
                {"-..-",'X' },
                {"-.--",'Y' },
                {"--..",'Z' }

            };
            string[] message = Console.ReadLine()
            .Split("|",StringSplitOptions.RemoveEmptyEntries); 
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string word in message)
            {
                string []wordWithouWhiteSpace = word.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                foreach (string currentLetter in wordWithouWhiteSpace)
                {
                    char letter = codeByLetter[currentLetter];
                    stringBuilder.Append(letter);
                    
                }
                stringBuilder.Append(' ');
            }
            Console.WriteLine(stringBuilder.ToString().TrimEnd());
        }
    }
}