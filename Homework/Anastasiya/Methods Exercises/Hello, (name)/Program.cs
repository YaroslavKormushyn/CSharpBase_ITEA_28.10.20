using System;

namespace Hello_name
{
    class Program
    {
        static void Name (string name)
        {
            Console.Write("Hello, {0}!", name); 
        }

        static void Main(string[] args)
        {
            Console.Write ("Enter your name: ");
            Name (Console.ReadLine());
        }
    }
}
