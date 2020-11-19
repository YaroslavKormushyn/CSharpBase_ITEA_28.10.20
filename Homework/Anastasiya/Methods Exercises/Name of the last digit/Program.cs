using System;

namespace Name_of_the_last_digit
{
    class Program
    {
        static void LastDigit(int n)
        {
            int last= n % 10;
            Console.WriteLine("The last of digit is {0}", last);
        }

        static void Main(string[] args)
        {
            int n = int.Parse (Console.ReadLine());
            LastDigit(n);
        }
    }
}