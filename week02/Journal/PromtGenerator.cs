using System;
using System.Collections.Generic;
using System.IO; 

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
    "How did your day go?",
    "What was the best feeling I have today?", 
    "What person did I help today?",
    "If I could repeat something of today, what would it be?",
    "What was the best part of my day?",
    };

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompts.Count);

        return (_prompts[number]);
    }
}