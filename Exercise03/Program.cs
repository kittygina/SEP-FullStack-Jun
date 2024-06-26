// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
         {
             string output = "";
             if (i % 3 == 0) output += "Fizz";
             if (i % 5 == 0) output += "Buzz";
             if (output == "") output = i.ToString(); // If neither, print the number
             Console.WriteLine(output);
         }
     }
    
}

