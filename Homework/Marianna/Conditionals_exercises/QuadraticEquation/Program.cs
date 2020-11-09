using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, D;
            Console.WriteLine("Quadratic equation a*x^2 + b*x +c");
            Console.WriteLine("Enter the coefficient a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the coefficient b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the coefficient c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            D = Math.Pow(b,2)-4*a*c;
            x1 = ((-b + Math.Sqrt(D))/(2*a));
            x2 = ((-b - Math.Sqrt(D)) /( 2 * a));
            if (D<0) Console.WriteLine("No roots! ");
                else if (D == 0) Console.WriteLine("Discriminant = " + D +".  Two equal roots: "+"x1 = x2 = "+x1 );
                  else if (D > 0) Console.WriteLine("Discriminant = " + D +".  Two roots: " + "x1 = "+x1+ ", x2 = "+x2 );
        }
    }
}
