using System;

namespace _4_MaximalSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] elementOfArray = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write("Enter {0} value of the array: ", i);
                elementOfArray[i] = int.Parse(Console.ReadLine());
            }

                int pos = 0, bestPos = 0, bestLen = 0;
                int len = 1;
           
            for (int i = 0; i < elementOfArray.Length - 1; i++)
            {
                if (elementOfArray[i] == elementOfArray[i + 1])
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestPos = pos;
                    }

                }
                else
                {
                    pos = i + 1;
                }

            }
            for (int i = bestPos; i < bestLen + bestPos; i++)
            {
                Console.Write("{0} ", elementOfArray[i]);
            }
            Console.ReadLine();
        }
    }
}
