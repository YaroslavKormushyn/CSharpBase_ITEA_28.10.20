using System;

namespace _12_Quick_sort_algorithm
{
    class Program
    {
        static void Sort(int[] elementOfArray, int start, int end)
        {
            if (start < end)
            {
                int index = Split(elementOfArray, start, end);
                Sort(elementOfArray, start, index - 1);
                Sort(elementOfArray, index + 1, end);
            }
        }

        static int Split(int[] elementOfArray, int start, int end)
        {
            int pivot = elementOfArray[end];

            int i = (start - 1);
            for (int j = start; j < end; j++) // j-start, i- end
            {
                if (elementOfArray[j] < pivot)
                {
                    i++;

                    int temp = elementOfArray[i];
                    elementOfArray[i] = elementOfArray[j];
                    elementOfArray[j] = temp;
                }
            }

            int temp1 = elementOfArray[i + 1]; //переміщення опорного числа до відсортованих елементів
            elementOfArray[i + 1] = elementOfArray[end];
            elementOfArray[end] = temp1;

            return i + 1;
        }

        static void Main(String[] args)
        {
            Console.Write("Enter size of array: ");
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] elementOfArray = new int[sizeOfArray];

            for (int i = 0; i < elementOfArray.Length; i++)
            {
                Console.Write("Enter {0} element of array: ", i);
                elementOfArray[i] = int.Parse(Console.ReadLine());
            }

            Sort(elementOfArray, 0, elementOfArray.Length - 1);

            Console.Write("Sorted array is: ");
            for (int i = 0; i < elementOfArray.Length; ++i)
            {
                Console.Write(elementOfArray[i] + " ");
            }
        }
    }
}
