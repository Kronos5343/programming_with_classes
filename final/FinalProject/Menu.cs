using System;
using Microsoft.VisualBasic;
class MenuClass
{
    List<Account> allAccounts = new List<Account>();
    public void menu1()
    {
        string answer = "0";
        while (answer != "4")
        {
            Console.WriteLine(" Menu:\n1. Load Account\n2. Create Account\n3. Save \n4. Exit\nPlease choose an option: ");
            string response = Console.ReadLine();

            if (response == "1")
            {
                Console.WriteLine("What is the account number to the account you would like to load? ");
                string LoadAcc = Console.ReadLine();
                menu2(LoadAcc);
            }

            else if (response == "2")
            {
                Console.WriteLine("What is the new account name? ");
                string CreateAcc = Console.ReadLine();
                Account Acc = new Account(CreateAcc);
                allAccounts.Add(Acc);
            }

            else if (response == "3")
            {
                using (StreamWriter outputFile = new StreamWriter("Accounts.txt"))
                {
                    foreach (var account in allAccounts)
                    {
                        outputFile.Write(account.WriteToFile());
                    }
                    
                }
            }

            else if (response == "4")
            {
                answer = "4";
            }

            else
            {
                Console.WriteLine("Please choose a valid option!");
            }


        }



    }

    public void menu2(string input)
    {
        

        // string answer = "0";
        // while (answer != "6")
        // {
        //     Console.WriteLine(" Menu:\n1. Checking Bal\n2. Savings Bal\n3. Deposite\n4. Withdraw \n5. Smart Deposite \n6. Go Back\nWhat would you like to do? ");
        //     string response = Console.ReadLine();

        //     if (response == "1")
        //     {
        //         Account Acc = new Account();
        //         Acc.checking();
        //     }

        //     else if (response == "2")
        //     {
        //         Account Acc = new Account();
        //         Acc.savings();
        //     }

        //     else if (response == "3")
        //     {
        //         Account Acc = new Account();
        //         Acc.deposite();
        //     }

        //     else if (response == "4")
        //     {
        //         Account Acc = new Account();
        //         Acc.withdraw();
        //     }

        //     else if (response == "5")
        //     {
        //         Account Acc = new Account();
        //         Acc.smartDeposite();
        //     }

        //     else if (response == "6")
        //     {
        //         answer = "6";
        //     }

        //     else
        //     {
        //         Console.WriteLine("Please choose a valid option!");
        //     }


        // }
        
    }
}