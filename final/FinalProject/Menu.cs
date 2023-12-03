using System;
class MenuClass
{
    
    public void menu1()
    {
        string answer = "0";
        while (answer != "3")
        {
            Console.WriteLine(" Menu:\n1. Load Account\n2. Create Account\n3. Exit\nPlease choose an option: ");
            string response = Console.ReadLine();

            if (response == "1")
            {
                
            }

            else if (response == "2")
            {
                menu2();
            }

            else if (response == "3")
            {
                answer = "3";
            }

            else
            {
                Console.WriteLine("Please choose a valid option!");
            }


        }



    }

    public void menu2()
    {
        string answer = "0";
        while (answer != "6")
        {
            Console.WriteLine(" Menu:\n1. Checking Bal\n2. Savings Bal\n3. Deposite\n4. Withdraw \n5. Smart Deposite \n6. Go Back\nWhat would you like to do? ");
            string response = Console.ReadLine();

            if (response == "1")
            {
                
            }

            else if (response == "2")
            {
                
            }

            else if (response == "3")
            {
        
            }

            else if (response == "4")
            {
                
            }

            else if (response == "5")
            {
                
            }

            else if (response == "6")
            {
                answer = "6";
            }

            else
            {
                Console.WriteLine("Please choose a valid option!");
            }


        }
        
    }
}