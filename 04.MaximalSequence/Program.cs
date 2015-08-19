using System;

class Program
{
    static void Main()
    {
        //Write a program that finds the maximal sequence of equal elements in an array.

        Console.WriteLine("Enter size of array.");
        int size = int.Parse(Console.ReadLine());
        int[] myArr = new int[size];
        int currLength = 1;
        int currElement = myArr[0];
        int bestElement = 0;
        int bestLength = 0;

        for (int i = 0; i < myArr.Length; i++)
        {
            Console.WriteLine("Enter numbers: ");
            myArr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < myArr.Length; i++)
        {
            if (myArr[i] == currElement)
            {
                currLength++;
            }
            else
            {
                currElement = myArr[i];
                currLength = 1;
            }

            if (currLength >= bestLength)
            {
                bestLength = currLength;
                bestElement = currElement;
            }
        }
        for (int i = 0; i < bestLength; i++)
        {
            Console.Write("{0}, ", bestElement);
        }
    }
}
