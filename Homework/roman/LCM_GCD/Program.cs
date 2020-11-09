using System;

namespace LCM_GCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstValue = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondValue = Int32.Parse(Console.ReadLine());

            while (firstValue != 0 && secondValue != 0)
            {
                if (firstValue > secondValue) firstValue %= secondValue;
                else secondValue %= firstValue;
            }

            if (firstValue == 0) Console.WriteLine("Greatest Common Divisor is " + secondValue);
            else Console.WriteLine("Greatest Commmon Divisor is " + firstValue);

            int x, y, lcm = 0;
            Console.Write("Enter First Number : ");
            firstValue = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            secondValue = int.Parse(Console.ReadLine());
            x = firstValue;
            y = secondValue;
            while (firstValue != secondValue)
            {
                if (firstValue > secondValue)
                {
                    firstValue = firstValue - secondValue;
                }
                else
                {
                    secondValue = secondValue - firstValue;
                }
            }
            lcm = (x * y) / firstValue;
            Console.Write("Least Common Multiple is : " + lcm);
            Console.Read();



        }
    }
}
