using System;
using System.Dynamic;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private string _refer;

    public Reference(string _book, int _chapter, int _startVerse)
    {
        _refer = $"{_book} {_chapter}:{_startVerse} ";
    }

    public Reference(string _book, int _chapter, int _startVerse, int _endVerse)
    {
        _refer = $"{_book} {_chapter}:{_startVerse}-{_endVerse} ";
    }

    public void DisplayReference()
    {
        Console.Write(_refer);
    }
    
}