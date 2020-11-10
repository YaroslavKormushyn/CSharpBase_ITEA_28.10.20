using System;

namespace RandomOrderNIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Random rand = new Random();
                int temp, randomNumber;
                Console.Write("Enter number: ");
                int n = Int32.Parse(Console.ReadLine());
                int[] arr = new int[n];

                for (int i = 0; i < n; i++)
                {
                    arr[i] = i+1;
                }

                foreach (int i in arr)
                {
                    randomNumber = rand.Next(0,n);
                    temp = arr[i];
                    arr[i] = arr[randomNumber];
                    arr[randomNumber] = temp;
                }
                Console.WriteLine("Array of random integers");
                foreach (int i in arr) Console.Write(arr[i]+ " ");
            }
        }
    }
}
    

