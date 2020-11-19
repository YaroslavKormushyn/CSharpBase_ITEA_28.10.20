using System;

namespace SelectionSort
{
    class Program
    {
        static void PrintArray(int[] array)
        {
            Console.WriteLine("\nSorted array: ");
            int n = array.Length;
            for (int i = 0; i < n; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
        static void SelectionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_i = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[min_i])
                    {
                        min_i = j;
                        int temp = array[min_i];
                        array[min_i] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
        static void Main()
        {
            Console.Write("Enter the length of the array : ");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                if (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("The wrong input! ");
                    break;
                }
            }
            SelectionSort(array);
            PrintArray(array);
        }
    }
}
