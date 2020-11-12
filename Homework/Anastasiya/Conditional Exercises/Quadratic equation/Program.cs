using System;

namespace Quadratic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse (Console.ReadLine());
            
            Console.Write("Enter b: ");
            int b = int.Parse (Console.ReadLine());
            
            Console.Write("Enter c: ");
            int c = int.Parse (Console.ReadLine());

            int d = (b * b - 4 * a * c);
            
            if (d < 0)
            {
                Console.WriteLine("D= {0} There are no roots.", d);
            }
                
            else if (d == 0)
            {
                int x1 = (-b / 2 * a);
                Console.WriteLine("x= {0}", x1);
            }
            else
            {
                int x1 = (sbyte)(-b + Math.Sqrt(d)) / (2 * a);
                int x2 = (sbyte)(-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1= {0} x2= {1}", x1, x2);
            }
        }
    }
}
