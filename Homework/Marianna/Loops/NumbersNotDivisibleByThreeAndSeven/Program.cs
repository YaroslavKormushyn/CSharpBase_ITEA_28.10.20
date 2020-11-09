using System;

namespace NumbersNotDivisibleByThreeAndSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter N: " );
            int N = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Numbers that are not divisible by three and seven simultaneously: ");
                for (int i = 1; i <N; i++)
            {
                if (!(i%3==0 && i % 7== 0))
                Console.WriteLine(i+"\n");
                
            }
           
        }
    }
}
