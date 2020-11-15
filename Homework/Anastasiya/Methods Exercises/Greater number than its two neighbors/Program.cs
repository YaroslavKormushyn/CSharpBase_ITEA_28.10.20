using System;

namespace The_first_occurrence
{
    class Program
    {
        static void GreaterElement (int[] numb)
        {
            for (int i = 1; i < numb.Length; i++)
                if (numb[i] > numb[i + 1] && numb[i] > numb[i - 1]) // ? як по іншому вивести -1
                {
                    int great = numb[i];
                    Console.WriteLine("{0} is greater than its two neighbors simultaneously", great);
                }
                else
                {
                    Console.WriteLine("-1");
                }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] numb = new int[size];

            for (int i = 0; i < numb.Length; i++)
            {
                Console.Write("Enter number {0}: ", i);
                numb[i] = int.Parse(Console.ReadLine());
            }

            GreaterElement (numb);

        }
    }
}
