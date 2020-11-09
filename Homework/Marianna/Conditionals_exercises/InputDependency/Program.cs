using System;

namespace InputDependency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the digit in relevance for input\n" + "- if the type is integer enter: 0\n " + "- if the type is float enter: 1\n" + "- if the type is string enter: 2\n ");
            int caseSwitch = Int32.Parse(Console.ReadLine());
            switch (caseSwitch)
            {
                case 0:
                    Console.WriteLine("Please enter int variable:");
                    int x = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(++x);
                    break;
                case 1:
                    Console.WriteLine("Please enter float variable:");
                    float y = float.Parse(Console.ReadLine());
                    Console.WriteLine(++y);
                    break;
                case 2:
                    Console.WriteLine("Please enter string variable:");
                    string z = Console.ReadLine();
                    Console.WriteLine(z + "*");
                    break;
                default:
                    Console.WriteLine("The wrong input!");
                    break;
            }
        }
    }
}
