using System;

namespace DecimalBinaryExchanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Int32.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2);
            Console.WriteLine("Result is {0}", binary);
        }
    }
}
