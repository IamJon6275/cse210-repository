using System;
using System.Dynamic;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private string _refer;
    // "John 14:6 Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me."
    // public string DisplayReference()
    // {

    // }

    public Reference(string _book = "John", int _chapter = 14, int _startVerse = 6)
    {
        _refer = new Reference(r);
        _refer = $"{_book}, {_chapter}:{_startVerse}";
    }

    public Reference(string _book, int _chapter, int _startVerse, int _endVerse)
    {
        _refer = $"{_book}, {_chapter}:{_startVerse}-{_endVerse}";
    }

    public void DisplayReference()
    {
        Console.WriteLine(_refer);
    }
    
}