using System;

internal class CompareTwoCharArraysLexicographically
{
    private static void Main()
    {
        Console.Write("Enter the size of the first array: ");
        int sizeOfArray1 = int.Parse(Console.ReadLine());

        char[] firstArray = new char[sizeOfArray1];

        for (int i = 0; i < sizeOfArray1; i++)
        {
            Console.Write("Enter {0} value of the first array: ", i);
            firstArray[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine();


        Console.Write("Enter the size of the second array: ");
        int sizeOfArray2 = int.Parse(Console.ReadLine());

        char[] secondArray = new char[sizeOfArray2];

        for (int i = 0; i < sizeOfArray2; i++)
        {
            Console.Write("Enter {0} value of the second array: ", i);
            secondArray[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine();


        // виведення масивів на консолі

        for (int i = 0; i < sizeOfArray1; i++)
        {
            Console.Write(firstArray[i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < sizeOfArray2; i++)
        {
            Console.Write(secondArray[i] + " ");
        }
        Console.WriteLine();


        // порівняння масивів

        if (sizeOfArray1 < sizeOfArray2)
        {
            Console.WriteLine("The first array is earlier");
        }

        else if (sizeOfArray1 == sizeOfArray2)
        {
            int minLength = Math.Min(firstArray.Length, secondArray.Length);
            bool result = true;

            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("The first array is earlier");
                    break;
                }

                else if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("The second array is earlier");
                    break;
                }

                else
                {
                    Console.WriteLine("Two arrays are equal"); 
                }
            }
        }

        else
        {
            Console.WriteLine("The second array is earlier");
        }

    }

}