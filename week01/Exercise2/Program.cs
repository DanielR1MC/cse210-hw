using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "placeholder";
        string pass = "false";

        Console.Write("What is your porcentage grade? ");
        string grade = Console.ReadLine();
        int nGrade = int.Parse(grade);
        if (nGrade >= 90)
        {
            if (nGrade <= 92) {letter = "A-";}
            else if (nGrade <= 96) {letter = "A";}
            else if (nGrade >= 97) {letter = "A+";}
        }
        else if (nGrade <= 89 && nGrade >= 80)
        {
            if (nGrade <= 82) {letter = "B-";}
            else if ( nGrade <= 86) {letter = "B";}
            else if (nGrade >= 87) {letter = "B+";}
        }
        else if (nGrade <= 79 && nGrade >= 70)
        {
            if (nGrade <= 72) {letter = "C-";}
            else if (nGrade <= 76) {letter = "C";}
            else if (nGrade >= 77) {letter = "C+";}
        }
        else if (nGrade <= 69 && nGrade >= 60)
        {
            if (nGrade <= 62) {letter = "D-";}
            else if (nGrade <= 66) {letter = "D";}
            else if (nGrade >= 67) {letter = "D+";}
        }
        else {letter = "F";}

        if (nGrade <= 70) {pass = "false";} else {pass = "true";}

        if (pass != "true") {Console.WriteLine($"We are very sorry, But you didn't pass the course. You have {nGrade}%. Try better next time!!");}
        else {Console.WriteLine($"Congratulatios, you adchieve it with {nGrade}% {letter}!! See you in the next course!");}


    }
}