using System;

public class Word
{
    private string _word;

    private bool _scriptureHidden;

    public Word(string word)
    {
        _word = word;
    }

    public string GetWord()
    {
        return _scriptureHidden ? new('_', _word.Length) : _word;
        // is the below code, taught by a tutor at the drop in lab
        // if (_scriptureHidden)
        // {
        //     return new('_', _word.Length);
        // }
        // else
        // {
        //     return _word;
        // }
    }

    public void HideWord()
    {
        _scriptureHidden = true;
    }
}