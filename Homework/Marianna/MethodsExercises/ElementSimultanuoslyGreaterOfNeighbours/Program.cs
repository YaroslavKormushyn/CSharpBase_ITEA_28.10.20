using System;

namespace ElementSimultanuoslyGreaterOfNeighbours
{
    class Program
    {
        public static void CompareArrayElementWithNeighbours(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    Console.WriteLine("The element " + array[i] + " is greater than two neighbours simultenuosly! ");
                    break;
                }
                else
                {
                    Console.WriteLine("-1");
                }
            }
        }
        static void Main()
        {
            Console.Write("Enter the length of the array : ");
            if (!int.TryParse(Console.ReadLine(), out int length))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                if (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("The wrong input! ");
                    break;
                }
            }
            CompareArrayElementWithNeighbours(array);
        }
    }
}

