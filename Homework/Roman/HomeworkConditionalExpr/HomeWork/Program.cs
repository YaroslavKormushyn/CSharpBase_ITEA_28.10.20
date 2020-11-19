using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());

            if (a > b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }

            Console.WriteLine("First number is {0}, Second number is {1}.", a, b);
        }
    }
}
