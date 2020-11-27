using System;

namespace _1_ArrayOf20Elements
{
    class Program
    {
        static void Main(string[] args)
        { 
            int []array= new int [21];
           
            for (int i=1; i<array.Length; i++)
            {
                array[i] = i * 5;
                Console.Write (array[i] + " ");
            }
        }
    }
}