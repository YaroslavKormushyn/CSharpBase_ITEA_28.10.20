using System;

namespace CompareArrayElementWithNeighbours
{
    class Program
    {
        public static void PrintArray(int[] array)
        {
            Console.WriteLine("The given Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public static void CompareNeighboursOfElement(int[] array, int k)
        {
            if (k == 0)
            {
                if (array[0] < array[1]) Console.WriteLine("It's the first element of the Array. The element on the entered position " + array[0] + " is smaller than it's right neighbour.");
                else if (array[0] > array[1]) Console.WriteLine("It's the first element of the Array. The element on the entered position " + array[0] + " is bigger than it's right neighbour.");
                else Console.WriteLine("It's the first element of the Array. The element on the entered position " + array[0] + " is equal to it's right neighbour.");
            }
            else if (k == array.Length - 1)
            {
                if (array[k] < array[^2]) Console.WriteLine("It's the last element of the Array. The element on the entered position " + array[k] + " is smaller than it's left.");
                else if (array[k - 1] > array[^2]) Console.WriteLine("It's the last element of the Array. The element on the entered position " + array[k] + " is bigger than it's left.");
                else Console.WriteLine("It's the last element of the Array. The element on the entered position " + array[k] + " is equal to it's left.");
            }
            else if (k >= array.Length)
            {
                Console.WriteLine("The entered position is out of the range of the given array!!!");
            }
            else if (array[k - 1] > array[k - 2] && array[k - 2] > array[k])
            {
                Console.WriteLine("The element on the entered position " + array[k] + " is greater than two neighbours simultenuosly! ");
            }
            else if (array[k - 1] < array[k - 2] && array[k - 1] < array[k])
            {
                Console.WriteLine("The element on the entered position " + array[k] + " is smaller than its' two neighbours simultenuosly! ");
            }
            else if (array[k - 1] > array[k - 2] && array[k - 1] < array[k])
            {
                Console.WriteLine("The element on the entered position " + array[k] + " is greater than left neighbour but smaller than right!");
            }
            else if (array[k - 1] < array[k - 2] && array[k - 1] > array[k])
            {
                Console.WriteLine("The element on the entered position " + array[k] + " is greater than right neighbour but smaller than left!");
            }
            else if (array[k - 1] == array[k - 2] && array[k - 1] == array[k])
            {
                Console.WriteLine("The element on the entered position is " + array[k] + " Three elements are equal simultenuosly! ");
            }
            else if (array[k - 1] == array[k - 2] && array[k - 1] < array[k])
            {
                Console.WriteLine("The element on the entered position " + array[k] + " is equal to the left neighbour and  smaller than right! ");
            }
            else if (array[k - 1] == array[k - 2] && array[k - 1] > array[k])
            {
                Console.WriteLine("The element on the entered position " + array[k] + " is equal to the left neighbour and  greater than right! ");
            }
            else if (array[k - 1] > array[k - 2] && array[k - 1] == array[k])
            {
                Console.WriteLine("The element on the entered position " + array[k] + " is greater than left neighbour and equal to the right! ");
            }
            else
            {
                Console.WriteLine("The element on the entered position " + array[k] + " is smaller than left neighbour and equal to the right! ");
            }
            }
        static void Main()
        {
            int[] array = { 1, 3, 6, 6, 6, 0, 2, 0, 3, 0, -2, -4, 5, 6, 7, 7, -2 };
            PrintArray(array);
            Console.WriteLine("\nPlease enter the position of the element present in the given Array(position should be less than 17): ");
            if (!int.TryParse(Console.ReadLine(), out int k))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            CompareNeighboursOfElement(array, k);
        }
    }
}

