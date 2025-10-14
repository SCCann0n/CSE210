namespace myJournal;

using System.Text.Json;
using System;

public class Journal
{
    public List<Entry> _userEntry = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _userEntry.Add(entry);
    }

    public void DisplayJournal()
    {
        if (_userEntry.Count == 0)
        {
            Console.WriteLine("No entries found. ");
        }

        foreach (Entry entry in _userEntry)
        {
            Console.WriteLine(entry.GetFullEntry());
        }
    }

    public void SaveToFile(string filename)
    {
        
        string json = JsonSerializer.Serialize(_userEntry, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filename, json);
        Console.WriteLine("Journal saved to " + filename);
        
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
           string json = File.ReadAllText(filename);
            _userEntry = JsonSerializer.Deserialize<List<Entry>>(json);
            Console.WriteLine("Journal loaded from " + filename);
        }

        else
        {
            Console.WriteLine("File not found.");
        }
        
    }

}
