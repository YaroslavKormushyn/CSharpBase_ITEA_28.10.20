using System;

namespace LargeNumbersConvertToWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] units = new string[] { "one ", "two ", "three ", "four ", "five ", "six ", "seven ", "eight ", "nine ", "ten ", "eleven ", "twelve ", "thirteen ", "fourteen ", "fifteen ", "sixteen ", "seventeen ", "eighteen ", "nineteen " };
            string[] tens = new string[] { "ten ", "twenty ", "thirty ", "fourty ", "fifty ", "sixty ", "seventy ", "eighty ", "ninety " };
            int i, num;
            string result = "";
            Console.Write("Enter the number in range 1-999 : ");
            num = int.Parse(Console.ReadLine());
            if (num > 99 && num < 1000)
            {
                i = num / 100;
                result = units[i - 1] + "hundreed ";
                num = num % 100;
            }
            if (num > 19 && num < 100)
            {
                i = num / 10;
                result = result + tens[i - 1];
                num = num % 10;
            }
            if (num < 20 && num > 0)
                result += units[num - 1];
            Console.WriteLine("The number is " + result);
            Console.ReadLine();
        }
    }
    }

