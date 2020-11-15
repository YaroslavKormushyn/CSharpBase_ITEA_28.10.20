using System;

namespace ReadConsoleTwoArraysComparison
{
    class Program
    {
        public static void Main()
        {
            bool flag = true;
            Console.Write("Enter the length of the first array : ");
            if (!int.TryParse(Console.ReadLine(), out int length1))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            int[] array1 = new int[length1];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                if (!int.TryParse(Console.ReadLine(), out array1[i]))
                {
                    Console.WriteLine("The wrong input! ");
                    break;
                }
            }
            Console.Write("Enter the length of the second array : ");
            if (!int.TryParse(Console.ReadLine(), out int length2))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            int[] array2 = new int[length2];
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                if (!int.TryParse(Console.ReadLine(), out array2[i]))
                {
                    Console.WriteLine("The wrong input! ");
                    break;
                }
            }
            if (array1.Length != array2.Length)
            {
                Console.WriteLine("The lengths of two entered Arrays are not equal!!!");
            }
            else
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        Console.WriteLine("The elements of two entered Arrays are not equal!");
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("The two entered Arrays are equal!");
                }
            }
        }
    }
}









