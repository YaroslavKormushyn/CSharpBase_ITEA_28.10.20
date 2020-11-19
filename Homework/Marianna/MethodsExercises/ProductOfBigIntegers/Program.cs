using System;
using System.Numerics;
namespace ProductOfBigIntegers
{
    class Program
    {
        public static void ProductBigIntegers(BigInteger N)
        {
            for (BigInteger i = (N - 1); i > 0; i--)
            {
                N *= i;
            }
            Console.WriteLine("The value of the factorial= " + N);
        }
static void Main()
        {
            Console.Write("Please enter N: ");
          BigInteger N = BigInteger.Parse(Console.ReadLine());
            ProductBigIntegers(N);
        }
    }
}
