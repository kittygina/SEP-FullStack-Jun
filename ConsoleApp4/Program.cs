// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        int height = 5;  // The height of the pyramid, or the number of lines

        for (int i = 1; i <= height; i++)
        {
            // Print spaces
            for (int spaces = height - i; spaces > 0; spaces--)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int stars = 1; stars <= 2 * i - 1; stars++)
            {
                Console.Write("*");
            }

            // Move to the next line
            Console.WriteLine();
        }
    }
}
