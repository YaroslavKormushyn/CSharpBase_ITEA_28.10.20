using System;

namespace DecimalBinaryExchanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal number ");
            int decimalNumber = int.Parse(Console.ReadLine());
            int remainder;
            string result = String.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary number is " + result);

            Console.WriteLine("Enter a binary number");
            double sum = 0;
            int bnrNumber = int.Parse(Console.ReadLine());
            int length = bnrNumber.ToString().Length;
            for (int i = 0; i < length; i++)
            {
                int lastDigit = bnrNumber % 10;
                sum = sum + lastDigit * (Math.Pow(2, i));
                bnrNumber = bnrNumber / 10;

            }
            Console.WriteLine("Decimal number is " + sum);






        }
    }
}
