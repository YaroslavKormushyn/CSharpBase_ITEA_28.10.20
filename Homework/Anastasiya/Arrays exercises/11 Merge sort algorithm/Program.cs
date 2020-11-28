using System;

namespace _11_Merge_sort_algorithm
{
    class Program
    {
        static void Sort(int[] elementsOfArray, int start, int end)
        {
            if (start < end)
            {
                int middle = (start + end) / 2;

                Sort(elementsOfArray, start, middle);
                Sort(elementsOfArray, middle + 1, end); 

                Merge(elementsOfArray, start, middle, end);
            }
        }

        static void Merge(int[] sizeOfArray, int start, int middle, int end)
        {
            int sizeOfPart1 = middle - start + 1; 
            int sizeOfPart2 = end - middle; 

            int[] elementOfPart1 = new int[sizeOfPart1];
            int[] elementOfPart2 = new int[sizeOfPart2];

            int i, k;

            for (i = 0; i < sizeOfPart1; i++)
            {
                elementOfPart1[i] = sizeOfArray[start + i];
            }

            for (k = 0; k < sizeOfPart2; k++)
            {
                elementOfPart2[k] = sizeOfArray[middle + k + 1];
            }

            i = 0;
            k = 0;

            int s = start;
            while (i < sizeOfPart1 && k < sizeOfPart2)
            {
                if (elementOfPart1[i] <= elementOfPart2[k]) // якщо елемент 1 половини менший, він дорівнює початку масиву
                {
                    sizeOfArray[s] = elementOfPart1[i];
                    i++;
                }
                else
                {
                    sizeOfArray[s] = elementOfPart2[k];
                    k++;
                }
                s++;
            }
            while (i < sizeOfPart1) // залишок елементів 1 половини
            {
                sizeOfArray[s] = elementOfPart1[i];
                i++;
                s++;
            }
            while (k < sizeOfPart2)
            {
                sizeOfArray[s] = elementOfPart2[k];
                k++;
                s++;
            }
        }

        static void Main(String[] args)
        {
            Console.Write("Enter size of array: ");
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] elementsOfArray = new int[sizeOfArray];

            for (int i = 0; i < elementsOfArray.Length; i++)
            {
                Console.Write("Enter {0} element of array: ", i);
                elementsOfArray[i] = int.Parse(Console.ReadLine());
            }

            Sort(elementsOfArray, 0, elementsOfArray.Length - 1);

            Console.Write("Sorted array is: ");
            for (int i = 0; i < elementsOfArray.Length; ++i)
            {
                Console.Write(elementsOfArray[i] + " ");
            }
        }
    }
}
