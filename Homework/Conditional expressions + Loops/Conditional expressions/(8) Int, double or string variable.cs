using System;

namespace Int__double_or_string_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter variable type (0- int, 1- double or 2- string): ");
            int intVar = Convert.ToInt32 (Console.ReadLine());

            switch (intVar)
            {
                case 0:
                    {
                        Console.Write ("Enter int variable: ");
                        intVar = Convert.ToInt32(Console.ReadLine());
                        intVar++;
                        Console.WriteLine("Int variable +1 = {0}", intVar);
                        break;
                    }
                case 1:
                    {
                        Console.Write ("Enter double variable: ");
                        double doubleVar = Convert.ToDouble (Console.ReadLine());
                        doubleVar++;
                        Console.WriteLine("Double variable +1 = {0}", doubleVar);
                        break;
                    }
                case 2:
                    {
                        Console.Write ("Enter string variable: ");
                        string stringVar = Console.ReadLine();
                        stringVar = stringVar + '*';
                        Console.WriteLine("String variable +* = {0}", stringVar);
                        break;
                    }
                default: Console.WriteLine("Wrong input"); 
                    break;
            }
        }
    }
}
