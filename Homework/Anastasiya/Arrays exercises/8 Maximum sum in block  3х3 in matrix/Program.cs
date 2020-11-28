using System;

namespace _8_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of lines (vertical): ");
            int line = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns (horisontal): ");
            int column = int.Parse(Console.ReadLine());


            int[,] matrix = new int[line, column];

            for (int l = 0; l < line; l++)
            {
                for (int c = 0; c < column; c++)
                {
                    Console.Write("Enter number in line {0} column {1} : ", l, c);
                    matrix[l, c] = int.Parse(Console.ReadLine());
                }
            }

            long bestSum = long.MinValue;
            int bestColumn = 0,
                bestLine = 0;

            for (int l = 0; l < matrix.GetLength(0) - 2; l++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 2; c++)
                {
                    int sum = matrix[l, c] + matrix[l, c + 1] + matrix[l, c + 2] +
                        matrix[l + 1, c] + matrix[l + 1, c + 1] + matrix[l + 1, c + 2] +
                        matrix[l + 2, c] + matrix[l + 2, c + 1] + matrix[l + 2, c + 2];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestLine = l;
                        bestColumn = c;
                    }
                }
            }

            Console.WriteLine("The best platform is: ");
            Console.WriteLine("{0} {1} {2}", matrix[bestLine, bestColumn], matrix[bestLine, bestColumn + 1], matrix[bestLine, bestColumn + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[bestLine + 1, bestColumn], matrix[bestLine + 1, bestColumn + 1], matrix[bestLine + 1, bestColumn + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[bestLine + 2, bestColumn], matrix[bestLine + 2, bestColumn + 1], matrix[bestLine + 2, bestColumn + 2]);

            Console.WriteLine("The maximal sum is {0}.", bestSum);
        }
    }
}
