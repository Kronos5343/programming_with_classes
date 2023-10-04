using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayMessage();
        
        DisplayUserName();
        
        int FavNum = AskForNum();
        
        NumSquared(FavNum);


        
    } 
    
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string DisplayUserName()
    {
        Console.Write("What's your name? ");
        string UserName = Console.ReadLine();

        Console.WriteLine($"Hello, {UserName}");

        return UserName;
    }

    static int AskForNum()
    {
        Console.Write("What's your favorite number? ");
        int FavNum = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Your favorite number is: {FavNum}");

        return FavNum;
    }
    
    
    
    static int NumSquared(int FavNum)
    {   
        int SquaredNum = FavNum * FavNum;
        Console.WriteLine($"Your favorite number squared is: {SquaredNum}");

        return SquaredNum;
    }
    
}