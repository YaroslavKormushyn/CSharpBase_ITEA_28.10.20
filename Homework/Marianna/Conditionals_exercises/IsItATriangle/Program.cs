using System;

namespace IsItATriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first angle value: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second angle value: ");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third angle value: ");
            int z = Int32.Parse(Console.ReadLine());
            if ((x+y+z)==180) Console.WriteLine("The sum of angles is 180. A triangle can be formed by the given value for the entered angles' values.");
            else Console.WriteLine("A triangle can not be formed by the given value for the entered angles' values. ");
        }
    }
}
