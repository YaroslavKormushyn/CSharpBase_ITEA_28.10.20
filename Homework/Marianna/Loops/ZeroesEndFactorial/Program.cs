using System;

namespace ZeroesEndFactorial
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter N : ");
            decimal N = Int32.Parse(Console.ReadLine());
            for (int i = (int)(N-1); i > 0; i--)
            {
                N *= i;
            }
            
            Console.WriteLine("The value of factorial= "+N);
            int count = 0;
            while (N % 10 == 0)

            {
                N /= 10;
                count++;    
            }
                Console.WriteLine("The number of zeroes= " + count);

            
        }
    }
}