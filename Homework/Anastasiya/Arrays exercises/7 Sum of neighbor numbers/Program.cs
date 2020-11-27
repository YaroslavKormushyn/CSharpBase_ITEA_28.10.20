using System;

namespace _7_SumOfNeighborNumbers
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

            Console.Write("Enter S: ");
            int s = int.Parse(Console.ReadLine());

            int sum, firstValue = 0, endValue = 0;
            bool finalSum = false;

            for (int i = 0; i < elementOfArray.Length - 1; i++)
            {
                sum = elementOfArray[i];

                for (int k = i + 1; k < sizeOfArray; k++)
                {
                    sum += elementOfArray[k];

                    if (sum == s)
                    {
                        firstValue = i;
                        endValue = k;
                        finalSum = true;
                        break;
                    }
                }

                if (finalSum)
                {
                    break;
                }
            }

            if (finalSum)
            {
                for (int i=firstValue; i<=endValue; i++)
                {
                    Console.Write("{0} ", elementOfArray[i]);
                }
            }

            else
            {
                Console.Write("The elements of the array do not form the specified sum");
            }
        }
    }
}
