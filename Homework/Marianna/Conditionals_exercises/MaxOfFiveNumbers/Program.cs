using System;

namespace MaxOfThreeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first digit: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second digit: ");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third digit: ");
            int z = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth digit: ");
            int k = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fifth digit: ");
            int l = Int32.Parse(Console.ReadLine());
                if (x > y && x > z && x > k && x > l) Console.WriteLine("The biggest of three integers is " + x);
                    else if (y > x && y > z && y > k && y > l) Console.WriteLine("The biggest of three integers is " + y);
                        else if (z > x && z > y && z> k && z > l) Console.WriteLine("The biggest of three integers is " + z);
                                else if (k > x && k > z && k > y && k > l) Console.WriteLine("The biggest of three integers is " + k);
                                       else if (l > x && l > y && l > k && l > z) Console.WriteLine("The biggest of three integers is " + l);
                                             else Console.WriteLine("Five digits are equal");

            /* int[] array = new int[5];
             Console.WriteLine("Enter the first digit: ");
             array[0] = Int32.Parse(Console.ReadLine());
             Console.WriteLine("Enter the second digit: ");
             array[1] = Int32.Parse(Console.ReadLine());
             Console.WriteLine("Enter the third digit: ");
             array[2] = Int32.Parse(Console.ReadLine());
             Console.WriteLine("Enter the fourth digit: ");
             array[3] = Int32.Parse(Console.ReadLine());
             Console.WriteLine("Enter the fifth digit: ");
             array[4] = Int32.Parse(Console.ReadLine());
                 int max = array[0];
                        for (int i = 0; i < array.Length; i++)
             {
                             if (array[i] > max) max = array[i];
             }
             Console.WriteLine("The greatest of given 5 numbers is  " + max);  */
        }
    }
}