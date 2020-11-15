using System;

namespace GetMax
{
    class Program
    {
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
        static void Main()
        {
            Console.WriteLine("Please enter the first digit: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            Console.WriteLine("Please enter the second digit: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            Console.WriteLine("Please enter the first digit: ");
            if (!int.TryParse(Console.ReadLine(), out int c))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            int result = GetMax(GetMax(a, b), c);
            Console.WriteLine("The biggest of three entered numbers is: " + result);
        }
    }
}
