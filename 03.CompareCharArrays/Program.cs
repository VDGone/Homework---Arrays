using System;

class Program
{
    static void Main()
    {
        //Write a program that compares two char arrays lexicographically (letter by letter).
        Console.WriteLine("Enter lentgh for first array.");
        int lentgh1 = int.Parse(Console.ReadLine());
        char[] textOne = new char[lentgh1];
        Console.WriteLine("Enter lentgh for second array.");
        int lentgh2 = int.Parse(Console.ReadLine());
        char[] textTwo = new char[lentgh2];
        bool isEqual = true;

        if (lentgh1 == lentgh2)
        {
            for (int i = 0; i < textOne.Length; i++)
            {
                Console.WriteLine("Input chars in first array to compare: ");
                textOne[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < textTwo.Length; i++)
            {
                Console.WriteLine("Input chars in second array to compare: ");
                textTwo[i] = char.Parse(Console.ReadLine());
            }
            for(int i = 0; i < lentgh1; i++)
            {
                
                if (textOne[i] != textTwo[i])
                {
                    isEqual = false;
                }
            }
            Console.WriteLine("Chars are equal ={0} .", isEqual);
        }
        else 
        {
            isEqual = false;
            Console.WriteLine("Chars are equal ={0} .", isEqual);
        }
    }
}

