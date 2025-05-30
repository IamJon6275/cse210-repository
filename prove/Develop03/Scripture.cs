using System;

public class Scripture
{
    private List<Word> _words;

    private List<int> _visibleList;

    public Scripture(string text)
    {
        _words = new List<Word>();
        string[] strings = text.Split(' ');
        foreach (string w in strings)
        {
            Word newWord = new Word(w);
            _words.Add(newWord);
        }
    }

    public void DisplayScripture()
    {
        foreach (Word w in _words)
        {
            Console.Write($"{w.GetWord()} ");
        }
    }

    // public void HideWord(int)
    // {

    // }

    // public bool IsScriptureHidden()
    // {

    // }

}