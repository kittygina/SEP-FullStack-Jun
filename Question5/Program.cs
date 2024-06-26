// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        DateTime currentTime = DateTime.Now;

        
        Console.WriteLine("Current time: " + currentTime.ToString("HH:mm"));

     
        int hour = currentTime.Hour; 

        if (hour >= 6 && hour < 12)
        {
            Console.WriteLine("Good Morning");
        }

        if (hour >= 12 && hour < 17)
        {
            Console.WriteLine("Good Afternoon");
        }

        // "Good Evening" from 5 PM to 8:59 PM
        if (hour >= 17 && hour < 21)
        {
            Console.WriteLine("Good Evening");
        }

        // "Good Night" from 9 PM to 5:59 AM
        if (hour >= 21 || hour < 6)
        {
            Console.WriteLine("Good Night");
        }
    }
}
