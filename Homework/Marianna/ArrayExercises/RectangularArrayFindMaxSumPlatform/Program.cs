using System;

namespace RectangularArrayFindMaxSumPlatform
{
    class Program
    {
        static void PrintArray(int[,] array, int n, int m)
        {
            Console.WriteLine("\nArray: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void MaxSumOfRow(int[,] array, int n, int m)
        {
            int[] rowSum = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    rowSum[i] += array[i, j];
                }
                Console.Write("Sum of elements {0} row stored in the array is : {1}\n\n", i, rowSum[i]);
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += rowSum[i];
            }
            Console.Write("Sum of all elements of the array is : {0}\n\n", sum);
        }
        static void Main()
        {
            Console.Write("Enter the number of rows of the array : ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            Console.Write("Enter the number of columns of the array : ");
            if (!int.TryParse(Console.ReadLine(), out int m))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Enter [{0},{1}] element: ", i, j);
                    if (!int.TryParse(Console.ReadLine(), out array[i, j]))
                    {
                        Console.WriteLine("The wrong input! ");
                        break;
                    }
                }
            }
            PrintArray(array, n, m);
            MaxSumOfRow(array, n, m);
        }
    }
}
