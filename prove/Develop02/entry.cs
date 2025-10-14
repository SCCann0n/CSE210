namespace myJournal;

using System;

public class Entry
{
    public string _text;

    public DateTime _date;
    // Initialize new date time. Use ".Now" to get the current datetime.

    public string _prompt;

    public void SaveEntry(string text, string date)
    {
        _text = text;
        _date = DateTime.Now;
    }
    
    public string GetEntryText()
    {
        return _text;
    }

    public string GetEntryDate()
    {
        return _date.ToShortDateString();
    }

    public string GetFullEntry()
    {
        return ($"{GetEntryDate()}, - {_prompt}\n{_text}");
    }
}