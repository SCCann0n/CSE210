namespace myJournal;

using System;

public class Prompt
{
    public List<string> _userPrompt = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "How did I see my prayers answered today?",
    "What are some ways that I helped others today?",
        "What are some ways that others helped me today",
    };

    public Random _random = new Random();

    public string GetPrompt()
    {
        int randIndex = _random.Next(0, _userPrompt.Count);
        return _userPropmt[randIndex];
    }
}