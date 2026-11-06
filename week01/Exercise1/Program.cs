using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, What is your first name? ");
        string fname = Console.ReadLine();
        Console.Write("What about your last name? ");
        string lname = Console.ReadLine();
        Console.WriteLine($"Your name is {lname}, {fname} {lname}");
        Console.WriteLine("Thank you so much for share!");
    }
}