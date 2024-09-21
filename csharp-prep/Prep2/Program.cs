using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade as a percent: ");
        string grade = Console.ReadLine();

        int gradePercent = int.Parse(grade);

        string letter = "";

        int sign = gradePercent % 10;

        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent < 90 && gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent < 80 && gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent < 70 && gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        string letterSign = "";

        if (sign >= 7)
        {
            letterSign = "+";
        }
        else if (sign < 3)
        {
            letterSign = "-";
        }

        if (gradePercent >= 93)
        {
            letterSign = "";
        }
        
        if (letter == "F")
        {
            letterSign = "";
        }

        Console.WriteLine($"Your letter grade is: {letter}{letterSign}");
        if (gradePercent >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass the class.");
        }
    }
}