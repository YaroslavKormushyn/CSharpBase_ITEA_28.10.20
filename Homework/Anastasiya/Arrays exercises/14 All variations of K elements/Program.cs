using System;

namespace _14_All_variations_of_K_elements
{
    class Program
    {
        static void Combinations(int[] tempArray, int index)
        {
            if (index != tempArray.Length)
                for (int i = 1; i <= n; i++)
                {
                    tempArray[index] = i;
                    Combinations(tempArray, index + 1);
                }
            else
            {
                for (int i = 0; i < tempArray.Length; i++)
                {
                    Console.Write(tempArray[i] + " ");
                }
                Console.WriteLine();
            }
        }

        static int n;

        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            int[] data = new int[k];

            Combinations(data, 0);
        }
    }
}
