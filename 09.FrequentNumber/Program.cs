using System;

class Program
{
    static void Main()
    {
        //Write a program that finds the most frequent number in an array.

        Console.WriteLine("Enter size for array: ");
        int size = int.Parse(Console.ReadLine());
        int[] myArr = new int[size];
        int count = 0;
        int currIndex = 0;
        int maxCount = 0;
        int freqNum = 0;

        for (int i = 0; i < myArr.Length; i++)
        {
            Console.WriteLine("Enter number: ");
            myArr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(myArr);
        for (int i = 0; i < myArr.Length; i++)
        {
            if (myArr[i] != myArr[currIndex])
            {
                currIndex = i;
                count = 1;
            }
            else if (myArr[i] == myArr[currIndex])
            {
                count += 1;
            }
            if (maxCount < count)
            {
                maxCount = count;
                freqNum = myArr[i];
            }
        }
        if (maxCount > 1)
        {
            Console.WriteLine("Most frequent number is: {0} ({1} times.)", freqNum, maxCount);
        }
        else
        {
            Console.WriteLine("There is no frequent number.");
        }
    }
}

