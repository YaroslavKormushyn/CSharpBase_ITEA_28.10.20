using System;

namespace SumEqualCertainSequenceOfElements
{
    class Program
    {
        static int SubArraySum(int[] arr, int n, int sum)
        {
            int curr_sum = arr[0];
            int start = 0;
            for (int i = 1; i <= n; i++)
            {
                while (curr_sum > sum && start < i - 1)
                {
                    curr_sum -= arr[start];
                    start++;
                }
                if (curr_sum == sum)
                {
                    int p = i - 1;
                    Console.WriteLine("Sum found between " + "indexes " + start + " and " + p);
                    return 1;
                }
                if (i < n)
                {
                    curr_sum += arr[i];
                }
            }
            Console.WriteLine("No subarray found");
            return 0;
        }
        public static void Main()
        {
            int[] arr = { 15, 2, 4, 8, 9, 5, 10, 23 };
            int n = arr.Length;
            int sum = 21;
            SubArraySum(arr, n, sum);
        }
    }
}

