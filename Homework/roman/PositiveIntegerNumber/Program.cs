using System;

namespace PositiveIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: (N < 20) ");
            int n = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }
    }
}
