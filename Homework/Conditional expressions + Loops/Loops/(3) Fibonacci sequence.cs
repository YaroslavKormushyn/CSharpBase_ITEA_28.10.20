using System;

namespace Fibonacci_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb1 = 0, numb2 = 1;

            Console.Write("Enter n to print the sum of the first n members: ");
            int n = Convert.ToInt32 (Console.ReadLine());

            Console.Write("0,");

            for (int i = 1; i < n; i++)
            {
                int numb3 = numb1 + numb2;
                numb1 = numb2;
                numb2 = numb3;

                Console.Write ("{0},", numb3);
            }
        }
    }
}
