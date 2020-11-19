using System;

namespace CountCertainNumberArray
{
    class Program
    {
        public static void PrintArray(int[] array)
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    public static void CountCertainNumber(int[] array, int N)
        {
            
            int count = 0;
                Console.WriteLine("How many times certain number can be found in a given array: ");
            for (int i=0; i<array.Length;i++ )
            {
                if (array[i] == N)
                {
                    count++;
                }  
            }
            Console.WriteLine(count);
        }
        static void Main()
        {
            int[] array = { 1, 3, 5, 6, 7, 0, 2, 0, 3, 0, -2, -4, 5, 6, 7, 7, -2 };
            PrintArray(array);
            Console.WriteLine("\nPlease enter the number: ");
            if (!int.TryParse(Console.ReadLine(), out int N))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            CountCertainNumber(array,N);
        }
    }
}
