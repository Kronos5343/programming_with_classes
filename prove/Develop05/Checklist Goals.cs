using System;



class Checklist : Goal
{
    private int times_to_complete;
    private int extra_points;
    public Checklist (string name, string discription, int points, int times_to_complete, int extra_points) : base(name, discription, points)
    {
        this.times_to_complete = times_to_complete;
        this.extra_points = extra_points;
    }
    public static Checklist make_checklist_goal()
    {
        Console.WriteLine("What is the name of the goal? ");
        var name = Console.ReadLine();
        Console.WriteLine("What is the discription of the goal? ");
        var discription = Console.ReadLine();
        Console.WriteLine("How many points is the goal worth per completion? ");
        var points = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times of completion to complete full goal? ");
        var times_to_complete = int.Parse(Console.ReadLine());
        Console.WriteLine("How many points is the bonus worth? ");
        var extra_points = int.Parse(Console.ReadLine());
        return new Checklist(name, discription, points, times_to_complete, extra_points);
    }
















}