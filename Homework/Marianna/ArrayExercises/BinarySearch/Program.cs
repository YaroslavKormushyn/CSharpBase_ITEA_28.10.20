using System;

namespace BinarySearch
{
    class Program
    {
        static void PrintArray(int[] array)
        {
            Console.WriteLine("\nSorted array: ");
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
                Console.WriteLine();
            }
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
        static int BinarySearch(int[] array, int x)
        {
            int leftpoint = 0;
            int rightpoint = array.Length - 1;
            while (leftpoint <= rightpoint)
            {
                int midpoint = leftpoint + (rightpoint - leftpoint) / 2;
                if (array[midpoint] == x)
                {
                    return midpoint;
                }
                else if (array[midpoint] < x)
                {
                    leftpoint = midpoint + 1;
                }
                else
                {
                    rightpoint = midpoint - 1;
                }
            }
            return -1;
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
            Console.Write("Enter the element to find in the array: ");
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            SelectionSort(array);
            PrintArray(array);
            int result = (BinarySearch(array, x));
            if (result == -1)
            {
                Console.WriteLine("Element not present");
            }
            else
            {
                Console.WriteLine("Element found at " + "index " + result);
            }
        }
    }
}
