namespace _9._Index_of_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] letters = new char[26];
            char a ='a';
            int index = (int)a;
            for (int i = 0; i < letters.Length; i++)
            {
                int currentLetter = 97 + i; ;
                letters[i] =(char)currentLetter;
            }
            string word = Console.ReadLine();
            //Console.WriteLine(index);
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (word[i] == letters[j])
                    {
                        Console.WriteLine($"{word[i]} -> {j}");
                    }
                }
            }
        }
    }
}