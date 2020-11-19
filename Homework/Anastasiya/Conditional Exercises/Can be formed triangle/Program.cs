using System;

namespace Can_be_formed_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first angle of triangle: ");
            int a = int.Parse (Console.ReadLine());

            Console.WriteLine("Enter second angle of triangle: ");
            int b = int.Parse (Console.ReadLine());

            Console.WriteLine("Enter third angle of triangle: ");
            int c = int.Parse (Console.ReadLine());

            if ((a + b + c == 180) && a!=0 && b!=0 && c!=0)
            {
                Console.WriteLine("The triangle is valid");
            }
            else
            {
                Console.WriteLine("The triangle is not valid");
            }
        }
    }
}
