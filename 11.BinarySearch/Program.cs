using System;

class Program
{
    static void Main()
    {
        //Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

        Console.WriteLine("Enter size for array.");
        int size = int.Parse(Console.ReadLine());
        int[] myArr = new int[size];
        Console.WriteLine("Enter value for element you want to find: ");
        int element = int.Parse(Console.ReadLine());
        int midle;
        int start = 0;
        int end = size - 1;

        for (int i = 0; i < myArr.Length; i++)
        {
            Console.WriteLine("Enter number: ");
            myArr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(myArr);
        bool isFound = true;
        while (start <= end)
        {
            midle = (start + end) / 2;
            if (element == myArr[midle])
            {
                Console.WriteLine("The element was found = {0}.", isFound);
                break;
            }
            else if (element < myArr[midle])
            {
                end = midle - 1;
            }
            else if (element > myArr[midle])
            {
                start = midle + 1;
            }
        }
            Console.WriteLine("The element was found = {0}.", !isFound);
    }
}

