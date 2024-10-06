using System;
using System.Transactions;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
    }
    
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = startVerse;
        this._endVerse = endVerse;
    }

    public string GetDisplayText(string book, int chapter, int startVerse, int endVerse)
    {
        if (startVerse == endVerse)
        {
            return $"{book} {chapter}:{startVerse} ";
        }
        else
        {
            return $"{book} {chapter}:{startVerse}-{endVerse} ";
        }
    }
}