// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> itemList = new List<string>();
        
        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
            string input = Console.ReadLine();
            
            if (string.IsNullOrEmpty(input))
                continue;

            if (input == "--")
            {
                itemList.Clear();
                Console.WriteLine("List cleared.");
            }
            else if (input.StartsWith("+ "))
            {
                string itemToAdd = input.Substring(2).Trim();
                if (!string.IsNullOrEmpty(itemToAdd))
                {
                    itemList.Add(itemToAdd);
                    Console.WriteLine($"Added: {itemToAdd}");
                }
            }
            else if (input.StartsWith("- "))
            {
                string itemToRemove = input.Substring(2).Trim();
                if (itemList.Contains(itemToRemove))
                {
                    itemList.Remove(itemToRemove);
                    Console.WriteLine($"Removed: {itemToRemove}");
                }
                else
                {
                    Console.WriteLine($"Item not found: {itemToRemove}");
                }
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }

            // Display current list contents
            Console.WriteLine("Current list:");
            foreach (string item in itemList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------");
        }
    }
}
