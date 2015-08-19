using System;

class Program
{
    static void Main(string[] args)
    {
        //Write a program that creates an array containing all letters from the alphabet (A-Z).
        //Read a word from the console and print the index of each of its letters in the array.

        Console.WriteLine("Enter word: ");
        string word = Console.ReadLine();
        char[] allLetters = {
                            'a', 'b', 'c', 'd',
                            'e', 'f', 'g', 'h', 
                            'i', 'j', 'k', 'l',
                            'm', 'n', 'o', 'p',
                            'q', 'r', 's', 't', 
                            'u', 'v', 'w', 'x', 
                            'y', 'z' };
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < allLetters.Length; j++)
            {
                if (word[i] == allLetters[j])
                {
                    Console.WriteLine("Letter -{0}; index = {1}", allLetters[j], j);
                }
            }
        }
    }
}

