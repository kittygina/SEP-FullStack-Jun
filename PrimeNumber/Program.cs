// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] primes = FindPrimesInRange(1, 100);
        Console.WriteLine("Prime numbers in the given range:");
        foreach (int prime in primes)
        {
            Console.WriteLine(prime);
        }
    }

    static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();

        for (int num = startNum; num <= endNum; num++)
        {
            if (IsPrime(num))
            {
                primes.Add(num);
            }
        }

        return primes.ToArray();
    }

    static bool IsPrime(int num)
    {
        if (num <= 1) return false; // 0 and 1 are not prime numbers
        if (num <= 3) return true;  // 2 and 3 are prime numbers

        if (num % 2 == 0 || num % 3 == 0) return false; // Exclude multiples of 2 and 3

        for (int i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
                return false;
        }

        return true;
    }
}
