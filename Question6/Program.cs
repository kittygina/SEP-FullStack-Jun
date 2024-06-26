// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        // Outer loop for the increments (1, 2, 3, 4)
        for (int increment = 1; increment <= 4; increment++)
        {
            // Start the output for the current increment
            Console.Write("0");

            // Inner loop for counting up to 24 with the current increment
            for (int i = increment; i <= 24; i += increment)
            {
                Console.Write($",{i}");
            }

            // Move to the next line after finishing with one increment
            Console.WriteLine();
        }
    }
}
