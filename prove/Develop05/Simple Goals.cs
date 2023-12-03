using System;



class Simple : Goal
{
     
    public Simple (string name, string discription, int points) : base(name, discription, points)
    {
        
    }
    public static Simple make_simple_goal()
    {
        Console.WriteLine("What is the name of the goal? ");
        var name = Console.ReadLine();
        Console.WriteLine("What is the discription of the goal? ");
        var discription = Console.ReadLine();
        Console.WriteLine("How many points is the goal worth? ");
        var points = int.Parse(Console.ReadLine());
        return new Simple(name, discription, points);
    }




}


