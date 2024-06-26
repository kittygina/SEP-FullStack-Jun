// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter your favorite color:");
string color = Console.ReadLine();
        
Console.WriteLine("Enter your astrology sign:");
string sign = Console.ReadLine();
        
Console.WriteLine("Enter your street address number:");
string addressNumber = Console.ReadLine();
        
string hackerName = color + sign + addressNumber;
Console.WriteLine($"Your hacker name is {hackerName}.");

