using System;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the score: ");
            int x = Int32.Parse(Console.ReadLine());
            if (1<=x && x<=3 ) Console.WriteLine("Result is: " + (x*10));
            else if (4 <= x && x <= 6) Console.WriteLine("Result is: " + (x * 100));
            else if (7 <= x && x <= 9) Console.WriteLine("Result is: " + (x * 1000));
            else Console.WriteLine("Error!!!");
        }
    }
}
