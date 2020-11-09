using System;

namespace CalculateSumByFormula
{
    class Program
    {
        static void Main()
        {
             Console.Write("Please enter n : ");
             int n = Int32.Parse(Console.ReadLine());
             Console.Write("Please enter x: ");
             int x = Int32.Parse(Console.ReadLine());
             double sum = 1;
            int factorial=1;
            int currentX = 1;
             for (int i = 1; i<= n; i++) {
                factorial *= i;
                currentX *= x;
                 sum += factorial/ currentX;
             }
             Console.WriteLine("Result: "+sum);
         }  

    }
}
