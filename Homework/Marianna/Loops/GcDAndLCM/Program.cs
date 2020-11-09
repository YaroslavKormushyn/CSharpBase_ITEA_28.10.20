using System;

namespace GcDAndLCM
{
    class Program
    {
        static int GreatestCommonDivisor(int a, int b)
        {
            if (a == 0)
                return b;
            return GreatestCommonDivisor(b % a, a);
        }

        static int LeastCommonMultiple(int a, int b)
        {
            return (a*b / GreatestCommonDivisor(a, b));
        }


        static void Main(string[] args)
        {


            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Greatest Common Divisor of " + a +
         " and " + b + " is " + GreatestCommonDivisor(a, b));
            Console.WriteLine("Least Common Multiple of " + a +
         " and " + b + " is " + LeastCommonMultiple(a, b));
                }
             }
        }
    
 
