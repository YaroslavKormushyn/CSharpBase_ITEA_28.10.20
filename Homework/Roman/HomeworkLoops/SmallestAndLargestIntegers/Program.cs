using System;

namespace SmallestAndLargestIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowest = 0, highest = 0, input;

            Console.Write("Enter numbers length: ");
            int lenght = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Enter a number: ");
                input = Int32.Parse(Console.ReadLine());
                if (i == 0) lowest = highest = input;
                else
                {
                    if (lowest > input) lowest = input;
                    if (highest < input) highest = input;
                }
            }
            Console.WriteLine("Lowest is {0}, Highest is {1}", lowest, highest);
        }
    }
}
