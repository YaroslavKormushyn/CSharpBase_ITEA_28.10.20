using System;

namespace GivenIntegersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter x: ");
            int x = int.Parse(Console.ReadLine());

            decimal resultX = 1;
            decimal factorial = 1;
            decimal sum = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                resultX *= x;
                sum += (factorial / resultX);
            }
            Console.WriteLine("The result is " + sum);






        }
    }
}
