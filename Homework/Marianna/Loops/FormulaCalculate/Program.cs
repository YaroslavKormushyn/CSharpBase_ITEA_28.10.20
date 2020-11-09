using System;

namespace FormulaCalculate
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter N, where 1<K<N : ");
            int N = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter K, where 1<K<N : ");
            int K = Int32.Parse(Console.ReadLine());
            int NsubtractK = N - K;
            for (int i = N-1; i > 0; i--) { N *= i; }
            for (int i = K-1; i > 0; i--) { K *= i; }
            for (int i = NsubtractK-1; i >0; i--) { NsubtractK *= i; }
            int result = (N * K )/ NsubtractK;
            Console.WriteLine("N!*K!/(N-K)!  = " + result);
        }
    }
    }

