using System;

namespace CalculationOfN_K_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter N: Given that 1<K<N ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter K: Given that 1<K<N ");
            int K = int.Parse(Console.ReadLine());

            int NKdeduction = N - K;
            for (int i = N - 1; i > 0; i--) 
            {
                N *= i;
            }
            for (int i = K - 1; i > 0; i--)
            {
                K *= i;
            }
            for (int i = NKdeduction - 1; i>0; i--)
            {
                NKdeduction *= i;
            }
            int result = (N * K) / (NKdeduction);
            Console.WriteLine("N!*K!/(N-K)! = " + result);
        }
    }
}
