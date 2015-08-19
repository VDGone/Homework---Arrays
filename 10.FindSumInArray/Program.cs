using System;

class Program
{
    static void Main(string[] args)
    {
        //Write a program that finds in given array of integers a sequence of given sum S (if present).

        Console.WriteLine("Enter size for array: ");
        int size = int.Parse(Console.ReadLine());
        int[] myArr = new int[size];
        Console.WriteLine("Sum = ");
        int sum = int.Parse(Console.ReadLine());
        int tmpSum = 0;

        for (int i = 0; i < myArr.Length; i++)
        {
            Console.WriteLine("Enter number: ");
            myArr[i] = int.Parse(Console.ReadLine());
        }

        bool sequence = false;
        for (int i = 0; i < myArr.Length; i++)
        {
            for (int j = i; j < myArr.Length; j++)
            {
                tmpSum += myArr[j];
                if (sum == tmpSum)
                {
                    sequence = true;
                    Console.Write("There is sequence with that sum: {0}: ", sum);
                    for (int seqNumber = i; seqNumber <= j; seqNumber++)
                    {
                        Console.Write("{0} ", myArr[seqNumber]);
                    }
                    Console.WriteLine();
                }
            }
            tmpSum = 0;
        }
        if (!sequence)
        {
            Console.WriteLine("Sum is not found!");
        }
    }
}

