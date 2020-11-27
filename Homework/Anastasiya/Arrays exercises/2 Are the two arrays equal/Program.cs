using System;

namespace _2_AreTheTwoArraysEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of first array: ");
            int sizeofarray1 = int.Parse(Console.ReadLine());

            int[] numbersofarray1 = new int[sizeofarray1];

            for (int i=0; i< numbersofarray1.Length; i++)
            {
                Console.Write("Enter {0} number of array: ", i);
                numbersofarray1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter size of second array: ");
            int sizeofarray2 = int.Parse(Console.ReadLine());

            int[] numbersofarray2 = new int[sizeofarray2];

            for (int i = 0; i < numbersofarray2.Length; i++)
            {
                Console.Write("Enter {0} number of array: ", i);
                numbersofarray2[i] = int.Parse(Console.ReadLine());
            }

            if (sizeofarray1!=sizeofarray2)
            {
                Console.WriteLine("Sizes of arrays is not equal!");
            }
            else
            {
                for (int i=1; i<numbersofarray1.Length; i++)
                {
                    if (numbersofarray1[i] != numbersofarray2[i])
                    {
                        Console.Write("Arrays is not equal!");
                    }
                    else
                    {
                        Console.Write("Arrays is equal!");
                    }
                }
            }
        }
    }
}
