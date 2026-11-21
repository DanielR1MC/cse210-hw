using System;
using System.Collections.Generic;

public class Hider
{
    private Random _random;
    public Hider()
    {
        _random = new Random();
    }

    public void HideRandomWords(List<Word> words, int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {visibleWords.Add(word);}
        }


        int countToHide = Math.Min(numberToHide, visibleWords.Count);


        for (int i = 0; i < countToHide; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
}