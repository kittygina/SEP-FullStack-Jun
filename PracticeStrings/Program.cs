using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1: Reverse a string");
            Console.WriteLine("2: Reverse words in a sentence");
            Console.WriteLine("3: Extract palindromes");
            Console.WriteLine("4: Parse URL");
            Console.WriteLine("5: Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ReverseString();
                    break;
                case "2":
                    ReverseWordsInSentence();
                    break;
                case "3":
                    ExtractPalindromes();
                    break;
                case "4":
                    ParseURL();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    static void ReverseString()
    {
        Console.WriteLine("Enter a string to reverse:");
        string input = Console.ReadLine();
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine("Reversed string:");
        Console.WriteLine(new string(charArray));
    }

    static void ReverseWordsInSentence()
    {
        Console.WriteLine("Enter a sentence to reverse its words:");
        string input = Console.ReadLine();
        var words = input.Split(' ');
        Array.Reverse(words);
        Console.WriteLine("Sentence with reversed words:");
        Console.WriteLine(String.Join(" ", words));
    }

    static void ExtractPalindromes()
    {
        Console.WriteLine("Enter text to extract palindromes:");
        string input = Console.ReadLine();
        var words = Regex.Matches(input, @"\w+")
            .Cast<Match>()
            .Select(m => m.Value)
            .Where(w => w.SequenceEqual(w.Reverse()) && w.Length > 1)
            .Distinct()
            .OrderBy(w => w)
            .ToList();

        Console.WriteLine("Palindromes found:");
        Console.WriteLine(string.Join(", ", words));
    }

    static void ParseURL()
    {
        Console.WriteLine("Enter URL to parse:");
        string url = Console.ReadLine();
        var regex = new Regex(@"^(?:(?<protocol>\w+):\/\/)?(?<server>[^\/]+)(?<resource>\/.*)?$");
        var match = regex.Match(url);

        if (match.Success)
        {
            Console.WriteLine($"Protocol: {match.Groups["protocol"].Value}");
            Console.WriteLine($"Server: {match.Groups["server"].Value}");
            Console.WriteLine($"Resource: {match.Groups["resource"].Value}");
        }
        else
        {
            Console.WriteLine("Invalid URL format.");
        }
    }
}
