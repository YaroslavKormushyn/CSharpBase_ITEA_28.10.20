using System;

namespace _5_SelectionSortingOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of array: ");
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] elementOfArray = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write("Enter {0} element of array: ", i);
                elementOfArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write ("Your array is:   ");
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write(elementOfArray[i] + " ");
            }
            Console.WriteLine();

            int smallest, temporary;
            for (int i = 0; i < sizeOfArray - 1; i++)
            {
                smallest = i;

                for (int k = i + 1; k < sizeOfArray; k++)
                {
                    if (elementOfArray[k] < elementOfArray[smallest])
                    {
                        smallest = k;
                    }
                }

                temporary = elementOfArray[smallest];
                elementOfArray[smallest] = elementOfArray[i];
                elementOfArray[i] = temporary;
            }

            Console.Write ("Sorted array is: ");
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write(elementOfArray[i] + " ");
            }
        }
    }
}
