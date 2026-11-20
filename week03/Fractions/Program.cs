using System;
using System.Collections.Generic;
using System.IO; 

class Program
{
    static void Main(string[] args) 
    {
        string ifnumber = "0";

        Console.WriteLine("Welcome to the Fraction Program!");
        Fraction fraction = new Fraction();
        while (ifnumber != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1.- Create a new fraction (Constructors)");
            Console.WriteLine("2.- Set top number (SetTop)");
            Console.WriteLine("3.- Set bottom number (SetBottom)");
            Console.WriteLine("4.- Display fraction and decimal value");
            Console.WriteLine("5.- Quit");
            Console.Write("What would you like to do? ");
            ifnumber = Console.ReadLine();

            if (ifnumber == "1")
            {
                Console.WriteLine("\nChoose a type:");
                Console.Write("Choice: ");
                Console.WriteLine("1.- Default (1/1)");
                Console.WriteLine("2.- Whole number (e.g., 5 -> 5/1)");
                Console.WriteLine("3.- Top and Bottom (e.g., 3 and 4 -> 3/4)");
                string subChoice = Console.ReadLine();

                if (subChoice == "1")
                {
                    fraction = new Fraction();
                    Console.WriteLine("Created default fraction 1/1.");
                }
                else if (subChoice == "2")
                {
                    Console.Write("Enter whole number: ");
                    int whole = int.Parse(Console.ReadLine());
                    fraction = new Fraction(whole);
                    Console.WriteLine($"Created fraction {fraction.GetFractionString()}.");
                }
                else if (subChoice == "3")
                {
                    Console.Write("Enter top number: ");
                    int top = int.Parse(Console.ReadLine());
                    Console.Write("Enter bottom number: ");
                    int bottom = int.Parse(Console.ReadLine());
                    fraction = new Fraction(top, bottom);
                    Console.WriteLine($"Created fraction {fraction.GetFractionString()}.");
                }
                else
                {
                    Console.WriteLine("Are you reaaaaally sure about your input?");
                }
            }
            else if (ifnumber == "2")
            {
                Console.Write("Enter top number: ");
                int top = int.Parse(Console.ReadLine());
                fraction.SetTop(top);
            }
            else if (ifnumber == "3")
            {
                Console.Write("Enter bottom number: ");
                int bottom = int.Parse(Console.ReadLine());
                fraction.SetBottom(bottom);
            }
            else if (ifnumber == "4")
            {
                Console.WriteLine(fraction.GetFractionString());
                Console.WriteLine(fraction.GetDecimalValue());
            }
            else if (ifnumber == "5")
            {
                Console.WriteLine("Thanks for try this. See you later!");
            }
            else {Console.WriteLine("Are you pretty sure about your input? Please Try again!!");}
        }
    }
}