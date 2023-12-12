using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
class MenuClass
{
    //I had Chat GPT help me get an idea of what I needed to do for the void "CallFile" and "AddToList".
    public List<Account> allAccounts = new List<Account>();

    public void Callfile()
    {
        string file = "Accounts.txt";
        List<Account> loadAccounts = new List<Account>();
        AddToList(loadAccounts, file);
    }

    public void AddToList(List<Account> loadAccounts, string file)
    {
        string[] lines = File.ReadAllLines(file);

        foreach (var line in lines)
        {
            string[] stuff = line.Split("*^*");

            int load = 2;
            string accountName = stuff[0];
            string accountNumber = stuff[1];
            double accountTotal = double.Parse(stuff[2]);
            double accountChecking = double.Parse(stuff[3]);
            double accountSavings = double.Parse(stuff[4]);
            double myMoney = double.Parse(stuff[5]);                    
            double Bills = double.Parse(stuff[6]);
            
            
            Account account = new Account(load,accountName,accountNumber,accountTotal,accountChecking,accountSavings,myMoney,Bills );
            {
            }
            loadAccounts.Add(account);  
        }
        allAccounts.AddRange(loadAccounts); 
    }









    public void menu1()
    {
        Callfile();

        string answer = "0";
        while (answer != "5")
        {
            Console.WriteLine(" Menu:\n1. Load Account\n2. Create Account\n3. Save \n4. Create Goal\n5. Exit\nPlease choose an option: ");
            string response = Console.ReadLine();

            if (response == "1")
            {
                foreach (var account in allAccounts)
                {
                    Console.WriteLine($"{account.accountName}\n{account.accountNumber}\n");
                }
                Console.WriteLine("What is the account number to the account you would like to load? ");
                string loadAcc = Console.ReadLine();
                foreach (var account in allAccounts)
                {
                    if (account.accountNumber == loadAcc)
                    {
                        menu2(account);
                    }
                }
                
            }

            else if (response == "2")
            {
                Console.WriteLine("What is the new account name? ");
                string createAccName = Console.ReadLine();
                Account Acc = new Account(1,createAccName,"0000",0,0,0,0,0);
                allAccounts.Add(Acc);
            }

            else if (response == "3")
            {
                using (StreamWriter outputFile = new StreamWriter("Accounts.txt"))
                {
                    foreach (var account in allAccounts)
                    {
                        outputFile.WriteLine(account.WriteToFile());
                    }
                    
                }
            }

            else if (response == "4")
            {
                Console.WriteLine("Which account number do you want to add a goal to?");
                string accToAddTo = Console.ReadLine();
                Console.WriteLine("Would you like to create or view a goal (c or v)?");
                string CorV = Console.ReadLine();


                foreach (var account in allAccounts)
                {   
                    if (account.accountNumber == accToAddTo)
                    {
                        Goals Goal = new Goals(0,account.accountName,account.accountNumber,account.accountTotal,account.accountChecking,account.accountSavings,account.myMoney,account.Bills,"",0,0);
                        if (CorV == "c")
                        {
                            Goal.makeGoal();
                        }
                        else if (CorV == "v")
                        {
                            if (Goal.goalName == "")
                            {
                                Console.WriteLine("No goals set yet.");
                            }
                            else
                            {
                                Goal.ViewOrProgressGoal(Goal.goalName, Goal.moneyGoal, Goal.moneyEarned);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid response.");
                        }
                    }
                }

                
                
            }

            else if (response == "5")
            {
                answer = "5";
            }

            else
            {
                Console.WriteLine("Please choose a valid option!");
            }


        }



    }

    public void menu2(Account account)
    {
        

        string answer = "0";
        while (answer != "8")
        {

            Console.WriteLine(" Menu:\n1. Checking Bal\n2. Savings Bal\n3. Personal Money Bal\n4. Bills Bal\n5. Deposite\n6. Withdraw \n7. Smart Deposite \n8. Go Back\nWhat would you like to do? ");
            string response = Console.ReadLine();

            if (response == "1")
            {
            
                account.checking();
            }

            else if (response == "2")
            {
            
                account.savings();
            }

            else if (response == "3")
            {
            
                account.personalMoney();
            }

            else if (response == "4")
            {
            
                account.moneyForBills();
            }

            else if (response == "5")
            {
            
                account.deposite();
            }

            else if (response == "6")
            {
                
                account.withdraw();
            }

            else if (response == "7")
            {
            
                account.smartDeposite();
            }

            else if (response == "8")
            {
                answer = "8";
            }

            else
            {
                Console.WriteLine("Please choose a valid option!");
            }


        }
        
    }
}