using System;

class Breathing : MindfulnessActivity
{
    protected override string GetDescription()
    {
        return "Breathing Exercise:\nThis activity will help you relax by guiding your breathing.";
    }

    protected override void RunActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(duration);
            
            Console.Write("Breathe out... ");
            ShowCountdown(duration);
        }
    }
}

