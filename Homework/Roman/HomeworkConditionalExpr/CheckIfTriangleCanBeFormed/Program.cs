using System;

namespace CheckIfTriangleCanBeFormed
{
    public class SumOfTriangles
    {
        static void Main(string[] args)
        {

            int firstAngle, secondAngle, thirdAngle, sum;

            Console.WriteLine("Input three angles of triangle : ");
            firstAngle = Convert.ToInt32(Console.ReadLine());
            secondAngle = Convert.ToInt32(Console.ReadLine());
            thirdAngle = Convert.ToInt32(Console.ReadLine());          
            sum = firstAngle + secondAngle  + thirdAngle;
         
            if (sum == 180)
            {
                Console.WriteLine("It is a valid triangle.\n");
            }
            else
            {
                Console.WriteLine("It is an invalid triangle.\n");
            }
            Console.ReadLine();
        }
    }
}
