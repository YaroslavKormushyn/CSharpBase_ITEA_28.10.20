using System;

namespace Smallest_and_largest_of_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowest = 0, highest = 0, input;

            Console.Write("Enter the number of numbers: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                input = Convert.ToInt32(Console.ReadLine());
                {
                    if (lowest > input)
                    {
                        lowest = input;
                    }
                    if (highest < input)
                    {
                        highest = input;
                    }
                }
            }
            Console.WriteLine("Lowest is {0}, Highest is {1}", lowest, highest);
        }
    }
}
