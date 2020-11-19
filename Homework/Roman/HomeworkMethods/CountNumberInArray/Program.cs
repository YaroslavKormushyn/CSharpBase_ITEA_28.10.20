using System;

namespace CountNumberInArray
{
    class Program
    {
        static int CountNumber(int number, int[] array)
        {
            int counter = 0;

            for (int i = 0; i < array.Length; i++) if (number == array[i]) counter++;

            return counter;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} was found {1} times.", number, CountNumber(number, array));
        }
    }
}
