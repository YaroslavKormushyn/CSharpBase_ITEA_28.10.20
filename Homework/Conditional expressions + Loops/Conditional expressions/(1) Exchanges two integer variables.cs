using System;
using System.Transactions;

namespace Exchanges_two_integer_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a>b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }

            Console.WriteLine("First number is {0}, Second number is {1}", a, b);
        }

    }
}