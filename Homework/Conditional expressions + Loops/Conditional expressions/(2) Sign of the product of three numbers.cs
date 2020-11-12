using System;
namespace Sign_of_the_product_of_three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = Convert.ToInt32 (Console.ReadLine());
            
            Console.WriteLine ("Enter second number: ");
            int b = Convert.ToInt32 (Console.ReadLine());
            
            Console.WriteLine ("Enter third number: ");
            int c = Convert.ToInt32 (Console.ReadLine());

            if (a >= 0 && b >= 0 && c >= 0)
            {
                Console.WriteLine("+");
            }
            else if (a >= 0 && b < 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b >= 0 && c < 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b < 0 && c >= 0)
            {
                Console.WriteLine("+");
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b >= 0 && c >= 0)
            {
                Console.WriteLine("-");
            }
            else if (a >= 0 && b < 0 && c >= 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("-");
            }
            
        }
    }
}