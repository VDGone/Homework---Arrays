﻿using System;

class Program
{
    static void Main(string[] args)
    {
        //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
        //Print the obtained array on the console.

        int[] myArr = new int[20];

        for (int index = 0; index < myArr.Length; index++)
        {
            myArr[index] = index * 5;
            Console.WriteLine("index of array: {0}, index * 5 = {1}", index, myArr[index]);
        }
    }
}

