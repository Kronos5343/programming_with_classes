using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string response = Console.ReadLine();
        int percent = int.Parse(response);

        string ltr = "";

        if (percent >= 90)
        {
            ltr = "A";
        }
        else if (percent >= 80)
        {
            ltr = "B";
        }
        else if (percent >= 70)
        {
            ltr = "C";
        }
        else if (percent >= 60)
        {
            ltr = "D";
        }
        else
        {
            ltr = "F";
        }

        Console.WriteLine($"This is your grade: {ltr}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You did it!");
        }
        else
        {
            Console.WriteLine("try again :(");
        }
    }
}