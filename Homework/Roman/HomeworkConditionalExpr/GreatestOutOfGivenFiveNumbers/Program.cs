using System;

namespace GreatestOutOfGivenFiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstValue = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondValue = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int thirdValue = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            int fourthValue = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            int fifthValue = Int32.Parse(Console.ReadLine());

            if (firstValue < secondValue) firstValue = secondValue;
            if (firstValue < thirdValue) firstValue = thirdValue;
            if (firstValue < fourthValue) firstValue = fourthValue;
            if (firstValue < fifthValue) firstValue = fifthValue;

            Console.WriteLine("{0} is the biggest number.", firstValue);
        }
    }
}
