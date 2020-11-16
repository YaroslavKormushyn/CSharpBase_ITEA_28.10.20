using System;
using System.Runtime.CompilerServices;

namespace HelloPlusName
{
    class Program
    {
        public static void HelloName(string Name)
        {
            Console.WriteLine("Hello, " + Name + "!");
        }
        static void Main()
        {
            Console.WriteLine("Please enter the Name: ");
            string Name = Console.ReadLine();
            HelloName(Name);
        }
    }
}
