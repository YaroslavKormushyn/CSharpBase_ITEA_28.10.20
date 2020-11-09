using System;

namespace CreateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter N (N<20): ");
            int N = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Result: ");
            for (int i = 1; i <= N; i++)
            {
                for (int j = i; j <= i + N - 1; j++)
                {
                    {

                        Console.Write( j + "  ");

                    }   
                }
                Console.WriteLine();
            }
        }
    }
}