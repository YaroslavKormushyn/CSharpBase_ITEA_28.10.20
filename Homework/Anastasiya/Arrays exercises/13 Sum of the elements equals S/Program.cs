using System;

namespace _13_Sum_of_the_elements_equals_S
{
    class Program
    {
        static int[] findSum (int[] sizeOfArray, bool[] possible, int index, int s, int elementsEqualSum)
        {
            if (index < sizeOfArray.Length)
            {
                possible[index] = true;
                int[] x = findSum(sizeOfArray, possible, index + 1, s, elementsEqualSum);

                if (x.Length > 0)
                {
                    return x;
                }
                else
                {
                    possible[index] = false;
                    return findSum(sizeOfArray, possible, index + 1, s, elementsEqualSum);
                }
            }
            else
            {
                int sum = 0, count = 0;

                for (int i = 0; i < sizeOfArray.Length; i++)
                {
                    if (possible[i])
                    {
                        sum += sizeOfArray[i];
                        count++;
                    }
                }

                int[] finalSum = new int[0];

                if (sum == s && count == elementsEqualSum)
                {
                    finalSum = new int[count];
                    count = 0;

                    for (int i = 0; i < sizeOfArray.Length; i++)
                    {
                        if (possible[i])
                        {
                            finalSum[count++] = sizeOfArray[i];
                        }
                    }
                }
                return finalSum;
            }
        }

        static void Main()
        {
            Console.Write("Enter size of array: ");
            int sizeOfArray = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of elements that equals the sum: ");
            int elementsEqualSum = int.Parse(Console.ReadLine());

            int[] elementOfArray = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write("Enter {0} element: ", i);
                elementOfArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter sum: ");
            int s = int.Parse(Console.ReadLine());

            int[] finalSum = findSum(elementOfArray, new bool[elementOfArray.Length], 0, s, elementsEqualSum);

            Console.Write("Elements that equals the sum: ");
            for (int i = 0; i < finalSum.Length; i++)
            {
                Console.Write(finalSum[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
