using System;

namespace PositiveIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N: (N < 20) ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j <= i + number - 1; j++)
                {
                    Console.Write(j + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
