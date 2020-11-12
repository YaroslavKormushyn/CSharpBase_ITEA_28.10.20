using System;

namespace Bonus_points
{
    class Program
    {
        static void Main(string[] args)
        {
            int points;
            Console.Write("Enter points in range [1...9]: ");
            points = int.Parse (Console.ReadLine());

            if (points >= 1 && points <= 3)
                Console.WriteLine ("Your points multiplied by 10: {0}", points * 10);
            
            else if (points >= 4 && points <= 6)
                Console.WriteLine ("Your points multiplied by 100: {0}", points * 100);
            
            else if (points >= 7 && points <= 9)
                Console.WriteLine ("Your points multiplied by 1000: {0}", points * 1000);
            
            else
                Console.WriteLine("Wrong input");
        }
    }
}
