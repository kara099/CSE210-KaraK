﻿using System;

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture(new Reference("D & C", 10, "4"), 
            "Do not run faster or labor more than you have strength and means provided to enable you to translate; but be diligent unto the end.");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWord();
        }

        Console.Clear();
        Console.WriteLine("All words are hidden. Program ending.");
    }
}