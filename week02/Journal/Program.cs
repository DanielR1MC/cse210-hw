using System;
using System.Collections.Generic;
using System.IO; 

class Program
{
    static void Main(string[] args) 
    {
        int ifnumber = 0;
        
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal theJournal = new Journal();

        while (ifnumber != 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please Select one of the following choices");
            Console.WriteLine("");
            Console.WriteLine("1.- Write");
            Console.WriteLine("2.- Display");
            Console.WriteLine("3.- Load");
            Console.WriteLine("4.- Save");
            Console.WriteLine("5.- Quit");
            Console.Write("What would you like to do? ");
            ifnumber = int.Parse(Console.ReadLine());

            if (ifnumber == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);


                Console.Write("> ");
                string userEntry = Console.ReadLine();

                string currentDate = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = currentDate;
                newEntry._promptText = prompt;
                newEntry._entryText = userEntry;

                theJournal.AddEntry(newEntry);
            }
            else if (ifnumber == 2)
            {
                theJournal.DisplayAll();
            }
            else if (ifnumber == 3)
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
            }
            else if (ifnumber == 4)
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }
        }
    }
}