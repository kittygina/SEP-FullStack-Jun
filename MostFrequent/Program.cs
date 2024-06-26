// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of numbers separated by spaces:");
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Dictionary<int, int> frequency = new Dictionary<int, int>();
        List<int> firstOccurrences = new List<int>();

        // Count frequency of each number
        foreach (int number in numbers)
        {
            if (!frequency.ContainsKey(number))
            {
                frequency[number] = 0;
                firstOccurrences.Add(number); // Track the first occurrence of each number
            }
            frequency[number]++;
        }

        // Determine the maximum frequency
        int maxFrequency = frequency.Values.Max();

        // Filter the numbers with the maximum frequency
        var maxFreqNumbers = firstOccurrences.Where(num => frequency[num] == maxFrequency);

        // Output results
        if (maxFreqNumbers.Count() == 1)
        {
            Console.WriteLine($"The number {maxFreqNumbers.First()} is the most frequent (occurs {maxFrequency} times)");
        }
        else
        {
            Console.WriteLine($"The numbers {string.Join(", ", maxFreqNumbers)} have the same maximal frequency (each occurs {maxFrequency} times). The leftmost of them is {maxFreqNumbers.First()}.");
        }
    }
}
