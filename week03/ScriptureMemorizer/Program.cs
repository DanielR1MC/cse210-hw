using System;
using System.Collections.Generic;

// Creativity
// 1. There are more than one scripture, that choose itself randomly
// 2. The user can choose how many words hide (If there is no imput, 3 word will hide itself)
// 3. There is a spicific class to hide the words (Hider)


class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding."
            ),
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son."
            ),
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."
            ),
            new Scripture(
                new Reference("Alma", 37, 6, 7),
                "By small and simple things are great things brought to pass."
            )
        };

        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        Console.Write("How many words would you like to hide each round? (default 3): ");
        string countInput = Console.ReadLine() ?? "";
        int wordsToHide = 3;

        if (int.TryParse(countInput, out int parsedCount) && parsedCount > 0)
        {
            wordsToHide = parsedCount;
        }

        string input = "";

        while ((input ?? "").ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();

            if ((input ?? "").ToLower() == "quit")
            {
                break;
            }

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            scripture.HideRandomWords(wordsToHide);
        }
    }
}