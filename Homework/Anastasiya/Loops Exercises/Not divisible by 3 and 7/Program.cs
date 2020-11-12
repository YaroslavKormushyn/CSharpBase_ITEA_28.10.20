using System;

namespace Not_divisible_by_3_and_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                if (i % (3 * 7) != 0) Console.WriteLine(i);
            }
        }
    }
}
