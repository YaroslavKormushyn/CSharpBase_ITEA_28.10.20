using System;

namespace _9_AllLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.Write("Enter a word: ");
            char[] word = (Console.ReadLine()).ToCharArray();

            Console.Write("Indices of the letters: ");

            for (int i = 0; i < word.Length; i++)
            {
                for (int k = 0; k < alphabet.Length; k++)
                {
                    if (word[i] == alphabet[k])
                    {
                        Console.Write("{0} ", k);
                    }
                }
            }
        }
    }
}
