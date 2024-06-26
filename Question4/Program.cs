// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        
        DateTime birthDate = new DateTime(1998, 4, 27);  

        // Calculate the age in days
        TimeSpan age = DateTime.Today - birthDate;
        int daysOld = age.Days;
        Console.WriteLine($"You are {daysOld} days old.");

        // Calculate days until the next 10,000 day anniversary
        int daysToNextAnniversary = 10000 - (daysOld % 10000);
        DateTime nextAnniversary = DateTime.Today.AddDays(daysToNextAnniversary);

        // Output the date of the next anniversary
        Console.WriteLine($"Your next 10,000 day anniversary will be on {nextAnniversary.ToShortDateString()}.");
    }
}
