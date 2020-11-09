using System;
using System.IO;
namespace MaxOfTwoIntegers
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first digit: ");
            int  x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second digit: "); 
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Result: ");
            if (x > y)  Console.WriteLine(y); 
                       else Console.WriteLine(x);
        }
    }
}
