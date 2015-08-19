using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that reads two integer numbers N and K and an array of N elements from the console.
        //Find in the array those K elements that have maximal sum.

        Console.WriteLine("Enter value for N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for K: ");
        int k = int.Parse(Console.ReadLine());
        int[] myArr = new int[n];
        int[] reversed = new int[n];
        int sum = 0;

        for (int i = 0; i < myArr.Length; i++)
        {
            Console.WriteLine("Enter number: ");
            myArr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(myArr);
        for (int i = 0; i < myArr.Length; i++)
        {
            reversed[n - i - 1] = myArr[i];
        }
        for (int i = 0; i < k; i++)
        {
            sum += reversed[i];
        }
        Console.WriteLine("Sum of K numbers = {0}.", sum);
    }
}
