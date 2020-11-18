using System;

namespace HomeworkMethods
{
    class Program
    {
         static void ReturnUserName(string username)
        {
            Console.WriteLine("Hello " + username);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            ReturnUserName(Console.ReadLine());
        }
    }
}
