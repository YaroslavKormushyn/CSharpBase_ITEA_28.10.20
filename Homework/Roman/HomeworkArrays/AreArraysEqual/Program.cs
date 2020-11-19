using System;

namespace AreArraysEqual
{
    class Program
    {
        static void Main(string[] args)
        {

            bool arraysEqual = true;

            Console.WriteLine("Enter lenght of first array: ");
            int length = int.Parse(Console.ReadLine());

            int[] firstArray = new int[length];

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEnter lenght of second array: ");

            if (length != Int32.Parse(Console.ReadLine())) Console.WriteLine("\nArrays have different lengths.");
            else
            {
                int[] secondArray = new int[length];

                for (int i = 0; i < secondArray.Length; i++)
                {
                    Console.Write("Enter element {0}: ", i);
                    secondArray[i] = Int32.Parse(Console.ReadLine());
                }

                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine("\nArrays are different.");
                        arraysEqual = false;
                        break;
                    }
                }

                if (arraysEqual) Console.WriteLine("\nArrays are the same.");
                Console.ReadLine();
            }
        }
    }   }   
