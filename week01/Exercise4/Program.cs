using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        string stay = "1";
        string number = "0";
        float inumber = 1;
        float sum = 0;
        float largest = 0;
        float average = 0;
        Console.WriteLine("Enter a list of numbers. Type 0 to finish");
        while (stay != "0")
        {
            Console.Write("Enter a number: ");
            number = Console.ReadLine();
            inumber = float.Parse(number);
            if (inumber != 0){numbers.Add(inumber);}
            else {stay = "0";}
            
        }
        foreach (float n in numbers)
            {
                sum = sum + n;

                if (n > largest) {largest = n;}
            }
        average = sum / numbers.Count;
        Console.WriteLine($"The total sum is {sum}");
        Console.WriteLine($"The average number is {average}");
        Console.WriteLine($"The largest number is {largest}");
        Console.WriteLine("The sortest list is: ");
        foreach (float n in numbers){Console.WriteLine(n);}
    }
}