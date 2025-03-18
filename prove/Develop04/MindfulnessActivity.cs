using System;
using System.Threading;

abstract class MindfulnessActivity
{
    protected int duration;

    public void Start()
    {
        Console.Clear();
        Console.WriteLine(GetDescription());
        Console.Write("Enter duration (seconds): ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowCountdown(3);

        RunActivity();

        Console.WriteLine("\nGreat job! You completed the activity.");
        Console.WriteLine($"Total time: {duration} seconds.");
        ShowCountdown(3);
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected abstract void RunActivity();
    protected abstract string GetDescription();
}
