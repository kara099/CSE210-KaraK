using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;

public class RandomPrompt
{
    private List<string> prompts = new List<string>
    {
        "What made you smile today",
        "Describe a moment that made you feel grateful.",
        "What did you learn today?",
        "How did you see the hand of the Lord in your life today?",
        "What was the best part of your day?",
        "Who was the most interesting person I interacted with today?"
    };
    private Random random = new Random();

    public string ChoosePrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }

    public void WritePrompt()
    {
        Console.WriteLine("Prompt: " + ChoosePrompt());
    }
}

public class Entry
{
    public string Input { get; set; }
    public string Prompt { get; set; }
    public DateTime Date { get; set; }

    public void DisplayPrompt()
    {
        Console.WriteLine("Prompt: " + Prompt);
    }

    public void GetAnswer()
    {
        Console.Write("Your answer: ");
        Input = Console.ReadLine();
        Date = DateTime.Now;
    }
}

public class Journal
{
    public string FilePath { get; set; }
    public string Menu { get; set; } = "1. Add Entry\n2. Display Journal\n3. Save & Exit";
    public List<Entry> Entries { get; set; } = new List<Entry>();

    public void DisplayMenu()
    {
        Console.WriteLine(Menu);
    }

    public void LoadFile()
    {
        if (File.Exists(FilePath))
        {
            var lines = File.ReadAllLines(FilePath);
            foreach (var line in lines)
            {
                var parts = line.Split("|");
                var entry = new Entry
                {
                    Prompt = parts[0],
                    Input = parts [1],
                    Date = DateTime.Parse(parts[2])
                };
                Entries.Add(entry);
            }
        }
    }

    public void SaveFile()
    {
        var lines = new List<string>();
        foreach (var entry in Entries)
        {
            lines.Add($"{entry.Prompt}|{entry.Input}|{entry.Date}");
        }
        File.WriteAllLines(FilePath, lines);
    }

    public void DisplayJournal()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine($"[{entry.Date}] Prompt: {entry.Prompt}\nAnswer: {entry.Input}\n");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string filename = "journal.txt";
        Journal journal = new Journal { FilePath = filename };
        RandomPrompt randomPrompt = new RandomPrompt();
        journal.LoadFile();

        bool running = true;
        while (running)
        {
            journal.DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = randomPrompt.ChoosePrompt();
                    Entry newEntry = new Entry { Prompt = prompt };
                    newEntry.DisplayPrompt();
                    newEntry.GetAnswer();
                    journal.Entries.Add(newEntry);
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    journal.SaveFile();
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}