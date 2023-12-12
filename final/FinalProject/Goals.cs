using System;
using System.Formats.Asn1;

class Goals : Account
{
    public string goalName;
    public double moneyGoal;
    public double moneyEarned;
    public Goals (int createOrLoad, string accName, string accNumber, double accTotal, double accChecking, double accSavings, double accMyMoney, double accBills, string goalName, double moneyGoal, double moneyEarned) : base(createOrLoad, accName,accNumber,accTotal,accChecking,accSavings,accMyMoney,accBills)
    {
        this.goalName = goalName;
        this.moneyGoal = moneyGoal;
        this.moneyEarned = moneyEarned;
    }
    public void makeGoal()
    {
        Console.WriteLine("What is the money goal you want to reach?");
        moneyGoal = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the name of this goal?");
        goalName = Console.ReadLine();
        moneyEarned = 0;

    }

    public void ViewOrProgressGoal(string goalName, double moneyGoal, double moneyEarned)
    {
        Console.WriteLine($"{goalName}\n{moneyEarned}/{moneyGoal}");
        Console.WriteLine("Would you like to deposite into your goal (y/n)?");
        string answer = Console.ReadLine();
        if (answer == "y")
        {
            Console.WriteLine("How much would you like to deposite?");
            int depositeIntoGoal = int.Parse(Console.ReadLine());
            moneyEarned += depositeIntoGoal;
        }
        else
        {
            Console.WriteLine("Hope you come back soon to improve your goal!");
        }
    }

}