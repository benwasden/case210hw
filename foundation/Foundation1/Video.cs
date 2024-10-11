using System;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int CommentCount()
    {
        int totalComments = _comments.Count();
        return totalComments;
    }
    public void Display()
    {
        Console.WriteLine($"Title: {_title} - Author: {_author} - Length: {_length} seconds");
        Console.WriteLine();
        int commentTally = CommentCount();
        Console.WriteLine($"{commentTally} comments. Printing below...");
        Console.WriteLine();
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}