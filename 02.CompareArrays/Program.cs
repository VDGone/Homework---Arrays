using System;

class Program
{
    static void Main()
    {
        //Write a program that reads two integer arrays from the console and compares them element by element.

        Console.WriteLine("Enter length of both arrays: ");
        int lengthOfArrays = int.Parse(Console.ReadLine());
        int[] myArrOne = new int[lengthOfArrays];
        int[] myArrTwo = new int[lengthOfArrays];
        
        Console.WriteLine("Enter values for first array: ");
        for (int i = 0; i < myArrOne.Length; i++)
        {
            myArrOne[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter values for second array: ");
        for (int i = 0; i < myArrTwo.Length; i++)
        {
            myArrTwo[i] = int.Parse(Console.ReadLine());
        }
        bool areEquals = true;
        for (int i =0; i < lengthOfArrays; i++)
        {
            if (myArrOne[i] != myArrTwo[i])
            {
                areEquals = false;
            }
        }
        Console.WriteLine("Are equals = {0}!", areEquals);
    }
}

