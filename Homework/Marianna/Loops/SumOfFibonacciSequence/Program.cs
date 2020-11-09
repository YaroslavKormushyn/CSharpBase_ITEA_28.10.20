using System;

namespace SumOfFibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int current = 0;
            int next = 1;
            Console.Write("Please enter the number of the the Fibonacci sequence: ");
            int N = Int32.Parse(Console.ReadLine());
            int sum = 1;
            int currentSum = 0;
                for (int i = 1; i < N-1; i++)
            {
                 currentSum=current+next;
                current = next;
                next = currentSum;
                sum += currentSum;
              
            }
            Console.Write("Sum is "+sum);
        }
    }
}
