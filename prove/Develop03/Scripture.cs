using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private List<Word> wordList;
    private List<Word> hiddenWordList;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        wordList = text.Split(' ').Select(w => new Word(w)).ToList();
        hiddenWordList = new List<Word>();
    }

    public Reference Reference { get; }

    public void HideRandomWord()
    {
        var visibleWords = wordList.Except(hiddenWordList).ToList();
        if (visibleWords.Count > 0)
        {
            Word wordToHide = visibleWords[_random.Next(visibleWords.Count)];
            wordToHide.Hide_Value();
            hiddenWordList.Add(wordToHide);
        }
    }

    public void Display()
    {
        Console.WriteLine($"{Reference.Display()} {string.Join(" ", wordList.Select(w => w.show_Value()))}");
    }

    public bool AllWordsHidden()
    {
        return wordList.All(w => w.IsHidden);
    }
}
