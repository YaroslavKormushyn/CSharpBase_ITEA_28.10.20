using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number n (n>k): ");
            int n = Convert.ToInt32 (Console.ReadLine());
            
            Console.Write("Enter second number k (n>k): ");
            int k = Convert.ToInt32 (Console.ReadLine());
            
            int nminusk = n - k;

            for (int i = n - 1; i > 0; i--) n = n*i;
            for (int i = k - 1; i > 0; i--) k = k*i;

            Console.WriteLine("Result is {0}", n * k / nminusk);
        }
    }
}
