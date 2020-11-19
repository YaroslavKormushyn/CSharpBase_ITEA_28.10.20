using System;

namespace LatinLetterIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] characters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("Enter a word please: ");
            char[] word = (Console.ReadLine()).ToLower().ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < characters.Length; j++)
                {
                    if (word[i] == characters[j]) Console.Write("{0} ", j);
                }
            }
        }
    }
}