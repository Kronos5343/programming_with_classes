using System;



class Eternal : Goal
{

    public Eternal (string name, string discription, int points) : base(name, discription, points)
    {

    }
    public static Eternal make_eternal_goal()
    {
        Console.WriteLine("What is the name of the goal? ");
        var name = Console.ReadLine();
        Console.WriteLine("What is the discription of the goal? ");
        var discription = Console.ReadLine();
        Console.WriteLine("How many points is the goal worth? ");
        var points = int.Parse(Console.ReadLine());
        return new Eternal(name, discription, points);
    }





















}



