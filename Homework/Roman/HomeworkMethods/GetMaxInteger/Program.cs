using System;

namespace GetMaxInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            Console.WriteLine("Please enter the second number: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            Console.WriteLine("Please enter the number: ");
            if (!int.TryParse(Console.ReadLine(), out int c))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            int result = GetMax(GetMax(a, b), c);
            Console.WriteLine("The biggest out of three provided numbers is: " + result);
        }

        public static int GetMax(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}
