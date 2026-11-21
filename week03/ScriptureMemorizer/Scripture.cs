using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Hider _hider;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _hider = new Hider();

        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        _hider.HideRandomWords(_words, numberToHide);
    }

    public string GetDisplayText()
    {
        string wordsText = "";

        foreach (Word word in _words)
        {
            wordsText += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} - {wordsText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}