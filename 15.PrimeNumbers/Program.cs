using System;

class Program
{
    static void Main(string[] args)
    {
        //Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
        
        int n = 10000000;
        bool[] isPrime = new bool[n];
        for (int i = 2; i < n; i++)
        {
            isPrime[i] = true;
        } 
        for (int j = 2; j < n; j++)
        {
            if (isPrime[j])
            {
                for (int p = 2; (p * j) < n; p++)
                {
                    isPrime[p * j] = false;
                }
            }
        }
        Console.Write("Prime numbers: ");
        for (int i = 2; i < isPrime.Length; i++)
        {
            if (isPrime[i]) Console.Write(i + ",");
        }
    }
}

