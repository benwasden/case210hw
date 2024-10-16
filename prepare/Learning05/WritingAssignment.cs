using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string bookName) : base(name, topic)
    {
        _title = bookName;
    }

    public string GetWritingInformation()
    {
        return ($"{_title} by {_studentName}");
    }
}