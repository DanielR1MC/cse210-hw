using System;

class Program
{
    static void Main(string[] args)
    {
        string stay = "yes";
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        string guess = "0";
        int victories = 0;
        Console.WriteLine("Guess the number!");
        while (stay == "yes")
        {
            guess = Console.ReadLine();
            int nGuess = int.Parse(guess);

            if (nGuess != number)
            {
                if (nGuess > number) {Console.WriteLine("Try guessing lower!");}
                else if (nGuess < number) {Console.WriteLine("Try guessing Higher!");}
            }

            else 
            {
                victories = victories + 1;
                Console.WriteLine("Congratulations, you guessed it!");
                Console.WriteLine("Do you want to try again? yes/no ");
                stay = Console.ReadLine();
                if (stay == "yes") 
                {
                    number = randomGenerator.Next(1, 100);
                    Console.WriteLine("Guess the number!");
                }
                else
                {
                    Console.WriteLine($"Thanks for playing, your victory countdown was {victories}. See you next time");
                }
            }
        }
    }
}