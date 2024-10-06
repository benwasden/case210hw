using System;
using System.Collections.Concurrent;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        // _reference = new Reference(book, chapter, verse);
        _reference = reference;
        _words = new List<Word>();

        string[] verseWords = text.Split(' ');
        foreach (string word in verseWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // Set state of random selected group of words to be hidden

        // Find a set of visible words

        // Use Hide function

        int sizeOfList = _words.Count();

        int hiddenWordsCount = 0;

        Random randomGenerator = new Random();

        while (hiddenWordsCount < numberToHide)
        {
            int randomIndex = randomGenerator.Next(0, sizeOfList);

            Word currentWord = _words[randomIndex];

            if (currentWord.isHidden() == false)
            {
                currentWord.Hide();
                hiddenWordsCount ++;
            }
        }   
    }

    public string GetDisplayText()
    {
        // Iterate through each word and call GetDisplayText
        // Console.WriteLine($"{_reference}:");

        string displayedText = "";

        foreach (Word word in _words)
        {
            displayedText = displayedText + word.GetDisplayText() + " ";
        }
        return displayedText;
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.isHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}