using System;
using System.IO;
namespace MaxOfTwoIntegers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first digit: ");
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            Console.WriteLine("Enter the second digit: ");
            if (!int.TryParse(Console.ReadLine(), out int y))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            Console.WriteLine("Result: ");
            if (x > y)
            {
                x += y;
                y = x - y;
                x -= y;
            }

            Console.WriteLine("First number - "+ x+ "; Second number - "+ y);
        }
    }
}
