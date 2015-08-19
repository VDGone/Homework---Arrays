using System;

class Program
{
    static void Main()
    {
        //Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
        //Use the Selection sort algorithm: Find the smallest element, move it at the first position,
        //find the smallest from the rest, move it at the second position, etc.

        Console.WriteLine("Enter size for array.");
        int n = int.Parse(Console.ReadLine());
        int[] myArr = new int[n];
        int temp = 0;

        for (int i = 0; i < myArr.Length; i++)
        {
            Console.WriteLine("Enter number: ");
            myArr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < myArr.Length; i++)
        {
            for (int j = i + 1; j < myArr.Length; j++)
            {
                if (myArr[i] > myArr[j])
                {
                    temp = myArr[i];
                    myArr[i] = myArr[j];
                    myArr[j] = temp;
                }
            }
        }
        for (int i = 0; i < myArr.Length; i++)
        {
            Console.Write(myArr[i] + ", ");
        }
    }
}
