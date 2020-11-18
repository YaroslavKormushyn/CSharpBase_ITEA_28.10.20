using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0, secondNumber = 1, thirdNumber = 0;

            Console.Write("Enter a Number: ");
            int length = Int32.Parse(Console.ReadLine());

            Console.Write("0, 1,");

            for (int i = 2; i < length; i++)
            {
                thirdNumber = firstNumber + secondNumber;
                Console.Write(" {0},", thirdNumber);
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            }
        }
    }
}
