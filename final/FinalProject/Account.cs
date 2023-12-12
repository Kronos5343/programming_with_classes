using System;
using System.Runtime;
using System.Runtime.InteropServices;

class Account
{
    public string accountName;
    public string accountNumber;
    public double accountTotal;
    public double accountChecking;
    public double accountSavings;
    public double myMoney;
    public double Bills;
    public Account(int createOrLoad, string accName, string accNumber, double accTotal, double accChecking, double accSavings, double accMyMoney, double accBills)
    {
        if (createOrLoad == 1)
        {
            int fourdigit = 0;
        Random randomNums = new Random();
        while (fourdigit != 4)
        {
            int accID = randomNums.Next(1,10);
            accountNumber += accID;
            fourdigit++;
        }
        accountName = accName;
        }
        else
        {
            this.accountName = accName;
            this.accountNumber = accNumber;
            this.accountTotal = accTotal;
            this.accountChecking = accChecking;
            this.accountSavings = accSavings;
            this.myMoney = accMyMoney;
            this.Bills = accBills;
            

        }

    }
    public void checking()
    {
        Console.WriteLine($"${accountChecking}");
    }

    public void savings()
    {
        Console.WriteLine($"${accountSavings}");
    }

    public void personalMoney()
    {
        Console.WriteLine($"${myMoney}");
    }

    public void moneyForBills()
    {
        Console.WriteLine($"${Bills}");
    }

    public void deposite()
    {
        Console.WriteLine("How much would you like to deposite?");
        int amount = int.Parse(Console.ReadLine());
        int breakout = 0;
        while (breakout != 1)
        {
            Console.WriteLine("What section would you like to deposite to?\n(Checking = c)(Savings = s)(My Money = m)(Bills = b) ");
            var depositeToAccount = Console.ReadLine();
            
            if (depositeToAccount == "c")
            {
                accountChecking += amount;
                breakout = 1;
            }
            else if (depositeToAccount == "s")
            {
                accountSavings += amount;
                breakout = 1;
            }
            else if (depositeToAccount == "m")
            {
                myMoney += amount;
                breakout = 1;
            }
            else if (depositeToAccount == "b")
            {
                Bills += amount;
                breakout = 1;
            }
            else
            {
                Console.WriteLine("Please Choose a valid option.");
            }
        }
    }

    public void withdraw()
    {
        int breakout = 0;
        while (breakout != 1)
        {
            Console.WriteLine("How much would you like to withdraw?");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("What section would you like to withdraw from?\n(Checking = c)(Savings = s)(My Money = m)(Bills = b) ");
            var withdrawFromAccount = Console.ReadLine();
            if (withdrawFromAccount == "c")
            {
                if (accountChecking > amount)
                {
                    accountChecking -= amount;
                }
                else
                {
                    Console.WriteLine("Not enough funds.");
                }
                breakout = 1;
            }
            else if (withdrawFromAccount == "s")
            {
                if (accountSavings > amount)
                {
                    accountSavings -= amount;
                }
                else
                {
                    Console.WriteLine("Not enough funds.");
                }
                breakout = 1;
            }
            else if (withdrawFromAccount == "m")
            {
                if (myMoney > amount)
                {
                    myMoney -= amount;
                }
                else
                {
                    Console.WriteLine("Not enough funds.");
                }
                breakout = 1;
            }
            else if (withdrawFromAccount == "b")
            {
                if (Bills > amount)
                {
                    Bills -= amount;
                }
                else
                {
                    Console.WriteLine("Not enough funds.");
                }
                breakout = 1;
            }
            else
            {
                Console.WriteLine("Please Choose a valid option.");
            }
        }
    }

    public void smartDeposite()
    {
        Console.WriteLine("How much money would you like to smart deposite?");
        double amount = double.Parse(Console.ReadLine());

        Console.WriteLine("How much does your bills cost this month?");
        int billsTotal = int.Parse(Console.ReadLine());
        if (Bills < billsTotal)
        {
            double SDChecking = (amount *.15);
            double SDmyMoney = (amount *.20);
            double SDBills = (amount *.50);

            accountChecking += SDChecking;
            myMoney += SDmyMoney;
            Bills += SDBills;

            amount -= (SDChecking + SDmyMoney + SDBills);

            accountSavings += amount;
        }
        else
        {
            double SDChecking = (amount *.25);
            double SDmyMoney = (amount *.25);
            
            amount -= (SDChecking + SDmyMoney);

            accountSavings += amount;
        }
        
    }

    public string WriteToFile()
    {
        Goals goal = new Goals(0,accountName,accountNumber,accountTotal,accountChecking,accountSavings,myMoney,Bills,"",0,0);
        string saveAccount = ($"{accountName}*^*{accountNumber}*^*{accountTotal}*^*{accountChecking}*^*{accountSavings}*^*{myMoney}*^*{Bills}*^*{goal.goalName}*^*{goal.moneyEarned}*^*{goal.moneyGoal}*^*");
        
        return saveAccount;
    }





}