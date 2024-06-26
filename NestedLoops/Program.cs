// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        // Reading input
        Console.WriteLine("Enter integers separated by spaces:");
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        Console.WriteLine("Enter the number of rotations:");
        int k = int.Parse(Console.ReadLine());

        int n = array.Length;
        int[] sumArray = new int[n];

        // Performing k rotations
        for (int rotation = 1; rotation <= k; rotation++)
        {
            int[] rotatedArray = new int[n];

            // Rotating the array
            for (int i = 0; i < n; i++)
            {
                int newPosition = (i + rotation) % n;
                rotatedArray[newPosition] = array[i];
            }

            // Summing up rotated arrays
            for (int i = 0; i < n; i++)
            {
                sumArray[i] += rotatedArray[i];
            }

            // Optional: Output the rotated array for each rotation
            Console.WriteLine($"rotated[{rotation}] = {string.Join(" ", rotatedArray)}");
        }

        // Output the final sum array
        Console.WriteLine($"sum[] = {string.Join(" ", sumArray)}");
    }
}
