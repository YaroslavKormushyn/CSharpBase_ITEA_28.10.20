using System;

namespace MaxAndMinOfSeriesOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int max=0;
            int min=0;
            Console.Write("Please enter the number of integers: ");
            int N = Int32.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i <N; i++)
            {
                Console.Write("Please add the integer to the array: ");
                array[i] =  Int32.Parse(Console.ReadLine()) ;

            }
            min = array[0];
            max = array[0];
            for (int i = 1; i < N; i++)
            {
                if (array[i] > max) {max = array[i]; }
                    if (array[i] < min) { min = array[i]; }
            }
            Console.WriteLine("Min element: " + min);
            Console.WriteLine("Max element: " + max);


        }
    }
}
