using System;

class Program
{
    static void Main()
    {
        //Write a program that finds the maximal increasing sequence in an array.

        Console.WriteLine("Enter size of array.");
        int size = int.Parse(Console.ReadLine());
        int[] myArr = new int[size];
        int maxCount = 0;
        int currCount = 1;
        int seqStart = 0;
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Enter number: ", i);
            myArr[i] = int.Parse(Console.ReadLine());
            if (i != 0)
            {
                if (myArr[i] > myArr[i - 1])
                {
                    currCount++;
                }
                else
                {
                    currCount = 1;
                }
                if (currCount > maxCount)
                {
                    maxCount = currCount;
                    seqStart = i + 1 - maxCount;
                }
            }
        }
        for (int i = seqStart; i < seqStart + maxCount; i++)
        {
            Console.Write("{0}, ", myArr[i]);
        }
    }
}
