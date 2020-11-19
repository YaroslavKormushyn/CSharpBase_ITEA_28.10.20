using System;

namespace MostFrequentlyOccurringElements
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
        public static void MaxSequenceOfConsecutiveEqualElements(int count, int currentCount, int element, int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                    element = array[i];
                }
            }
            Console.WriteLine("The most frequently occurring element: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0}, ", element);
            }
            Console.WriteLine("\nThe number of most frequently occurring element of the Array: {0} ", count);
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
            int currentCount = 1;
            int count = 1;
            int element = 0;
            MaxSequenceOfConsecutiveEqualElements(count, currentCount, element, array);
        }
    }
}