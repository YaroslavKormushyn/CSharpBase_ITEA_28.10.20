using System;

namespace LexicographicalComparison
{
    class Program
    {
        public static void LexicographicalComparison(bool flagEqual, char[] array1, char[] array2)
        {
            if (array1.Length > array2.Length) Console.WriteLine("\nSecond array is lexicographicaly first.");
            else if (array1.Length < array2.Length) Console.WriteLine("\nFirst array is lexicographicaly first.");
            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] < array2[i])
                    {
                        Console.WriteLine("\nFirst array is lexicographicaly first.");
                        flagEqual = false;
                        break;
                    }
                    if (array1[i] > array2[i])
                    {
                        Console.WriteLine("\nSecond array is lexicographicaly first.");
                        flagEqual = false;
                        break;
                    }
                }
                if (flagEqual) Console.WriteLine("\nArrays are lexicographicaly equal.");
            }
        }
        static void Main()
        {
            bool flagEqual = true;
            char[] array1 = new char[3] { 'a', 'b', 'c' };
            char[] array2 = new char[5] { 'a', 'b', 'c', 'n', 'f' };
            Console.WriteLine("First Array:");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine("\nSecond Array:");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
            LexicographicalComparison(flagEqual, array1, array2);
        }
    }
}
/* Console.Write("Enter the length of the array : ");
 if (!int.TryParse(Console.ReadLine(), out int length1))
 {
     Console.WriteLine("The wrong input! ");
     return;
 }
 char[] array1 = new char[length1];
 for (int i = 0; i < array1.Length; i++)
 {
     Console.Write("Enter {0} element: ", i);
     if (char.TryParse(Console.ReadLine(), out array1[i]))
     {
         Console.WriteLine("The wrong input! ");
         break;
     }
 }
 Console.Write("Enter the length of the array : ");
 if (!int.TryParse(Console.ReadLine(), out int length2))
 {
     Console.WriteLine("The wrong input! ");
     return;
 }
 char[] array2 = new char[length2];
 for (int i = 0; i < array2.Length; i++)
 {
     Console.Write("Enter {0} element: ", i);
     if (ToCharArray.TryParse(Console.ReadLine(), out array2[i]))
     {
         Console.WriteLine("The wrong input! ");
         break;
     }
 }
*/

