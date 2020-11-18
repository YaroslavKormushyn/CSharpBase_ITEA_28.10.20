using System;

namespace ArrayLexicographic
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = { 'a', 'b', 'c', 'z' };
            int firstArrayLength = firstArray.Length;
            char[] secondArray = { 'a', 'b', 'c', 'd' };
            int secondArrayLength = secondArray.Length;
            int length = Math.Min(firstArray.Length, secondArray.Length);

            if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine("Second array is earlier.");
            }

            else if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < length; i++)
                {
                    if (firstArray[i] > secondArray[i])
                    {
                        Console.WriteLine("2 array is earlier.");
                        break;
                    }
                    else if (secondArray[i] > firstArray[i])
                    {
                        Console.WriteLine("1 array is earlier.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Two arrays are equal.");
                    }
                }
            }
            else
            {
                Console.WriteLine("First array is earlier.");
            }
        }
    }
}
