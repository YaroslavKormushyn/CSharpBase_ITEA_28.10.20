using System;

namespace IndexesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.Write("Enter the word: ");
            char[] word = (Console.ReadLine()).ToLower().ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (word[i] == letters[j]) Console.Write("{0} ", j);
                }
            }
        }
    }
}
