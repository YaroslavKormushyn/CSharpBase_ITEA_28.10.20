 using System;

namespace DigitReversedOrder
{
    class Program
    { /*
        static void Main()
        {
            Console.Write("Enter the digit: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal n))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            Console.WriteLine("Reverse order: "+ ReverseNumber(n));
        }
        static decimal ReverseNumber(decimal n)
        {
            string temp = n.ToString();
            string reverse = "";
            for (int i = temp.Length - 1; i >= 0; i--)
                reverse += temp[i];
            return decimal.Parse(reverse);
        }
    }
}
        */
        public static void ReversedOrder(decimal n)
        {
            decimal reverse = 0;
            do
            {
                n *= 10;
                reverse = reverse * 10 + n % 10;
                n /= 10;
            }
            while (n !=0);
            
                Console.Write("The number in reverse order is : {0} \n", reverse);
            }
           public static void Main()
            {
            
            Console.WriteLine("Please enter the decimal digit: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal n))
                {
                    Console.WriteLine("The wrong input! ");
                    return;
                }
            ReversedOrder(n);
            }
        }
    }
     