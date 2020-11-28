using System;

namespace _10_Binary_search
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

            Console.Write("Enter the number you are looking for: ");
            int number = int.Parse(Console.ReadLine());

            int index = Array.BinarySearch(elementOfArray, number);

            if (index >= 0)
            {
                Console.Write("Number found at {0} index!", index);
            }
            else
            {
                Console.WriteLine("Number not present!");
            }
        }
    }
}
