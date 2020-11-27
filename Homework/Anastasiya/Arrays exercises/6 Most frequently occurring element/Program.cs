using System;

namespace _6_MostFrequentlyOccurringElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] elementOfArray = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write("Enter {0} element of the array: ", i);
                elementOfArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Your array is: ");

            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write(elementOfArray[i] + " ");
            }

            Console.WriteLine();

            int temporaryCounter = 0, counter = 0, minValue = 0;

            Array.Sort(elementOfArray);

            for (int i = 0; i < elementOfArray.Length - 1; i++)
            {
                if (elementOfArray[i] == elementOfArray[i + 1])
                {
                    temporaryCounter++;
                }
                else
                {
                    temporaryCounter = 1;
                }
                if (temporaryCounter > counter)
                {
                    counter = temporaryCounter;
                    minValue = elementOfArray[i];
                }
            }
            Console.Write("Most frequently occurring element in an array is {0} ({1} times)", minValue, counter);
        }
    }
}
