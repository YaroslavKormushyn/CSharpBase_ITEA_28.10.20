using System;

namespace Reversed_order
{
    class Program
    {
        static void ReverseNumber(int number) //while num ≠ 0 we print its last digit (num % 10) and then divide num by 10
        {
            int reverse = 0;
            while (number != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + (number % 10);
                number = number / 10;
            }
            Console.Write(reverse);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            ReverseNumber(number);
        }
    }
}
