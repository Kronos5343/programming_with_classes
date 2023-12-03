using System;
using Microsoft.VisualBasic;



class Goal
{
    private string name;
    private string discription;
    private int points;
    private bool is_complete;
    private int times_completed;

    protected Goal(string name, string discription, int points)
    {
        this.name = name;
        this.discription = discription;
        this.points = points;
        is_complete = false;
        times_completed = 0;
    }

    public virtual void write_to_file(string list_of_goals)
    {
        Console.WriteLine("What is the full file name (Ex: file.txt)? ");
        string file = Console.ReadLine();
        using (StreamWriter Choosen_file = new StreamWriter(file))
        {
            Choosen_file.WriteLine($"{name}%{discription}%{points}%{is_complete}%{times_completed}~");

        }


    }
}






