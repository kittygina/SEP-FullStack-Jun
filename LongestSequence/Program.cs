// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of integers separated by spaces:");
        string[] inputs = Console.ReadLine().Split();

        int[] array = Array.ConvertAll(inputs, int.Parse);
        int maxLength = 0;
        int currentLength = 1;
        List<int> longestSequence = new List<int>();
        int currentNumber = array[0];

        // Find the longest sequence
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentLength++;
            }
            else
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    longestSequence.Clear();
                    longestSequence.AddRange(new int[currentLength]);
                    for (int j = 0; j < currentLength; j++)
                    {
                        longestSequence[j] = currentNumber;
                    }
                }
                // Reset for the next sequence
                currentNumber = array[i];
                currentLength = 1;
            }
        }

        // Check the last sequence
        if (currentLength > maxLength)
        {
            longestSequence.Clear();
            longestSequence.AddRange(new int[currentLength]);
            for (int j = 0; j < currentLength; j++)
            {
                longestSequence[j] = currentNumber;
            }
        }

        // Output the longest sequence
        Console.WriteLine("Longest sequence:");
        foreach (var item in longestSequence)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
