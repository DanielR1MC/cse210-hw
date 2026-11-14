using System;
using System.Collections.Generic;
using System.IO; 

class Program
{
    static void Main(string[] args) 
    {
        string ifnumber = "0";
        
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal theJournal = new Journal();

        while (ifnumber != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please Select one of the following choices");
            Console.WriteLine("");
            Console.WriteLine("1.- Write");
            Console.WriteLine("2.- Display");
            Console.WriteLine("3.- Load (Only if you have a file!)");
            Console.WriteLine("4.- Save (Try this first if you don't have a file!)");
            Console.WriteLine("5.- Quit");
            Console.Write("What would you like to do? ");
            ifnumber = (Console.ReadLine());

            if (ifnumber == "1")
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
            else if (ifnumber == "2")
            {
                theJournal.DisplayAll();
            }
            else if (ifnumber == "3")
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
                Console.Write("Loading....");
            }
            else if (ifnumber == "4")
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
                Console.Write("Saving the file....");
            }
            else if (ifnumber == "5")
            {
                Console.WriteLine("Thanks for trying!!");
                Console.WriteLine("See you next time");
            }
            else {Console.WriteLine("Are you pretty sure about your input? Please Try again!!");}
        }
    }
}