using System;

namespace Greatest_of_5_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = int.Parse (Console.ReadLine());
            
            Console.WriteLine ("Enter second number: ");
            int b = int.Parse (Console.ReadLine());
            
            Console.WriteLine ("Enter third number: ");
            int c = int.Parse (Console.ReadLine());
           
            Console.WriteLine ("Enter fourth number: ");
            int d = int.Parse (Console.ReadLine());
            
            Console.WriteLine ("Enter fifth number: ");
            int e = int.Parse (Console.ReadLine());

            if (a < b) a = b;
            if (a < c) a = c;
            if (a < d) a = d;
            if (a < e) a = e;

            Console.WriteLine("{0} is the biggest number ", a);
        }
    }
}
