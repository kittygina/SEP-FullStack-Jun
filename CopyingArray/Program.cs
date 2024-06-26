// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        // Creating the initial array with 10 items
        int[] originalArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Creating a second array with the same length as the original array
        int[] copiedArray = new int[originalArray.Length];

        // Loop to copy values from the original array to the copied array
        for (int i = 0; i < originalArray.Length; i++)
        {
            copiedArray[i] = originalArray[i];
        }

        // Output the contents of the original array
        Console.WriteLine("Original array contents:");
        foreach (int item in originalArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Output the contents of the copied array
        Console.WriteLine("Copied array contents:");
        foreach (int item in copiedArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
