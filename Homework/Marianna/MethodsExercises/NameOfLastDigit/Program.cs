using System;

namespace NameOfLastDigit
{
    class Program
    {
        public static void LastDigitName(int N)
        {
            int caseSwitch = N % 10;
            switch (caseSwitch)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("The wrong input!");
                    break;
            }
        }
        static void Main()
        {
            Console.WriteLine("Please enter the number: ");
            if (!int.TryParse(Console.ReadLine(), out int N))
            {
                Console.WriteLine("The wrong input! ");
                return;
            }
            LastDigitName(N);
        }
    }
}
