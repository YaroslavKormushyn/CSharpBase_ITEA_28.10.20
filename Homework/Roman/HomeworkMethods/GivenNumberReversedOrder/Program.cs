using System;

namespace GivenNumberReversedOrder
{
    class Program
    {
        public static int Reverse(int num)
        {
            int rev_num = 0;
            while (num > 0)
            {
                rev_num = rev_num * 10 + num % 10;
                num = num / 10;
            }
            return rev_num;

        }
        static void Main(string[] args)
        {
            int num = 5555;
            Console.WriteLine("Reverse of no. is " + Reverse(num));
        }
    }
}
