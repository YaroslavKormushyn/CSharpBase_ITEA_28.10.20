using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int line, col;

            Console.WriteLine("Enter n < 20: ");
            int n = Convert.ToInt32 (Console.ReadLine());
            
            for (line = 1; line <= n; line++)
            {
                for (col = line; col <= line + n;)
                {
                    Console.Write(col + " ");
                    col++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
