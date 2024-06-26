// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main()
    {
        // Create a Random object to generate random numbers
        Random random = new Random();
        
        // Generate a random number between 1 and 3
        int correctNumber = random.Next(1, 4);  // Random.Next(1, 4) generates a random number in the range [1, 3]

        Console.WriteLine("Guess a number between 1 and 3:");

        // Read the user input and convert it to an integer
        int guessedNumber = int.Parse(Console.ReadLine());

        // Check if the guess is outside the valid range
        if (guessedNumber < 1 || guessedNumber > 3)
        {
            Console.WriteLine("Your guess is out of the valid range. Please guess a number between 1 and 3.");
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
