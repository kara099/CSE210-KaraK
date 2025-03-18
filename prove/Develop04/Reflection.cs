using System;
using System.Collections.Generic;

class Reflection : MindfulnessActivity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private static readonly List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?"
    };

    protected override string GetDescription()
    {
        return "Reflection Exercise:\nThis activity helps you reflect on your strengths and resilience.";
    }

    protected override void RunActivity()
    {
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(Questions[random.Next(Questions.Count)] + " ");
            ShowCountdown(5);
        }
    }
}
