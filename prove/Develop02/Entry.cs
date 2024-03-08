
using System;
public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void GenerateDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

    public void GeneratePrompt()
    {
        List<string> prompts = new List<string>()
           {
        "Did anything unexpected happen today that surprised you? ",
        "Who was the most interesting person I interacted with today?",
        "What was the most challenging thing you faced today and how did you overcome it? ",
        "What was the best part of my day and why?",
        "Who did you share a special moment with today? ",
        "How did I see the hand of the Lord in my life today?",
        "Did you achieve any success in your work, studies or personal projects today? ",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Did someone make you feel special or make you smile today?" ,
        "Did you discover anything new or learn something interesting today? ",
        "What was a small act of kindness I witnessed or experienced today?",
        "Reflect on a challenge or obstacle you faced today and how you overcame it.",
        "How did you show love or compassion towards others today, inspired by your faith? ",
        "What do you most wish for tomorrow? ",
        "What was the most inspiring thing you heard or read today that strengthened your faith? ",
        "Reflect on a moment of gratitude for something or someone in your life.",
        "Write about a future adventure or travel destination you're excited about.",
        "What was the most meaningful spiritual experience you had today? ",
        "How did you demonstrate your faith through actions or choices you made today? ",
        "What was the most inspiring thing you heard or read today that strengthened your faith? ",
    };

        Random rand = new Random();
        int randomIndex = rand.Next(prompts.Count);
        _prompt = prompts[randomIndex];
        Console.WriteLine(_prompt);
    }

    public void GetResponse()
    {
        Console.Write("> ");
        _response = Console.ReadLine();
    }
}