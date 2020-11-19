using System;

namespace Biggest_of_three_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("Enter first number: ");
            int a = int.Parse (Console.ReadLine());
            
            Console.WriteLine ("Enter second number: ");
            int b = int.Parse (Console.ReadLine());
            
            Console.WriteLine ("Enter third number: ");
            int c = int.Parse (Console.ReadLine());

            if ((a > b) && (a > c))
            {
                Console.WriteLine("A is the biggest");
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine("B is the biggest");
            }
            else if ((c > a) && (c > b))
            {
                Console.WriteLine("C is the biggest");
            }
            else if (a == b)
            {
                Console.WriteLine("A and B are the biggest");
            }
            else if (b == c)
            {
                Console.WriteLine("B and C are the biggest");
            }
            else if (a == c)
            {
                Console.WriteLine("A and C are the biggest");
            }
            else
            {
                Console.WriteLine("All are equal");
            }
           
        }
    }
}
