using System;

namespace Is_position_greater_than_its_two_neighbours
{
    class Program
    {
        static void AssimilatePositions(int ind, int[] numb)
        {
            if (ind == 0) // якщо елемент займає першу (нульову) позицію 

            {
                if (numb[0] < numb[1]) // якщо елемент менший ніж праве число
                {
                    Console.WriteLine("{0} < right number", numb[0]);
                }

                else if (numb[0] > numb[1]) // якщо елемент більший ніж праве число
                {
                    Console.WriteLine("{0} > right number", numb[0]);
                }

                else // якщо елемент дорівнюж правому числу
                {
                    Console.WriteLine("{0} = right number", numb[0]);
                }
            }



            else if (ind == numb.Length - 1) // якщо елемент займає останню позицію 

            {
                if (numb[numb.Length - 1] < numb[numb.Length - 2])
                {
                    Console.WriteLine("{0} < left number", numb[ind]); // якщо елемент менший ніж ліве число
                }

                else if (numb[numb.Length - 1] > numb[numb.Length - 2]) // якщо елемент більший ніж ліве число
                {
                    Console.WriteLine("{0} > left number", numb[ind]);
                }

                else
                {
                    Console.WriteLine("{0} = left number", numb[ind]); // якщо елемент дорівнює лівому числу
                }
            }



            else // якщо у елемента є два сусіди

            {
                if (numb[ind] < numb[ind + 1]) // якщо елемент менший відносно правого сусіда
                {
                    if (numb[ind] < numb[ind - 1])
                    {
                        Console.WriteLine("{0} < right and left numbers", numb[ind]); // якщо менший відносно лівого сусіда
                    }

                    else if (numb[ind] == numb[ind - 1])
                    {
                        Console.WriteLine("{0} < right number and = left number", numb[ind]); // якщо дорівнює лівому сусіду
                    }

                    else
                    {
                        Console.WriteLine("{0} < right number and > left number", numb[ind]); // якщо більший ніж лівий сусід
                    }
                }



                else if (numb[ind] == numb[ind + 1]) // якщо дорівнює правому сусіду

                {
                    if (numb[ind] < numb[ind - 1]) // якщо менший відносно лівого сусіда
                    {
                        Console.WriteLine("{0} = right number and < left number", numb[ind]);
                    }

                    else if (numb[ind] == numb[ind - 1])
                    {
                        Console.WriteLine("{0} = right and left number", numb[ind]); // якщо дорівнює лівому сусіду
                    }

                    else
                    {
                        Console.WriteLine("{0} = right and > left number", numb[ind]); // якщо більший ніж лівий сусід
                    }
                }



                else // якщо більший ніж правий сусід
                {
                    if (numb[ind] > numb[ind - 1])
                    {
                        Console.WriteLine("{0} > right number and < left number", numb[ind]); // якщо менший відносно лівого сусіда
                    }

                    else if (numb[ind] == numb[ind - 1])
                    {
                        Console.WriteLine("{0} > right number and = left number", numb[ind]); // якщо дорівнює лівому сусіду
                    }
                    else

                    {
                        Console.WriteLine("{0} is > right and left numbers", numb[ind]); // якщо більший ніж лівий сусід
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] numb = new int[size];

            for (int i = 0; i < numb.Length; i++)
            {
                Console.Write("Enter your number (with index {0}): ", i);
                numb[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter number index: ");
            int ind = int.Parse(Console.ReadLine());

            AssimilatePositions(ind, numb);
        }
    }

}
