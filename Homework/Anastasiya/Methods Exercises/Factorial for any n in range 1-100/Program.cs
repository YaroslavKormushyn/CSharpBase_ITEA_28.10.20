using System;

namespace Factorial_for_any_n_in_range_1_100
{
    class Program
    {
        static double Factorial(double number)
        {
            if (number >= 1)
            {
                return number * Factorial(number - 1);
            }
            else
            {
                return 1;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            double num = double.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
                if (num <= 100)
                {
                    Console.WriteLine("{0}! = {1}", i, Factorial(i));
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }
        }
    }
}