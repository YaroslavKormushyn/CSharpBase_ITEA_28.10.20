using System;

namespace Maximal_of_the_two_numbers
{
    class Program
    {
        static void GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                max = num1;
            }
            else
            {
                max = num2;
            }
        }

        static int max;

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            GetMax(a, b);
            GetMax(max, c);

            Console.WriteLine("{0} is the maximum of the two numbers", max);
        }
    }
}
