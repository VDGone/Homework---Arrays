using System;
using System.Linq;

class QuickSort
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size for array: ");
        int size = int.Parse(Console.ReadLine());
        int[] myArr = new int[size];

        for (int i = 0; i < myArr.Length; i++)
        {
            Console.WriteLine("Enter number: ");
            myArr[i] = int.Parse(Console.ReadLine());
        }

        QuickSortAlg(myArr, 0, myArr.Length - 1);
        foreach (var item in myArr)
        {
            Console.Write(item + ",");
        }
    }

    static void QuickSortAlg(int[] myArr, int left, int right)
    {
        int originalLeft = left;
        int originalRight = right;
        int pivot = myArr[(left + right) / 2];

        while (left < right)
        {
            while (pivot > myArr[left])
            {
                left++;
            }
            while (pivot < myArr[right])
            {
                right--;
            }
            if (left <= right)
            {
                int temp = myArr[left];
                myArr[left] = myArr[right];
                myArr[right] = temp;

                left++;
                right--;
            }
        }
        if (originalLeft < right)
        {
            QuickSortAlg(myArr, originalLeft, right);
        }
        if (left < originalRight)
        {
            QuickSortAlg(myArr, left, originalRight);
        }
    }
}
