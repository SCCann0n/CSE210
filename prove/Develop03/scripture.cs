using System;
using System.Linq;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _allWords = new List<Word>(); 

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string wordText in words)
        {
            _allWords.Add(new Word(wordText));
        }
    }    


    public void Display()
    {

        Console.Write($"{_reference.DisplayReference()}");

        foreach (var word in _allWords)
        {
            Console.Write($"{word.GetDisplayText()} ");
        }

        Console.WriteLine();
    }

    public void HideWords()
    {
        List<Word> availableWords = _allWords.Where(w => !w.IsHidden()).ToList();

        if (availableWords.Count() == 0)
        {
            return;
        }

        int totalWordsToHide = (int)Math.Ceiling(_allWords.Count * 0.1);

        int numberToHide = Math.Min(totalWordsToHide, availableWords.Count);

        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int RandomIndex = random.Next(0, availableWords.Count);
            Word wordToHide = availableWords[RandomIndex];

            wordToHide.Hide();

            availableWords.RemoveAt(RandomIndex);
        }
    }

    public bool IsDone()
    {
        return _allWords.All(w => w.IsHidden());
    }

}
// use random to select words from the scripture
// use .replace to replace those words with _____
// .replace([index], "_______")