using System;

class Program
{
    static void Main()
    {
        //Write a program that finds the sequence of maximal sum in given array.

        Console.WriteLine("Enter size for array: ");
        int size = int.Parse(Console.ReadLine());
        int[] myArr = new int[size];
        int maxSum = 0;
        int currentSum = 0;
        int tmpStart = 0;
        int tmpEnd = 0;
        int seqStart = 0;
        int seqEnd = 0;
        for (int i = 0; i < myArr.Length; i++)
        {
            Console.WriteLine("Enter number: ");
            myArr[i] = int.Parse(Console.ReadLine());
        }
        
        while (tmpEnd < myArr.Length)
        {
            currentSum += myArr[tmpEnd];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                seqStart = tmpStart;
                seqEnd = tmpEnd;
            }
            else if (currentSum < 0)
            {
                tmpStart = tmpEnd + 1;
                currentSum = 0;
            }
            tmpEnd++;
        }
        for (int seq = seqStart; seq <= seqEnd; seq++)
        {
            Console.Write(myArr[seq] + ", ");
        }
    }
}

