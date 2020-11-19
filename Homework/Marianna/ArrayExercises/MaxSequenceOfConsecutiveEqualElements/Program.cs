using System;

namespace MaxSequenceOfConsecutiveEqualElements
{
    class Program
    {
        public static void MaxSequenceOfConsecutiveEqualElements(int count, int currentCount, int element, int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                    element = array[i];
                }
            }
            Console.WriteLine("The maximal sequence of consecutive equal elements: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0}, ", element);
            }
            Console.WriteLine("\nThe number of maximal sequence of consecutive equal elements of the Array: {0} ", count);
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
            int currentCount = 1;
            int count = 1;
            int element = 0;
            MaxSequenceOfConsecutiveEqualElements(count, currentCount, element, array);
        }
    }
}
