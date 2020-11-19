using System;

namespace GivenIntegersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1, temp = 1;
            Console.Write("Enter n: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter x: ");
            int x = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                temp *= i / x;
                sum += temp;
            }

            Console.WriteLine("Result is {0}", sum);
        }
    }
}
