using System;

namespace MaxOfThreeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first digit: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second digit: ");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third digit: ");
            int z = Int32.Parse(Console.ReadLine());
            if (x > y && x > z) Console.WriteLine("The biggest of three integers is " + x);
             else if (y > x && y > z) Console.WriteLine("The biggest of three integers is " + y);
            else if ( z> x && z > y) Console.WriteLine("The biggest of three integers is "+z);
            else Console.WriteLine("Three digits are equal");
        }
    }
}
