using System;

namespace QuadrationEquationToFindRealRoots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input A (not 0): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Input C: ");
            int c = int.Parse(Console.ReadLine());

            int d = (int)(b * b - 4 * a * c);
            if (d < 0)
                Console.WriteLine("\nD={0}\nThere are no real roots.", d);
            else if (d == 0)
            {
                int x1 = (int)(-b / 2 * a);
                Console.WriteLine("\nX={0}", x1);
            }
            else
            {
               int x1 = (int)((-b + Math.Sqrt(d)) / (2 * a));
                int x2 = (int)((-b - Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("\nX1={0}\nX2={1}", x1, x2);
            }
            Console.ReadLine();
        }
    }
}
