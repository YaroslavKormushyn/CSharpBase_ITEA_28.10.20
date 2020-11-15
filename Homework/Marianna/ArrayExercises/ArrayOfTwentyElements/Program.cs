using System;

namespace ArrayOfTwentyElements
{
    class Program
    {
        public static void PrintArray(int[] array)
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public static void CreateArray(int[] array)
        {
            for (int i = 0; i < 20; i++)
            {
                array[i] = i * 5;
            }
        }
                static void Main()
        {
            int[] array = new int[20];
            CreateArray( array);
            PrintArray(array);
        }
    }
}
