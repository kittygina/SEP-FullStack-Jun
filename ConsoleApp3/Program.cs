using System;

class Program
{
    static void Main()
    {
        // Create a random number generator
        Random random = new Random();
        
        // Generate a random number between 1 and 3
        int correctNumber = random.Next(3) + 1;
        
        Console.WriteLine("Guess a number between 1 and 3:");

        // Get user input and convert it to an integer
        int guessedNumber;
        try
        {
            guessedNumber = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
            return;
        }

        // Check if the guess is outside the valid range
        if (guessedNumber < 1 || guessedNumber > 3)
        {
            Console.WriteLine("Your guess is out of the allowed range (1 to 3). Please guess a number within the range.");
        }
        else if (guessedNumber < correctNumber)
        {
            Console.WriteLine("Too low.");
        }
        else if (guessedNumber > correctNumber)
        {
            Console.WriteLine("Too high.");
        }
        else
        {
            Console.WriteLine("Correct! Well done.");
        }
    }
}