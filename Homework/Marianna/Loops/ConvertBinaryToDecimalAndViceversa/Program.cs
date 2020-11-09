using System;
namespace ConvertBinaryToDecimalAndViceversa
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the digit in relevance for input:\n" + " - if you want to convert from decimal to binary enter: 0\n " + "- if you want to convert from decimal to binary enter: 1\n");
            int caseSwitch = Int32.Parse(Console.ReadLine());
            switch (caseSwitch)
            {
                case 0:
                    Console.Write("Enter decimal number: ");

                    int n = Int32.Parse(Console.ReadLine());
                    int remainder;
                    string result = string.Empty;
                    while (n > 0)
                    {
                        remainder = n % 2;
                        n /= 2;
                        result = remainder.ToString() + result;
                    }
                    Console.WriteLine("Binary:  {0}", result);

                    break;
                case 1:
                    Console.Write("Enter binary number: ");
                    double sum = 0;
                    int k = Int32.Parse(Console.ReadLine());// binary number
                    int strn = k.ToString().Length; //how many digits has my number
                    for (int i = 0; i < strn; i++)
                    {
                        int lastDigit = k % 10; // get the last digit
                        sum = sum + lastDigit * (Math.Pow(2, i));
                        k = k / 10; //remove the last digit
                    }
                    Console.WriteLine(sum);
                    break;
                default:
                    Console.WriteLine("The wrong input!");
                    break;
            }
        }
    }
}  

