using System;

namespace SignOfProductOfThreeNumbers
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
            
            if ((x > 0 && y > 0 && z > 0) || (x <0 && y < 0 && z > 0) || (x < 0 && y > 0 && z < 0) || (x > 0 && y < 0 && z < 0) || (x > 0 && y < 0 && z > 0) ) Console.WriteLine("The sign  of the product of three entered numbers is positive(+)");
            else Console.WriteLine("The sign  of the product of three entered numbers is negative(-)");
        }
    }
}
