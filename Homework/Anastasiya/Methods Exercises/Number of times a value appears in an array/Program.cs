using System;

    class Program
    {
        static int Counter(int value, int[] number)
        {
            int counter = 0;

        for (int i = 0; i < number.Length; i++)
        {
            if (value == number[i])
            {
                counter++;
            }
        }
            return counter;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] number = new int[size]; //створення n змінних у залежності від введеного розміру n масиву

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter number {0}: ", i);
                number [i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the value the number of times you are looking for: ");
            int value = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} is repeated {1} number of times", value, Counter(value, number));
        }
    }